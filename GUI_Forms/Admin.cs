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
    public partial class Admin : Form
    {
        private int userID;
        public Admin(int userID)
        {
            InitializeComponent();

            this.userID = userID;
        }
        //vissza a Login felületre
        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();

            l1.Show();
            this.Hide();
        }
    }
}
