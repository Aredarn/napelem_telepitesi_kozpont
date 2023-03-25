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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxJelszo.Text = "";
            // The password character is an asterisk.
            textBoxJelszo.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBoxJelszo.MaxLength = 14;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        //kiválasztott érték (combobox) alapján navigálás
        private void buttonBelepes_Click(object sender, EventArgs e)
        {
            //combobox értéke stringé alakítás
            object b = comboBox1.SelectedItem;
            string be = Convert.ToString(b);
            if (be == "Szakember")
            {
                Szakember sz1 = new Szakember();
                
                sz1.Show();
                this.Hide();
            }
            if (be == "Raktáros")
            {
                Raktaros r1 = new Raktaros();

                r1.Show();
                this.Hide();
            }
            if (be == "Raktárvezető")
            {
                Raktárvezető rv1 = new Raktárvezető();

                rv1.Show();
                this.Hide();
            }
            if (be == "Admin")
            {
                Admin a1 = new Admin();

                a1.Show();
                this.Hide();
            }
        }
    }
}
