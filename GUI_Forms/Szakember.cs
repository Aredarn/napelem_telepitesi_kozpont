﻿using System;
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
        }

        //vissza a login felületre
        private void buttonLoginSzakember_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();

            l1.Show();
            this.Hide();
        }
    }
}
