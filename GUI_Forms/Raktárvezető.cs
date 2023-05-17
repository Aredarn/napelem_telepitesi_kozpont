using Microsoft.EntityFrameworkCore;
using napelem_telepito_kozpont.Backend.Controllers;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
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
        private int userID;
        public Raktárvezető(int userID)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //almenu_cim.Visible= false;
            hozzaadPanel.Visible = false;
            arModositasButton.Visible = false;
            arucikkekCombobox.Visible = false;
            raktarHozzaadPanel.Visible = false;
            this.userID = userID;
            rekeszPanel.Visible = false;
            hianyzoAlkatreszekPanel.Visible = false;
            hianyzoLefoglaltPanel.Visible = false;  
        }

        public void mindLathatatlan() {
            rekeszPanel.Visible = false;
            raktarHozzaadPanel.Visible = false;
            hozzaadPanel.Visible = false;
            hianyzoAlkatreszekPanel.Visible = false;
            hianyzoLefoglaltPanel.Visible = false; 
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
            rekeszPanel.Visible = false;

            hianyzoAlkatreszekPanel.Visible=false;
            hianyzoLefoglaltPanel.Visible=false;

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
            hozzaadPanel.Visible = false;
            hozzaadPanel.Visible = true;
            almenu_cim.Text = "Alkatrész árának módosítása:";
            rekeszenkentiMax.Visible = false;
            rekeszMaxLabel.Visible = false;
            hozzaadasButton.Visible = false;
            arModositasButton.Visible = true;
            arucikkekCombobox.Visible = true;
            ujNev.Visible = false;
            raktarHozzaadPanel.Visible = false;
            rekeszPanel.Visible = false;   

            

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
            rekeszPanel.Visible = false;
            mindLathatatlan();
            raktarHozzaadPanel.Visible = true;

            hozzaadPanel.Visible = false;

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
                   alkalmazni lehessen az `Add()` metódust, hogy új rekordot
                   hozhassunk létre a Polc táblában. */
                ArucikkController arucikkController = new();

                /* Változók deklarálása, valamint inicializálása az input
                   mezőkben megadott értékekkel. */
                string nev = beerkezettAlkComboBox.Text;
                string mennyiseg = mennyisegTextBox.Text;
                int row = Convert.ToInt32(Math.Round(rowNumber.Value, 0));
                int col = Convert.ToInt32(Math.Round(columnNumber.Value, 0));
                int level = Convert.ToInt32(Math.Round(levelNumber.Value, 0));

                /* Alapvető validáció, hogy elkerüljük az üres mezők
                   megadását. */

                if (mennyiseg == "")
                {
                    throw new Exception("Mennyiség nem lehet üres!");
                }

                // a polc megadasanal csak 1 es 5 kozotti erteket lehet megadni, ugyhogy 
                // azt mar nem kell tovabb ellenorizni

                /*  Meg kell keresni azt az arucikket amibol eppen a raktarba erkezett */

                List<Arucikk> arucikkek = arucikkController.GetItems();


                Arucikk result = arucikkek.Find(x => x.Arucikknev == nev);


                if (result == null)
                {
                    throw new Exception("Nincs még ilyen fajta alkatrész a rendszerben, először add hozzá a 'hozzáadás' lapfülnél!");
                }

                /* Új polc objektum létrehozása */

                Polc polc = new Polc
                {
                    Column = col,
                    Row = row,
                    Level = level,
                    ItemsInShelf = Int32.Parse(mennyiseg),
                    ArucikkID = result.ArucikkID
                };

                /* Mentsük el egy logikai változóba, hogy a hozzáadás sikeres volt-e,
                   vagy sem. */
                bool siker = arucikkController.Add(polc);

                /* Az alapján, hogy az `Add()` metódus milyen logikai értékkel tért
                   vissza, értesítjük a felhasználót. */
                if (!siker)
                {
                    throw new Exception("Alkatrész felvétele a raktárba sikertelen!");
                }

                //MessageBox.Show("Alkatrész felvétele a raktárba sikeresen megtörtént!");
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

        private void Raktárvezető_Load(object sender, EventArgs e)
        {
            using (var context = new NapelemDbContext())
            {
                List<Polc> polcs = context.Polc.ToList();
                rekeszekDataGridView.DataSource = polcs;
            }
        }

        private void tarolasMenu_Click(object sender, EventArgs e)
        {
            raktarHozzaadPanel.Visible= false;
            hozzaadPanel.Visible= false;

            rekeszPanel.Visible = true;

            //hozzaadPanel.Visible= false;    
        }

        private void rekeszekDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                rekeszekDataGridView.Visible = true;
                if (e.RowIndex >= 0 && e.ColumnIndex == rekeszekDataGridView.Columns["ItemsInShelf"].Index)
                {
                    var polc = rekeszekDataGridView.Rows[e.RowIndex].DataBoundItem as Polc;
                    if (polc != null)
                    {
                        polc.ItemsInShelf = Convert.ToInt32(rekeszekDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        using (var context = new NapelemDbContext())
                        {
                            context.Entry(polc).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                    }
                }
            
        }

        private void hianyzikMenu_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            hianyzoAlkatreszekPanel.Visible = true;

            hianyzoListView.Items.Clear();

            ArucikkController arucikkController = new();            
           
            foreach (var item in arucikkController.GetMissingReservedItems())
            {
                var uj = new ListViewItem();
                uj.Text = item.Key;
                uj.SubItems.Add(item.Value.ToString());

                hianyzoListView.Items.Add(uj);
            }
        }

        private void hiányzóLefoglaltAlkatrészekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            hianyzoLefoglaltPanel.Visible = true;

            hianyzoLefoglaltListView.Items.Clear();

            ArucikkController arucikkController = new();

            foreach (var item in arucikkController.GetMissingItems())
            {
                var uj = new ListViewItem();
                uj.Text = item.AruNev;
                uj.SubItems.Add(item.Mennyiseg.ToString());

                hianyzoLefoglaltListView.Items.Add(uj);
            }
        }
    }
}
