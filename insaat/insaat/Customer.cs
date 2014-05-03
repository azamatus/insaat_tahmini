using System;
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
    public partial class Customer : Form
    {
        readonly DatabaseOperations _databaseOperations = new DatabaseOperations();
        public Customer()
        {
            InitializeComponent();
        }

      

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.insaatDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Name = nameTextBox.Text;
            customer.Nesne = objectTextBox.Text;
            customer.TypeOfWork = typeOfWorkTextBox.Text;
            customer.Contractor = contractorTextBox.Text;
            customer.Brigade = brigadeTextBox.Text;
            customer.Tarih = dateTimePicker1.Text;
            
            _databaseOperations.Insert(customer);
            MessageBox.Show("Müşteri eklendi", "Müşteri");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
