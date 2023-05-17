using Mysqlx.Crud;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace napelem_telepito_kozpont.Backend.Controllers
{
    public class SzakEmberController
    {


        // A4.
        public void AruCikkekBerendel(Dictionary<string, int> arucikkek, int projectID)
        {
            
            if (arucikkek == null || arucikkek.Count == 0)
            {
                MessageBox.Show("Nincs árucikk hozzáadva a kosárhoz.");
                return;
            }

            using (var context = new NapelemDbContext())
            {
                var project = context.Projekt.SingleOrDefault(p => p.ProjectID == projectID);
                if (project == null)
                {
                    MessageBox.Show("A projekt nem található az adatbázisban.");
                    return;
                }

                foreach (var arucikk in arucikkek)
                {
                    string nev = arucikk.Key;
                    int quantity = arucikk.Value;
                    var AruID_Nevbol = context.Arucikk.FirstOrDefault(c => c.Arucikknev == nev);
                    var projektArucikkhez = context.ProjektekArucikkhez.SingleOrDefault(p => p.ProjectToItemID == projectID && p.ArucikkID == AruID_Nevbol.ArucikkID);

                    if (projektArucikkhez == null)
                    {
                        projektArucikkhez = new ProjektArucikkhez
                        {
                            ProjectID = projectID,
                            ArucikkID = AruID_Nevbol.ArucikkID,
                            Quantity = quantity,
                            IsReserved = false
                        };
                        context.ProjektekArucikkhez.Add(projektArucikkhez);
                    }
                    else
                    {
                        projektArucikkhez.Quantity += quantity;
                    }
                }

                // PROJEKTSTATUST is modosítani kell DRAFT-ra


                context.SaveChanges();
                MessageBox.Show("A termékek sikeresen hozzárendelve a projekthez.");
            }
            
        }


        // A5.
        public void Arkalkulacio(int projectID, int becsultOra)
        {
            using (var context = new NapelemDbContext())
            {
                var project = context.Projekt.FirstOrDefault(c => c.ProjectID == projectID);

                
                if(project == null)
                {
                    MessageBox.Show($"Nem létezik a {projectID}. ID val ellátott projekt");
                }
                else if (project.ApproxCost > null)
                {
                    MessageBox.Show($"Ennek a projektnek már megtörtént az árkalkulációja");
                }
                else
                {
                    project.ApproxCost = becsultOra;
                    
                    context.SaveChanges();
                    MessageBox.Show($"Az árkalkuláció sikeresen frissítve lett a {projectID}. ID-val ellátott projektben.");
                }
            }
        }

        //A6
        public void TeljesArkalkulacio(int projectID)
        {
            int totalPrice = 0;

            using (var context = new NapelemDbContext())
            {
                var projectItems = context.ProjektekArucikkhez
                    .Where(pi => pi.ProjectID == projectID)
                    .ToList();

                // Itt tárolja azokat az árucikkeket amelyek nincsenek egyáltalán vagy csak pár db
                var missingItems = new List<string>();

                foreach (var projectItem in projectItems)
                {
                    var arucikk = context.Arucikk.FirstOrDefault(a => a.ArucikkID == projectItem.ArucikkID);

                    if (arucikk != null)
                    {
                        var availableQuantity = context.Polc.Where(p => p.ArucikkID == arucikk.ArucikkID).Sum(p => p.ItemsInShelf);

                        if (availableQuantity >= projectItem.Quantity)
                        {
                            totalPrice += arucikk.Price * projectItem.Quantity;
                        }
                        else
                        {
                            missingItems.Add(arucikk.Arucikknev);
                        }
                    }
                }


                if (missingItems.Count > 0)
                {
                    
                    
                    string missingItemsString = string.Join(", ", missingItems);
                    MessageBox.Show("Az alábbi árucikkek hiányoznak a raktárból: " + missingItemsString);
                    if (!context.projectStatuszok.Any(ps => ps.ProjectID == projectID && ps.StatusID > 2))
                        context.projectStatuszok.Add(new ProjectStatuszok { ProjectID = projectID, StatusID = 3, FazisKezdete = DateTime.Now });
                    else
                        MessageBox.Show("Már a 3-as (WAIT) fáziban van/volt egyszer");
                }
                else
                {
                    if (!context.projectStatuszok.Any(ps => ps.ProjectID == projectID && ps.StatusID > 3))
                    {
                        var project = context.Projekt.FirstOrDefault(p => p.ProjectID == projectID);
                        int originalApproxCost = project.ApproxCost;

                        project.ApproxCost = totalPrice + originalApproxCost;

                        context.projectStatuszok.Add(new ProjectStatuszok { ProjectID = projectID, StatusID = 4, FazisKezdete = DateTime.Now });

                        MessageBox.Show("Az árkalkuláció sikeresen megtörtént. Az új árkalkuláció értéke: " + project.ApproxCost);
                    }
                    else if (totalPrice == 0)
                    {
                        MessageBox.Show("Nincsen termék rendelve ehhez a projekthez.");
                    }
                    else
                    {
                        MessageBox.Show("Az árkalkuláció már megtörtént a projektben.");
                    }

                }

                context.SaveChanges();
            }
        }

        //A7
        public void Véglegesítés(string status, int ProjectID)
        {
            using (var dbContext = new NapelemDbContext())
            {
                var existingStatus = dbContext.projectStatuszok.FirstOrDefault(p => p.ProjectID == ProjectID && (p.StatusID == 6 || p.StatusID == 7));

                if (existingStatus != null)
                {
                    MessageBox.Show("Az állapot már be van állítva ebben a fázisban.");
                    return;
                }

                ProjectStatuszok newStatus = new ProjectStatuszok();
                newStatus.ProjectID = ProjectID;
                newStatus.StatusID = 1;
                newStatus.FazisKezdete = DateTime.Now;

                switch (status)
                {
                    case "Teljesítve":
                        newStatus.StatusID = 6;
                        break;
                    case "Megszakítva":
                        newStatus.StatusID = 7;
                        break;
                    default:
                        MessageBox.Show("Ismeretlen státusz érték.");
                        return;
                }

                dbContext.projectStatuszok.Add(newStatus);
                dbContext.SaveChanges();
                MessageBox.Show($"Az állapot sikeresen beállítva: {status}");
            }
        }

    }
}
