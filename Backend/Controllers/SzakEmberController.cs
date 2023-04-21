using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Controllers
{
    internal class SzakEmberController
    {


        // A4.
        public void AruCikkekBerendel(Dictionary<Arucikk, int> arucikkek, int projectID)
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

                foreach (var arucikk in arucikkek.Keys)
                {
                    var quantity = arucikkek[arucikk];
                    var projektArucikkhez = context.ProjektekArucikkhez.SingleOrDefault(p => p.ProjectToItemID == projectID && p.Arucikk.Arucikknev == arucikk.Arucikknev);

                    if (projektArucikkhez == null)
                    {
                        projektArucikkhez = new ProjektArucikkhez
                        {
                            ProjectToItemID = projectID,
                            Arucikk = arucikk,
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


    }
}
