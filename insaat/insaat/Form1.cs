﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniVeriTabanınıDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.insaatDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.insaatDataSet.Customers);

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.ShowDialog();
        }
    }
}
