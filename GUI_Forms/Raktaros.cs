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
    public partial class Raktaros : Form
    {
        private int userID;
        public Raktaros(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            mindLathatatlan();
        }

        private void buttonLoginRaktaros_Click(object sender, EventArgs e)
        {
           
            Login l1 = new Login();

            l1.Show();
            this.Hide();
        }

        public void mindLathatatlan() { 
            projektListaPanel.Visible= false;
            projektAlkatreszPanel.Visible= false;
            utvonalPanel.Visible= false;    
        }

        private void projektekListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            projektListaPanel.Visible= true;
        }

        private void projekthezTartozóAlkatrészekListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            projektAlkatreszPanel.Visible = true;
        }

        private void útvonalOptimalizálásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            utvonalPanel.Visible = true;
        }
    }
}
