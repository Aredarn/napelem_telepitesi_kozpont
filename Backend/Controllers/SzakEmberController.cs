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
            /*
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

                foreach (var arucikk in arucikkek.Keys)
                {
                    var quantity = arucikkek[arucikk];
                    var projektArucikkhez = context.ProjektekArucikkhez.SingleOrDefault(p => p.ProjectToItemID == projectID && p.Arucikknev == arucikkek[arucikk].First);

                    if (projektArucikkhez == null)
                    {
                        projektArucikkhez = new ProjektArucikkhez
                        {
                            ProjectToItemID = projectID,
                            Arucikknev = arucikkek.First,
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
            */
        }


        // A5.

        public void Arkalkulacio(int projectID, int becsultOra, DateTime becsultVegzes)
        {
            using (var context = new NapelemDbContext())
            {
                var project = context.Projekt.FirstOrDefault(c => c.ProjectID == projectID);

                
                if(project == null)
                {
                    MessageBox.Show($"Nem létezik a {projectID}. ID val ellátott projekt");
                }
                else if (project.ApproxCost != null)
                {
                    MessageBox.Show($"Ennek a projektnek már megtörtént az árkalkulációja");
                }
                else
                {
                    project.ApproxCost = becsultOra;
                    project.ApproxTimeToFinish = becsultVegzes;
                    context.SaveChanges();
                    MessageBox.Show($"Az árkalkuláció sikeresen frissítve lett a {projectID}. ID-val ellátott projektben.");
                }
            }

        }

    }
}
