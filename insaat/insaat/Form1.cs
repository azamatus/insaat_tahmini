﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insaat
{
    public partial class Form1 : Form
    {
        readonly DatabaseOperations _databaseOperations = new DatabaseOperations();
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniVeriTabanınıDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.ShowDialog();
            refresh();
        }
        private void refresh()
        {
            customersDataGridView.DataSource = _databaseOperations.fillDGV();
        }

        private void customersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var customer = new CustomerEdit(this.customersDataGridView.CurrentRow);
            customer.nameTextBox.Text = this.customersDataGridView.CurrentRow.Cells[1].Value.ToString();
            customer.objectTextBox.Text = this.customersDataGridView.CurrentRow.Cells[2].Value.ToString();
            customer.typeOfWorkTextBox.Text = this.customersDataGridView.CurrentRow.Cells[3].Value.ToString();
            customer.contractorTextBox.Text = this.customersDataGridView.CurrentRow.Cells[4].Value.ToString();
            customer.brigadeTextBox.Text = this.customersDataGridView.CurrentRow.Cells[5].Value.ToString();

            customer.ShowDialog();
            refresh();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customer_id;
            customer_id = (int)this.customersDataGridView.CurrentRow.Cells[0].Value;
            switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "Müşteri silme", MessageBoxButtons.YesNo))
            {
                 case DialogResult.Yes:
                    _databaseOperations.DeleteCustomer(customer_id);
                    refresh();
                    break;
            }
        }
    }
}
