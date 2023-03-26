using napelem_telepito_kozpont.Backend.Modells_Tables;
using napelem_telepito_kozpont.Backend.Controllers;
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
        public Felhasznalo felhasznalo;

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


        /* `Belépés` gomb eventje: */
        private void buttonBelepes_Click(object sender, EventArgs e)
        {
            try
            {
                /* `FelhasznaloController` létrehozása, hogy később a `Login()`
                   metódusát használni lehessen. */
                FelhasznaloController felhasznaloController = new();

                /* A begépelt felhasználónév & jelszó értékek változóba
                   való mentése. */
                string felhasznalonev = textBoxFelhasznalonev.Text;
                string jelszo = textBoxJelszo.Text;

                /* Validáció annak érdekében, hogy a felhasználó értesítést
                   kapjon, ha bármelyik mező üresen maradt. */
                if (felhasznalonev == "")
                {
                    throw new Exception("Felhasználónév nem lehet üres!");
                }
                else if (jelszo == "")
                {
                    throw new Exception("Jelszó nem lehet üres!");
                }

                /* Megvizsgálásra kerül, hogy létezik-e felhasználó a korábban
                   mentett felhasználó, illetve jelszó értékekkel. */
                felhasznalo = felhasznaloController.Login(
                    felhasznalonev,
                    jelszo
                );

                /* A következő rész fog abban segíteni, hogy a megfelelő
                   `Role`-nak a megfelelő ablak nyíljon meg. */
                switch (felhasznalo.Role)
                {
                    case 4: // Admin
                        Admin admin = new Admin();
                        admin.Show();
                        break;

                    case 3: // Raktárvezető
                        Raktárvezető raktarvezeto = new Raktárvezető();
                        raktarvezeto.Show();
                        break;

                    case 2: // Raktáros
                        Raktaros raktaros = new Raktaros();
                        raktaros.Show();
                        break;

                    case 1: // Szakember
                        Szakember szakember = new Szakember();
                        szakember.Show();
                        break;

                    default:
                    case 0: // Helytelen `role`
                        throw new Exception("Felhasználónév vagy jelszó helytelen!");
                }

                /* Zárja be az aktuális ablakot! */
                this.Hide();
            }
            catch (Exception exception)
            {
                /* Bármilyen hiba, vagy kivétel esetén a felhasználó értesítve lesz! */
                MessageBox.Show($"Bejelentkezés sikertelen. ('{exception.Message}')");
            }
        }
    }
}
