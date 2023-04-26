using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
