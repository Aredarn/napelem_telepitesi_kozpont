using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI.Common;
using napelem_telepito_kozpont.Backend.Controllers;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace napelem_telepito_kozpont.GUI_Forms
{
    public partial class Szakember : Form
    {
        private int userID;

        public Szakember(int userID)
        {
            InitializeComponent();
            mindLathatatlan();

            this.userID = userID;
        }

        //vissza a login felületre
        private void buttonLoginSzakember_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();

            this.Hide();
        }

        private void projekthezRendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            alkHozzarendelPanel.Visible = true;
        }

        private void mindLathatatlan()
        {
            alkHozzarendelPanel.Visible = false;
            ujProjektPanel.Visible = false;
            projektListazasPanel.Visible = false;
            alkatreszekPanel.Visible = false;
            munkadijPanel.Visible = false;
            arkalkulacioPanel.Visible = false;
            projektLezarasaPanel.Visible = false;
        }

        private void hozzaadButton_Click(object sender, EventArgs e)
        {
            //hozzáadja a "kivalasztottAlkatreszekTextBox"-hoz 
            //"alkatreszComboBox"-ban kiválasztott alkatrészt a "darabszamComboBox"-ban kiválasztott darabszámban
            //bármilyen formában megjelenhet, megbeszélés alapján a projekthez hozzárendelés értékei 
            //nem a "kivalasztottAlkatreszekTextBox" alapján történik
            //az értékek egy map<Árucikk,darab> formátumú map-ben tárolódnak

            string alkatresz = alkatreszComboBox.Text;
            string darabszam = darabszamTextBox.Text;
            int darabszamInt = int.Parse(darabszam);

            ListViewItem lv = new ListViewItem(alkatresz);
            lv.SubItems.Add(darabszam);
            arucikkListView.Items.Add(lv);
        }

        private void hozzarendelButton_Click(object sender, EventArgs e)
        {
            //a megírt backend függvény segítségével UPDATE utastást hajt végre az adatbázison
            //a kijelölt map<Árucikk,Darab> értékeivel, a "projektIDTextBox"-ban megadott projekthez

            Dictionary<string, int> Arucikkek = new Dictionary<string, int>();

            foreach (ListViewItem item in arucikkListView.Items)
            {
                int darab = int.Parse(item.SubItems[1].Text);
                string Arucikknev = item.SubItems[0].Text;
                Arucikkek.Add(Arucikknev, darab);
            }
            string projektID = projektIDTextBox.Text;
            int projektIDint = int.Parse(projektID);

            SzakEmberController szakember = new SzakEmberController();
            szakember.AruCikkekBerendel(Arucikkek, projektIDint);

        }

        private void kivalasztottAlkatreszekTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void újProjektLétrehozásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            ujProjektPanel.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void projektekListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            projektListazasPanel.Visible = true;
            projektekListView.Items.Clear();
           
            
            ProjektController projektController = new();
            List<ProjektViewModel> projektLista = projektController.ProjektListaLekerese();

            foreach (var projekt in projektLista)
            {
                ListViewItem item = new ListViewItem();

                item.Text = projekt.ProjektID.ToString();
                item.SubItems.Add(projekt.Leiras);
                item.SubItems.Add(projekt.Helyszin);
                item.SubItems.Add(projekt.MegrendeloNev);
                item.SubItems.Add(projekt.MegrendeloCim);
                item.SubItems.Add(projekt.Statusz);

                projektekListView.Items.Add(item);
            }
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            DataTable table = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in props)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in props)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }

        private void alkatrészekListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            alkatreszekPanel.Visible = true;

            alkatreszekListView.Items.Clear();

            /*
            ProjektController projektController = new();
            List<ProjektViewModel> projektLista = projektController.ProjektListaLekerese();

            foreach (var projekt in projektLista)
            {
                ListViewItem item = new ListViewItem();

                item.Text = projekt.ProjektID.ToString();
                item.SubItems.Add(projekt.Leiras);
                item.SubItems.Add(projekt.Helyszin);
                item.SubItems.Add(projekt.MegrendeloNev);
                item.SubItems.Add(projekt.MegrendeloCim);
                item.SubItems.Add(projekt.Statusz);

                projektekListView.Items.Add(item);
            }
            */

            ArucikkController arucikkContoller = new();
            /*
            var result = db.pruchasemasters.GroupBy(o => o.membername)
                   .Select(g => new { membername = g.Key, total = g.Sum(i => i.cost) });

            foreach (var group in result)
            {
                Console.WriteLine("Membername = {0} Totalcost={1}", group.membername, group.total);
            } */
            
            List<AlkatreszViewModel> alkatreszLista = arucikkContoller.AlkatreszListaLekerese();
           // List<Arucikk> arucikkek = arucikkContoller.GetItems();


            foreach (var alk in alkatreszLista)
            {
                ListViewItem item = new ListViewItem();


                item.Text = alk.AlkatreszNev;
                item.SubItems.Add(alk.Ar.ToString());
                item.SubItems.Add(alk.Raktaron.ToString());
                
                alkatreszekListView.Items.Add(item);
                
            } 

        }

        private void munkadíjIdőtartamMeghatározásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            munkadijPanel.Visible = true;
        }

        private void szamitasButton_Click(object sender, EventArgs e)
        {
            try
            {
                string projektID = projektAzonositoTextBox.Text;
                int projektIDint = int.Parse(projektID);


                string munkaora = munkaoraTextBox.Text;
                int munkaoraID = int.Parse(munkaora);

                SzakEmberController x = new SzakEmberController();
                x.Arkalkulacio(projektIDint, munkaoraID);

                int munkadij = int.Parse(munkaora) * 15000;
                MessageBox.Show("Munkadíj meghatározva a(z) " + projektID + ". projekthez!\n" +
                    "Munkadíj összege: " + munkadij + " Ft");
            }
            catch(Exception x) {
                MessageBox.Show(x.Message);
            
            }
        
        
        }

        private void Szakember_Load(object sender, EventArgs e)
        {
            using (var context = new NapelemDbContext())
            {
                var arucikknevek = context.Arucikk.Select(a => a.Arucikknev).ToList();
                alkatreszComboBox.DataSource = arucikknevek;
            }
        }

        private void alkatreszComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            darabszamTextBox.Clear();
            string selectedArucikknev = alkatreszComboBox.SelectedItem.ToString();



            using (var context = new NapelemDbContext())
            {
                int arucikkID = context.Arucikk.Where(a => a.Arucikknev == selectedArucikknev).Select(a => a.ArucikkID).FirstOrDefault();

                int itemCount = context.Polc
                    .Where(p => arucikkID == p.ArucikkID)
                    .Sum(p => p.ItemsInShelf);

                darabszamTextBox.Text = itemCount.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /* Deklaráció */
                MegrendelokController megrendelokController = new();
                ProjektController projektController = new();

                string helyszin = textBox1.Text;
                string leiras = leirasTextBox.Text;

                string megrendeloNev = nevTextBox.Text;
                string megrendeloLakcim = lakcimTextBox.Text;
                string megrendeloTelefonszam = telefonszamTextBox.Text;
                string megrendeloEmail = emailTextBox.Text;

                /* Validáció */
                if (helyszin == "")
                {
                    throw new Exception("A helyszín nem lehet üres!");
                }
                else if (leiras == "")
                {
                    throw new Exception("A leírás nem lehet üres!");
                }
                else if (megrendeloNev == "")
                {
                    throw new Exception("A megrendelő név nem lehet üres!");
                }
                else if (megrendeloLakcim == "")
                {
                    throw new Exception("A megrendelő lakcim nem lehet üres!");
                }
                else if (megrendeloTelefonszam == "")
                {
                    throw new Exception("A megrendelő telefonszám nem lehet üres!");
                }
                else if (megrendeloEmail == "")
                {
                    throw new Exception("A megrendelő email nem lehet üres!");
                }

                /* Megrendelő objektum létrehozásas */
                Megrendelo megrendelo = new()
                {
                    Name = megrendeloNev,
                    Address = megrendeloLakcim,
                    phoneNum = megrendeloTelefonszam,
                    email = megrendeloEmail
                };

                /* Megrendelő hozzáadása az adatbázishoz */
                int megrendeloID = megrendelokController.MegrendeloHozzaadasa(megrendelo);

                /* Ha a megrendelő ID 0, akkor a megrendelőt nem sikerült létrehozni */
                if (megrendeloID == 0)
                {
                    throw new Exception("Megrendelő hozzáadása sikertelen!");
                }

                /* Projekt objektum létrehozásas */
                Projektek projekt = new()
                {
                    FelhasznaloID = userID,
                    ClientID = megrendeloID,
                    leiras = leiras,
                    helyszin = helyszin,
                    ApproxTimeToFinish = new DateTime(), // Hardcoded
                    ApproxCost = 0 // Hard coded
                };

                /* Projekt hozzáadása az adatbázishoz */
                int projektID = projektController.ProjektLetrehozasa(projekt);

                if (projektID == 0)
                {
                    throw new Exception("Projekt hozzáadása sikertelen!");
                }

                MessageBox.Show("Projekt sikeresen létrehozva!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void árkalkulációKészítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            arkalkulacioPanel.Visible = true;
        }

        private void arKalkulacioButton_Click(object sender, EventArgs e)
        {
            SzakEmberController A6 = new SzakEmberController();

            A6.TeljesArkalkulacio(int.Parse(comboBox1.Text));
        }

        private void projektLezárásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            projektLezarasaPanel.Visible = true;
        }

        private void lezarButton_Click(object sender, EventArgs e)
        {
            SzakEmberController A7 = new SzakEmberController();
            A7.Véglegesítés(lezarasComboBox.Text, int.Parse(projektLezarComboBox.Text));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemsFromTable();
        }

        private void LoadItemsFromTable()
        {
            // Törlés az előző elemekről a ListView-ben
            elemekListView.Items.Clear();

            // ComboBox kiválasztott elemének text értékének lekérése
            int selectedProjectID = int.Parse(comboBox1.Text);

            // Adatbázis kapcsolat inicializálása
            using (var dbContext = new NapelemDbContext())
            {
                // ProjektekArucikkhez elemek lekérdezése a megadott projektnév alapján
                var items = dbContext.ProjektekArucikkhez
                    .Where(p => p.ProjectID == selectedProjectID)
                    .ToList();

                // Elemek hozzáadása a ListView-hoz
                foreach (var item in items)
                {
                    // Azonosító alapján lekérdezzük a projektnév és ár adatokat
                    var project = dbContext.Projekt.FirstOrDefault(p => p.ProjectID == item.ProjectID);
                    var product = dbContext.Arucikk.FirstOrDefault(p => p.ArucikkID == item.ArucikkID);

                    if (project != null && product != null)
                    {
                        // ListView elem hozzáadása
                        var listViewItem = new ListViewItem(product.Arucikknev); // Az árucikk neve
                        listViewItem.SubItems.Add(product.Price.ToString()); // Az ár
                        elemekListView.Items.Add(listViewItem);

                    }
                }
            }
            if (comboBox1.SelectedItem != null)
            {
                int selectedProjectId = (int)comboBox1.SelectedItem;
                using (var dbContext = new NapelemDbContext())
                {
                    var selectedProject = dbContext.Projekt.FirstOrDefault(p => p.ProjectID == selectedProjectId);

                    if (selectedProject != null)
                    {
                        if (selectedProject.ApproxCost == 0)
                        {
                            munkadijListView.Items.Clear();
                            munkadijListView.Items.Add("Még nincs árkalkuláció");
                        }
                        else if (selectedProject.ApproxCost < 24)
                        {
                            int munkaora = selectedProject.ApproxCost * 15000;
                            munkadijListView.Items.Clear();
                            munkadijListView.Items.Add(new ListViewItem(new[] { "Munkaóra", munkaora.ToString() }));
                            munkadijListView.Items.Add(new ListViewItem(new[] { "ApproxCost", selectedProject.ApproxCost.ToString() }));
                        }
                        else
                        {
                            munkadijListView.Items.Clear();
                            munkadijListView.Items.Add("Már megtörtént az árkalkuláció");
                        }
                    }
                }
            }

        }

        private void arkalkulacioPanel_VisibleChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            using (var dbContext = new NapelemDbContext())
            {
                var projektek = dbContext.Projekt.ToList();

                foreach (var projekt in projektek)
                {
                    var existingStatus = dbContext.projectStatuszok.Any(p => p.ProjectID == projekt.ProjectID && (p.StatusID == 6 || p.StatusID == 7));
                    if (!existingStatus)
                    {
                        comboBox1.Items.Add(projekt.ProjectID);
                    }
                }
            }
        }


        private void projektLezarasaPanel_VisibleChanged(object sender, EventArgs e)
        {
            projektLezarComboBox.Items.Clear();

            using (var dbContext = new NapelemDbContext())
            {
                var projektek = dbContext.Projekt.ToList();

                foreach (var projekt in projektek)
                {
                    var existingStatus = dbContext.projectStatuszok.Any(p => p.ProjectID == projekt.ProjectID && (p.StatusID == 6 || p.StatusID == 7));
                    if (!existingStatus)
                    {
                        projektLezarComboBox.Items.Add(projekt.ProjectID);
                    }
                }
            }
        }
    }
}
