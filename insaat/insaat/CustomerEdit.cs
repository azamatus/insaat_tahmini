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
    public partial class CustomerEdit : Form
    {
        private readonly DataGridViewRow _currentRow;
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public CustomerEdit(DataGridViewRow currentRow)
        {
            _currentRow = currentRow;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            newCustomer.Id = int.Parse(_currentRow.Cells[0].Value.ToString());
            newCustomer.Name = nameTextBox.Text;
            newCustomer.Nesne = objectTextBox.Text;
            newCustomer.TypeOfWork = typeOfWorkTextBox.Text;
            newCustomer.Contractor = contractorTextBox.Text;
            newCustomer.Brigade = brigadeTextBox.Text;
            newCustomer.Tarih = dateTimePicker1.Text;

            databaseOperations.UpdateCustomer(newCustomer);
            MessageBox.Show("Müşteri düzenlendi", "Müşteri");
            this.Close();
        }
    }
}
