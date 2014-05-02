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
    public partial class Catalog : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public Catalog()
        {
            InitializeComponent();
        }
        
        private void Catalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.Materials' table. You can move, or remove it, as needed.
            //this.materialsTableAdapter.Fill(this.insaatDataSet.Materials);
            refreshMaterials();
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

        private void malzemeBölümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var materialAdd = new SectionForm();
            materialAdd.materialsSectionsDataGridView.DataSource = databaseOperations.SelectSectionsMaterials();
            materialAdd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addGoodsForm = new AddGoods(this.materialsDataGridView.CurrentRow);
            addGoodsForm.ShowDialog();
            refreshMaterials();
        }

        private void materialsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var addGoodsForm = new AddGoods(this.materialsDataGridView.CurrentRow);
            addGoodsForm.Text = "Malzeme düzenleme";
            addGoodsForm.label1.Text = "Malzeme düzenleme";
            addGoodsForm.addMaterialbutton1.Text = "Düzenle";
            addGoodsForm.materialNameRichTextBox1.Text = this.materialsDataGridView.CurrentRow.Cells[1].Value.ToString();
            addGoodsForm.unitTextBox1.Text = this.materialsDataGridView.CurrentRow.Cells[2].Value.ToString();
            addGoodsForm.priceTextBox1.Text = this.materialsDataGridView.CurrentRow.Cells[3].Value.ToString();

            addGoodsForm.ShowDialog();
            refreshMaterials();

        }
     }
}
