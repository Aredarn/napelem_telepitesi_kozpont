using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void hozzarendelButton_Click(object sender, EventArgs e)
        {
            //a megírt backend függvény segítségével UPDATE utastást hajt végre az adatbázison
            //a kijelölt map<Árucikk,Darab> értékeivel, a "projektIDTextBox"-ban megadott projekthez
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
    }
}
