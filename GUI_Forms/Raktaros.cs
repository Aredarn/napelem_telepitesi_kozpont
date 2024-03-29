﻿using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;
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
using static napelem_telepito_kozpont.Backend.Controllers.ProjektController;
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

        public void mindLathatatlan()
        {
            projektListaPanel.Visible = false;
            projektAlkatreszPanel.Visible = false;
            utvonalPanel.Visible = false;
        }

        private void lista()
        {
            ProjektController projektController = new();
            List<ProjektViewModel2> projektek = projektController.ProjektLista2Lekerese();

            projektIDCombobox.Items.Clear();
            projektListaListView.Items.Clear();
            projektIDUtvonalComboBox.Items.Clear();

            foreach (var projekt in projektek)
            {
                var listViewItem = new ListViewItem(projekt.ProjektID.ToString());
                listViewItem.SubItems.Add(projekt.VarhatoIdo);
                listViewItem.SubItems.Add(projekt.Ar.ToString());
                listViewItem.SubItems.Add(projekt.Leiras.ToString());
                listViewItem.SubItems.Add(projekt.Helyszin.ToString());
                listViewItem.SubItems.Add(projekt.Statusz.ToString());

                projektListaListView.Items.Add(listViewItem);

                projektIDCombobox.Items.Add(projekt.ProjektID);

                projektIDUtvonalComboBox.Items.Add(projekt.ProjektID);
            }

            projektIDCombobox.SelectedIndex = 0;
            projektIDUtvonalComboBox.SelectedIndex = 0;
        }

        private void projektekListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mindLathatatlan();
            projektListaPanel.Visible = true;

            lista();
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

            lista();
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

        private void kivitelezesButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProjektController projektController = new();

                if (projektIDCombobox.SelectedIndex == -1)
                {
                    throw new Exception("Nincs kijelölve ID!");
                }

                string projectID = projektIDCombobox.SelectedItem.ToString() ?? "0";

                projektController.projektStatuszValtoztatasa(int.Parse(projectID), "InProgress");

                lista();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void projektIDUtvonalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProjektController projektController = new();

                if (projektIDUtvonalComboBox.SelectedIndex == -1)
                {
                    throw new Exception("Nincs kijelölve ID!");
                }

                string projectID = projektIDUtvonalComboBox.SelectedItem.ToString() ?? "0";

                List<ProjektViewModel3> helyszinek = projektController.helyszinekLista(int.Parse(projectID));

                utvonalListView.Items.Clear();

                foreach (var helyszin in helyszinek)
                {
                    var listViewItem = new ListViewItem(helyszin.Sorrend.ToString());
                    listViewItem.SubItems.Add(helyszin.AlkatreszHely);
                    listViewItem.SubItems.Add(helyszin.AlkatreszNev.ToString());

                    utvonalListView.Items.Add(listViewItem);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}