using System;
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

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.Estimates' table. You can move, or remove it, as needed.
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
            var smetaForm = new SmetaForm();
            smetaForm.customerOfEstimate = customersDataGridView.CurrentRow.Cells[2].Value.ToString();
            smetaForm.dateOfEstimate = customersDataGridView.CurrentRow.Cells[1].Value.ToString();
            smetaForm.objectOfEstimate = customersDataGridView.CurrentRow.Cells[3].Value.ToString();
            smetaForm.typeOfEstimate = customersDataGridView.CurrentRow.Cells[4].Value.ToString();
            smetaForm.contractorOfEstimate = customersDataGridView.CurrentRow.Cells[5].Value.ToString();
            int customer_id = (int) customersDataGridView.CurrentRow.Cells[0].Value;
            smetaForm.customerIdLabel.Text = customer_id.ToString();
            smetaForm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customer_id = 0;
            var dataGridViewRow = this.customersDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                customer_id = (int) dataGridViewRow.Cells[0].Value;
                switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "Müşteri silme", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        _databaseOperations.DeleteCustomer(customer_id);
                        refresh();
                        break;
                }
            }
            else MessageBox.Show("Müşteri yok!", "Müşteri silme");
        }

        private void veriTabanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog();
            catalogForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customer = new CustomerEdit(customersDataGridView.CurrentRow);
            if (customersDataGridView.CurrentRow != null)
            {
                customer.nameTextBox.Text = customersDataGridView.CurrentRow.Cells[2].Value.ToString();
                customer.objectTextBox.Text = customersDataGridView.CurrentRow.Cells[3].Value.ToString();
                customer.typeOfWorkTextBox.Text = customersDataGridView.CurrentRow.Cells[4].Value.ToString();
                customer.contractorTextBox.Text = customersDataGridView.CurrentRow.Cells[5].Value.ToString();
                customer.brigadeTextBox.Text = customersDataGridView.CurrentRow.Cells[6].Value.ToString();
                customer.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Müşteri yok!", "Müşteri düzenleme");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.ShowDialog();
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog();
            catalogForm.ShowDialog();
        }

        private void programHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
     }
}
