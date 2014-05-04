using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace insaat
{
    public partial class AddingToEstimateForm : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        private readonly DataGridViewRow _currentRow;
        public AddingToEstimateForm(DataGridViewRow currentRow)
        {
            _currentRow = currentRow;
            InitializeComponent();
        }

        private void AddingToEstimateForm_Load(object sender, EventArgs e)
        {
            nameRichTextBox.Enabled = false;
            priceTextBox.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                priceTextBox.Enabled = true;
            }
            else
            {
                priceTextBox.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text != "" && priceTextBox.Text != "")
            {
                double quantity;
                double price;
                quantity = Convert.ToDouble(quantityTextBox.Text);
                price = Convert.ToDouble(priceTextBox.Text);
                totalLabel.Text = (quantity * price).ToString();    
            }
         }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text != "" && priceTextBox.Text!="")
            {
                double quantity;
                double price;
                quantity = Convert.ToDouble(quantityTextBox.Text);
                price = Convert.ToDouble(priceTextBox.Text);
                totalLabel.Text = (quantity * price).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text != "")
            {
                if (button1.Text == "Ekle")
                {
                    Estimate estimate = new Estimate();
                    estimate.Denotation = nameRichTextBox.Text;
                    estimate.Unit = unitLabel.Text;
                    estimate.Quantity = Convert.ToDouble(quantityTextBox.Text);
                    estimate.Price = Convert.ToDouble(priceTextBox.Text);
                    estimate.Total = Convert.ToDouble(totalLabel.Text);
                    estimate.CustomerId = Convert.ToInt32(customerIdLabel.Text);
                    databaseOperations.InsertEstimate(estimate);
                    MessageBox.Show("İş eklendi", "Keşifnameye ekleme");
                    this.Close();
                }
                else
                {
                    Estimate estimate = new Estimate();
                    estimate.Id = int.Parse(_currentRow.Cells[0].Value.ToString());
                    estimate.Denotation = nameRichTextBox.Text;
                    estimate.Unit = unitLabel.Text;
                    estimate.Quantity = Convert.ToDouble(quantityTextBox.Text);
                    estimate.Price = Convert.ToDouble(priceTextBox.Text);
                    estimate.Total = Convert.ToDouble(totalLabel.Text);
                    databaseOperations.UpdateEstimate(estimate);
                    MessageBox.Show("Keşifname düzenlendi", "Keşifnameyi düzenleme");
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Miktarı yazınız", "Keşifname");
            }


        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (e.KeyChar == ',' && !quantityTextBox.Text.Contains(','))
            {
                return;
            }
            e.Handled = true;
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (e.KeyChar == ',' && !priceTextBox.Text.Contains(','))
            {
                return;
            }
            e.Handled = true;
        }

        


      }
}
