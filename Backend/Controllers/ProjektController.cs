using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace napelem_telepito_kozpont.Backend.Controllers
{
    public class ProjektController
    {
        public int ProjektLetrehozasa(Projektek projekt)
        {
            try
            {
                NapelemDbContext context = new();

                context.Projekt.Add(projekt);
                context.SaveChanges();

                return projekt.ProjectID;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return 0;
            }

        }
        public List<ProjektViewModel> ProjektListaLekerese()
        {
            try
            {
                NapelemDbContext context = new();

                List<ProjektViewModel> projektek = context.Projekt
                    .Join(context.Megrendelok,
                          megrendelok => megrendelok.ClientID,
                          projekt => projekt.ClientID,
                          (projekt, megrendelok) => new {
                              projekt.ProjectID,
                              projekt.leiras,
                              projekt.helyszin,
                              megrendelok.Name,
                              megrendelok.Address
                          })
                    .Join(context.projectStatuszok,
                          result => result.ProjectID,
                          projektStatuszok => projektStatuszok.ProjectID,
                          (result, projektStatuszok) => new {
                              result.ProjectID,
                              result.leiras,
                              result.helyszin,
                              result.Name,
                              result.Address,
                              projektStatuszok.StatusID
                          })
                    .Join(context.Státusz,
                          result => result.StatusID,
                          statusz => statusz.StatusID,
                          (result, statusz) => new {
                              result.ProjectID,
                              result.leiras,
                              result.helyszin,
                              result.Name,
                              result.Address,
                              result.StatusID,
                              statusz.StatusInfo
                          })
                    .Select(result => new ProjektViewModel
                    {
                        ProjektID = result.ProjectID,
                        Helyszin = result.helyszin.ToString(),
                        Leiras = result.leiras.ToString(),
                        MegrendeloNev = result.Name,
                        MegrendeloCim = result.Address,
                        Statusz = result.StatusInfo
                    }).ToList();

                MessageBox.Show("TEST");

                return projektek;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return new List<ProjektViewModel>();
            }
        }
    }
    public class ProjektViewModel
    {
        public int ProjektID { get; set; }
        public string Helyszin { get; set; }
        public string Leiras { get; set; }
        public string MegrendeloNev { get; set; }
        public string MegrendeloCim { get; set; }
        public string Statusz { get; set; }
    }
}
