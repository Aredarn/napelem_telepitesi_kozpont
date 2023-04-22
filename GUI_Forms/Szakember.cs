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
            alkHozzarendelPanel.Visible = true;
        }

        private void mindLathatatlan() { 
            alkHozzarendelPanel.Visible= false;
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
    }
}
