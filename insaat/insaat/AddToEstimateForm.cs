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
    public partial class AddToEstimateForm : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public AddToEstimateForm()
        {
            InitializeComponent();
        }

        private void AddToEstimateForm_Load(object sender, EventArgs e)
        {
            refreshWorks();
        }

        public void refreshWorks()
        {
            worksDataGridView1.DataSource = databaseOperations.SelectWorks();
            worksDataGridView1.Columns[0].Visible = false;
            worksDataGridView1.Columns[1].Width = 400;
            worksDataGridView1.Columns[1].HeaderText = "İşin ismi";
            worksDataGridView1.Columns[2].HeaderText = "Öl. bir.";
            worksDataGridView1.Columns[3].HeaderText = "Fiyatı";
            worksDataGridView1.Columns[4].HeaderText = "Bölüm";
            worksDataGridView1.Columns[4].Width = 350;
            worksDataGridView1.Columns[5].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addingForm = new AddingToEstimateForm(null);
            if (worksDataGridView1.CurrentRow != null)
            {
                addingForm.nameRichTextBox.Text = worksDataGridView1.CurrentRow.Cells[1].Value.ToString();
                addingForm.priceTextBox.Text = worksDataGridView1.CurrentRow.Cells[3].Value.ToString();
                addingForm.unitLabel.Text = worksDataGridView1.CurrentRow.Cells[2].Value.ToString();
                addingForm.customerIdLabel.Text = customerIdLabel.Text;
                addingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("İşi seçiniz!");
            }
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var data = worksTableAdapter.GetData();
            worksDataGridView1.DataSource = data.Select("WorkName like '%" + searchTextBox.Text + "%'");
            worksDataGridView1.Columns[4].Visible = false;
            worksDataGridView1.Columns[5].Visible = false;
            worksDataGridView1.Columns[6].Visible = false;
            worksDataGridView1.Columns[7].Visible = false;
            worksDataGridView1.Columns[8].Visible = false;
            worksDataGridView1.Columns[9].Visible = false;
        }
    }
}
