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
    public partial class Raktárvezető : Form
    {
        public Raktárvezető()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //almenu_cim.Visible= false;
            hozzaadPanel.Visible= false;
        }

        private void buttonLoginRaktarvezeto_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();

            l1.Show();
            this.Hide();
        }

        private void hozzaadMenu_Click(object sender, EventArgs e)
        {
            almenu_cim.Text = "Új alkatrész hozzáadása:";
            //almenu_cim.Visible = true;
            hozzaadPanel.Visible = true;
        }
    }
}
