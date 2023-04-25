using napelem_telepito_kozpont.Backend.Controllers;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
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
        public Szakember()
        {
            InitializeComponent();
            mindLathatatlan();
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

        private void mindLathatatlan() { 
            alkHozzarendelPanel.Visible= false;
            ujProjektPanel.Visible = false;
            projektListazasPanel.Visible = false;
            alkatreszekPanel.Visible = false;
            munkadijPanel.Visible = false;
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
            /*
            Dictionary<int, string> Arucikkek = new Dictionary<int, string>();

            foreach (ListViewItem item in arucikkListView.Items)
            {
                int darab = int.Parse(item.SubItems[0].Text);
                string Arucikknev = item.SubItems[1].Text;
                Arucikkek.Add(darab, Arucikknev);
            }
            string projektID = projektIDTextBox.Text;
            int projektIDint = int.Parse(projektID);
            
            SzakEmberController szakember = new SzakEmberController();
            szakember.AruCikkekBerendel(Arucikkek,projektIDint);
            */
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
        }

        private void alkatrészekListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            alkatreszekPanel.Visible = true;
        }

        private void munkadíjIdőtartamMeghatározásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            munkadijPanel.Visible= true;
        }

        private void szamitasButton_Click(object sender, EventArgs e)
        {
            
            string projektID = projektAzonositoTextBox.Text;
            int.Parse(projektID);

            string munkaora = munkaoraTextBox.Text;
            

            int munkadij = int.Parse(munkaora) *15000;
            MessageBox.Show("Munkadíj meghatározva a(z) "+ projektID+ ". projekthez!\n" +
                "Munkadíj összege: " +munkadij+ " Ft");
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
                int itemCount = context.Polc
                    .Where(p => p.Arucikk.Arucikknev == selectedArucikknev)
                    .Sum(p => p.ItemsInShelf);

                darabszamTextBox.Text = itemCount.ToString();
            }
        }
    }
}
