using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Mysqlx.Crud;
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
                    .Join(context.Statusz,
                          result => result.StatusID,
                          statusz => statusz.StatusID,
                          (result, statusz) => new {
                              result.ProjectID,
                              result.helyszin,
                              result.leiras,
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

                return projektek;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return new List<ProjektViewModel>();
            }
        }
        public List<ProjektViewModel2> ProjektLista2Lekerese()
        {
            try
            {
                NapelemDbContext context = new();

                List<ProjektViewModel2> projektek = context.Projekt
                    .Join(context.projectStatuszok,
                          projectStatuszok => projectStatuszok.ProjectID,
                          projekt => projekt.ProjectID,
                          (projekt, projectStatuszok) => new {
                              projekt.ProjectID,
                              projekt.leiras,
                              projekt.helyszin,
                              projekt.ApproxTimeToFinish,
                              projekt.ApproxCost,
                              projectStatuszok.StatusID
                          })
                    .Join(context.Statusz,
                          result => result.StatusID,
                          statusz => statusz.StatusID,
                          (result, statusz) => new {
                              result.ProjectID,
                              result.helyszin,
                              result.leiras,
                              result.StatusID,
                              result.ApproxTimeToFinish,
                              result.ApproxCost,
                              statusz.StatusInfo
                          })
                    .Select(result => new ProjektViewModel2
                    {
                        ProjektID = result.ProjectID,
                        VarhatoIdo = result.ApproxTimeToFinish.ToString(),
                        Ar = result.ApproxCost.ToString(),
                        Helyszin = result.helyszin,
                        Leiras = result.leiras,
                        Statusz = result.StatusInfo
                    }).ToList();

                return projektek;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return new List<ProjektViewModel2>();
            }
        }
        public void projektStatuszValtoztatasa(int projektID, string ujStatusz)
        {
            try
            {
                NapelemDbContext context = new();

                var statusz = context.Statusz
                    .Single(row => row.StatusInfo == ujStatusz);

                var projectStatuszok = context.projectStatuszok
                    .Single(row => row.ProjectID == projektID);

                projectStatuszok.StatusID = statusz.StatusID;
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public List<ProjektViewModel3> helyszinekLista(int projektID)
        {
            try
            {
                NapelemDbContext context = new();

                List<ProjektViewModel3> arucikkek = context.Projekt
                    .Where(pa => pa.ProjectID == projektID)
                    .Join(context.ProjektekArucikkhez,
                          projektekArucikkhez => projektekArucikkhez.ProjectID,
                          projekt => projekt.ProjectID,
                          (projekt, projektekArucikkhez) => new {
                              projekt.helyszin,
                              projektekArucikkhez.ArucikkID
                          })
                    .Join(context.Arucikk,
                          result => result.ArucikkID,
                          arucikk => arucikk.ArucikkID,
                          (result, arucikk) => new {
                              result.helyszin,
                              arucikk.ArucikkID,
                              arucikk.Arucikknev
                          })
                    .Select(result => new ProjektViewModel3
                    {
                        Sorrend = result.ArucikkID,
                        AlkatreszHely = result.helyszin.ToString(),
                        AlkatreszNev = result.Arucikknev.ToString(),
                    }).ToList();

                return arucikkek;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return new List<ProjektViewModel3>();
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
    public class ProjektViewModel2
    {
        public int ProjektID { get; set; }
        public string VarhatoIdo { get; set; }
        public string Ar { get; set; }
        public string Helyszin { get; set; }
        public string Leiras { get; set; }
        public string Statusz { get; set; }
    }
    public class ProjektViewModel3
    {
        public int Sorrend { get; set; }
        public string AlkatreszHely { get; set; }
        public string AlkatreszNev { get; set; }
    }
}
