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
    public partial class SmetaForm : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public SmetaForm()
        {
            InitializeComponent();
        }

        private void SmetaForm_Load(object sender, EventArgs e)
        {
            dataGridCorrection();
            multiply();
        }

        public void refreshEstimate()
        {
            int customer_id = Convert.ToInt32(customerIdLabel.Text);
            estimateDataGridView.DataSource = databaseOperations.SelectEstimateById(customer_id);
        }
        public void multiply()
        {
            double total = 0;
            for (int i = 0; i < estimateDataGridView.Rows.Count; i++)
            {
                total += double.Parse(estimateDataGridView.Rows[i].Cells[5].Value.ToString());
            }
            totalLabel.Text = total.ToString();
        }
        public void dataGridCorrection(){

            estimateDataGridView.Columns[0].Visible = false;
            estimateDataGridView.Columns[6].DisplayIndex = 1;
            estimateDataGridView.Columns[6].Width = 400;
            estimateDataGridView.Columns[6].HeaderText = "İsim";
            estimateDataGridView.Columns[1].HeaderText = "Ölç. bir.";
            estimateDataGridView.Columns[2].HeaderText = "Miktar";
            estimateDataGridView.Columns[3].HeaderText = "Fiyat";
            estimateDataGridView.Columns[4].Visible = false;
            estimateDataGridView.Columns[5].HeaderText = "Toplam";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            for (int i = 0; i < estimateDataGridView.Rows.Count; i++)
            {
                Sum += int.Parse(estimateDataGridView.Rows[i].Cells[5].Value.ToString());
            }
            MessageBox.Show(Sum.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var addWorkForm = new AddToEstimateForm();
            addWorkForm.customerIdLabel.Text = customerIdLabel.Text;
            addWorkForm.ShowDialog();
            refreshEstimate();
            multiply();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addMaterials = new AddToEstimateMaterialsForm();
            addMaterials.customerIdLabel.Text = customerIdLabel.Text;
            addMaterials.ShowDialog();
            refreshEstimate();
            multiply();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var editEstimate = new AddingToEstimateForm(this.estimateDataGridView.CurrentRow);
            editEstimate.Text = "Keşifname düzenleme";
            editEstimate.label4.Text = "Keşifname düzenleme";
            editEstimate.button1.Text = "Düzenle"; 
            var dataGridViewRow = this.estimateDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                editEstimate.nameRichTextBox.Text = estimateDataGridView.CurrentRow.Cells[6].Value.ToString();
                editEstimate.priceTextBox.Text = estimateDataGridView.CurrentRow.Cells[3].Value.ToString();
                editEstimate.unitLabel.Text = estimateDataGridView.CurrentRow.Cells[1].Value.ToString();
                editEstimate.customerIdLabel.Text = customerIdLabel.Text;
                editEstimate.ShowDialog();
                refreshEstimate();
                multiply();
            }
            else
            {
                MessageBox.Show("İş yok veya iş seçiniz!", "İş düzenleme");
            }
        }

        
   }
}
