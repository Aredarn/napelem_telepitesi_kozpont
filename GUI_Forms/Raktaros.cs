using Microsoft.EntityFrameworkCore;
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

        private void projektIDAlkatreszComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListProjectComponents(int.Parse(projektIDAlkatreszComboBox.Text));
        }

        private void ListProjectComponents(int projectID)
        {
            projektAlkatreszListView.Items.Clear();

            using (var dbContext = new NapelemDbContext())
            {
                var alkatreszek = dbContext.ProjektekArucikkhez
                    .Where(pa => pa.ProjectID == projectID)
                    .Join(dbContext.Arucikk,
                        pa => pa.ArucikkID,
                        a => a.ArucikkID,
                        (pa, a) => new
                        {
                            ArucikkID = pa.ArucikkID,
                            Arucikknev = a.Arucikknev,
                            Quantity = pa.Quantity
                        })
                    .ToList();

                foreach (var component in alkatreszek)
                {
                    var shelf = dbContext.Polc.FirstOrDefault(p => p.ArucikkID == component.ArucikkID);

                    var listViewItem = new ListViewItem(component.ArucikkID.ToString());
                    listViewItem.SubItems.Add(component.Arucikknev ?? "");
                    listViewItem.SubItems.Add(component.Quantity.ToString());
                    listViewItem.SubItems.Add(shelf != null ? shelf.Row.ToString() : "");
                    listViewItem.SubItems.Add(shelf != null ? shelf.Column.ToString() : "");
                    listViewItem.SubItems.Add(shelf != null ? shelf.Level.ToString() : "");

                    projektAlkatreszListView.Items.Add(listViewItem);
                }
            }
        }


        private void projektAlkatreszPanel_VisibleChanged(object sender, EventArgs e)
        {
            projektIDAlkatreszComboBox.Items.Clear();

            using (var dbContext = new NapelemDbContext())
            {
                var projektek = dbContext.Projekt.ToList();

                foreach (var projekt in projektek)
                {
                    var existingStatus = dbContext.projectStatuszok.Any(p => p.ProjectID == projekt.ProjectID && (p.StatusID == 6 || p.StatusID == 7));
                    if (!existingStatus)
                    {
                        projektIDAlkatreszComboBox.Items.Add(projekt.ProjectID);
                    }
                }
            }
        }

    }
}
