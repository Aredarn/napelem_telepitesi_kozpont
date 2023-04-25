using napelem_telepito_kozpont.Backend.Controllers;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace napelem_telepito_kozpont.GUI_Forms
{
    public partial class Raktárvezető : Form
    {
        public Raktárvezető()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //almenu_cim.Visible= false;
            hozzaadPanel.Visible = false;
            arModositasButton.Visible = false;
            arucikkekCombobox.Visible = false;
            raktarHozzaadPanel.Visible = false;
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
            ujNev.Visible = true;
            rekeszMaxLabel.Visible = true;
            rekeszenkentiMax.Visible = true;
            hozzaadasButton.Visible = true;
            arModositasButton.Visible = false;
            arucikkekCombobox.Visible = false;
            raktarHozzaadPanel.Visible = false;

            ujNev.Text = "";
            ujAr.Text = "";
            rekeszenkentiMax.Text = "1";
        }

        private void hozzaadasButton_Click(object sender, EventArgs e)
        {
            try
            {
                /* Az `ArucikkController` objektum létrehozása, hogy
                   alkalmazni lehessen az `Add()` metódust, hogy új árucikket
                   hozhassunk létre. */
                ArucikkController arucikkController = new();

                /* Változók deklarálása, valamint inicializálása az input
                   mezőkben megadott értékekkel. */
                string nev = ujNev.Text;
                string ar = ujAr.Text;
                string max = rekeszenkentiMax.Text;

                /* Alapvető validáció, hogy elkerüljük az üres mezők
                   megadását. */
                if (nev == "")
                {
                    throw new Exception("Név nem lehet üres!");
                }
                else if (ar == "")
                {
                    throw new Exception("Ár nem lehet üres!");
                }
                else if (max == "")
                {
                    throw new Exception("Rekeszenkénti maximum nem lehet üres!");
                }

                /* Egy `Arucikk` megalkotása, mivel a következő `Add()` metódus
                   paraméterben egy `Arucikk` objektumot vár. */
                Arucikk arucikk = new Arucikk
                {
                    Arucikknev = nev,
                    Price = Int32.Parse(ar),
                    MaxOnShelf = Int32.Parse(max)
                };

                /* Mentsük el egy logikai változóba, hogy a hozzáadás sikeres volt-e,
                   vagy sem. */
                bool siker = arucikkController.Add(arucikk);

                /* Az alapján, hogy az `Add()` metódus milyen logikai értékkel tért
                   vissza, értesítjük a felhasználót. */
                if (!siker)
                {
                    throw new Exception("Árucikk hozzáadása sikertelen!");
                }

                MessageBox.Show("Árucikk hozzáadása sikeresen megtörtént!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                ujNev.Text = "";
                ujAr.Text = "";
                rekeszenkentiMax.Text = "1";
            }
        }

        private void modositMenu_Click(object sender, EventArgs e)
        {
            hozzaadPanel.Visible = true;
            almenu_cim.Text = "Alkatrész árának módosítása:";
            rekeszenkentiMax.Visible = false;
            rekeszMaxLabel.Visible = false;
            hozzaadasButton.Visible = false;
            arModositasButton.Visible = true;
            arucikkekCombobox.Visible = true;
            ujNev.Visible = false;
            raktarHozzaadPanel.Visible = false;

            /* Lekéri az összes árucikket az adatbázisból.
               Majd ezután hozzáadja egyesével az összeset a
               ComboBox-hoz, és a megjelenített szöveg az
               árucikkek neve lesz. */
            arucikkekCombobox.Items.Clear();

            ArucikkController arucikkController = new();
            foreach (var item in arucikkController.GetItems())
            {
                arucikkekCombobox.Items.Add(item.Arucikknev);
            }

            arucikkekCombobox.Text = "";
            ujAr.Text = "";
        }

        private void arModositasButton_Click(object sender, EventArgs e)
        {
            try
            {
                SingelTableQueries singelTableQueries = new();

                string arucikkNev = arucikkekCombobox.Text;
                string ar = ujAr.Text;

                /* Alapvető validáció, hogy elkerüljük az üres mezők
                   megadását. */
                if (arucikkNev == "")
                {
                    throw new Exception("Név nem lehet üres!");
                }
                else if (ar == "")
                {
                    throw new Exception("Ár nem lehet üres!");
                }

                string eredmeny = singelTableQueries.ModifyItemPrice(arucikkNev, Int32.Parse(ar));

                MessageBox.Show(eredmeny);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"A módosítás sikertelen volt. ({exception.Message})");
            }
            finally
            {
                arucikkekCombobox.Text = "";
                ujAr.Text = "";
            }
        }

        private void arucikkekComboboxChanged(object sender, EventArgs e)
        {
            ArucikkController arucikkController = new();

            string arucikkNev = arucikkekCombobox.Text;

            int ar = arucikkController.GetPrizeFromName(arucikkNev);

            ujAr.Text = ar.ToString();
        }

        private void beerkezoMenu_Click(object sender, EventArgs e)
        {
            raktarHozzaadPanel.Visible = true;
            hozzaadPanel.Visible = false;
            arModositasButton.Visible = false;
            arucikkekCombobox.Visible = false;

            beerkezettAlkComboBox.Items.Clear();

            ArucikkController arucikkController = new();
            foreach (var item in arucikkController.GetItems())
            {
                beerkezettAlkComboBox.Items.Add(item.Arucikknev);
            }
        }

        private void raktarHozzaadButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                /* Az `ArucikkController` objektum létrehozása, hogy
                   alkalmazni lehessen az `Add()` metódust, hogy új árucikket
                   hozhassunk létre. */
                ArucikkController arucikkController = new();

                /* Változók deklarálása, valamint inicializálása az input
                   mezőkben megadott értékekkel. */
                string nev = beerkezettAlkComboBox.Text;
                string mennyiseg = mennyisegTextBox.Text;

                /* Alapvető validáció, hogy elkerüljük az üres mezők
                   megadását. */
                
                if (mennyiseg == "")
                {
                    throw new Exception("Mennyiség nem lehet üres!");
                }

                /* Egy `Arucikk` megalkotása, mivel a következő `Add()` metódus
                   paraméterben egy `Arucikk` objektumot vár. 
                Arucikk arucikk = new Arucikk
                {
                    Arucikknev = nev,
                    Price = Int32.Parse(ar),
                    MaxOnShelf = Int32.Parse(max)
                };  
                */
                
                Polc polc = new Polc
                {
                    ItemsInShelf = Int32.Parse(mennyiseg),
                    //ItemName = nev
                };  

                /* Mentsük el egy logikai változóba, hogy a hozzáadás sikeres volt-e,
                   vagy sem. */
                //bool siker = arucikkController.Add(polc);

                /* Az alapján, hogy az `Add()` metódus milyen logikai értékkel tért
                   vissza, értesítjük a felhasználót. 
                if (!siker)
                {
                    throw new Exception("Árucikk hozzáadása sikertelen!");
                }
                */
                MessageBox.Show("Árucikk hozzáadása sikeresen megtörtént!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                mennyisegTextBox.Text = "1";
            }
            
        }

        private void buttonLoginRaktarvezeto_Click_1(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();

            this.Hide();
        }
    }
}
