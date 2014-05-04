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
    public partial class AddToEstimateMaterialsForm : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public AddToEstimateMaterialsForm()
        {
            InitializeComponent();
        }
        public void refreshMaterials()
        {
            materialsDataGridView.DataSource = databaseOperations.SelectMaterials();
            materialsDataGridView.Columns[0].Visible = false;
            materialsDataGridView.Columns[1].Width = 400;
            materialsDataGridView.Columns[1].HeaderText = "Malzeme ismi";
            materialsDataGridView.Columns[2].HeaderText = "Öl. bir.";
            materialsDataGridView.Columns[3].HeaderText = "Fiyatı";
            materialsDataGridView.Columns[4].HeaderText = "Bölüm";
            materialsDataGridView.Columns[4].Width = 350;
            materialsDataGridView.Columns[5].Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var addingForm = new AddingToEstimateMaterials();
            if (materialsDataGridView.CurrentRow != null)
            {
                addingForm.nameRichTextBox.Text = materialsDataGridView.CurrentRow.Cells[1].Value.ToString();
                addingForm.priceTextBox.Text = materialsDataGridView.CurrentRow.Cells[3].Value.ToString();
                addingForm.unitLabel.Text = materialsDataGridView.CurrentRow.Cells[2].Value.ToString();
                addingForm.customerIdLabel.Text = customerIdLabel.Text;
                addingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Malzeme seçiniz!");
            }
        }

        private void AddToEstimateMaterialsForm_Load(object sender, EventArgs e)
        {
            refreshMaterials();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var data = materialsTableAdapter.GetData();
            materialsDataGridView.DataSource = data.Select("MaterialName like '%" + searchTextBox.Text + "%'");
            materialsDataGridView.Columns[4].Visible = false;
            materialsDataGridView.Columns[5].Visible = false;
            materialsDataGridView.Columns[6].Visible = false;
            materialsDataGridView.Columns[7].Visible = false;
            materialsDataGridView.Columns[8].Visible = false;
            materialsDataGridView.Columns[9].Visible = false;
        }

    }
}
