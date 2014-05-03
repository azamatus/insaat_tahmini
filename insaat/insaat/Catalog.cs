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
            refreshWorks();
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

        private void malzemeBölümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var materialAdd = new SectionForm();
            materialAdd.materialsSectionsDataGridView.DataSource = databaseOperations.SelectSectionsMaterials();
            materialAdd.ShowDialog();
        }

        private void materialsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var addGoodsForm = new AddGoods(this.materialsDataGridView.CurrentRow);
            addGoodsForm.Text = "Malzeme düzenleme";
            addGoodsForm.label1.Text = "Malzeme düzenleme";
            addGoodsForm.addMaterialbutton1.Text = "Düzenle";
            addGoodsForm.materialNameRichTextBox1.Text = materialsDataGridView.CurrentRow.Cells[1].Value.ToString();
            addGoodsForm.unitTextBox1.Text = materialsDataGridView.CurrentRow.Cells[2].Value.ToString();
            addGoodsForm.priceTextBox1.Text = materialsDataGridView.CurrentRow.Cells[3].Value.ToString();
            addGoodsForm.ShowDialog();
            refreshMaterials();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addGoodsForm = new AddGoods(this.materialsDataGridView.CurrentRow);
            addGoodsForm.ShowDialog();
            refreshMaterials();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addGoodsForm = new AddGoods(this.materialsDataGridView.CurrentRow);
            addGoodsForm.Text = "Malzeme düzenleme";
            addGoodsForm.label1.Text = "Malzeme düzenleme";
            addGoodsForm.addMaterialbutton1.Text = "Düzenle";
            var dataGridViewRow = this.materialsDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                addGoodsForm.materialNameRichTextBox1.Text = dataGridViewRow.Cells[1].Value.ToString();
                addGoodsForm.unitTextBox1.Text = dataGridViewRow.Cells[2].Value.ToString();
                addGoodsForm.priceTextBox1.Text = dataGridViewRow.Cells[3].Value.ToString();
                addGoodsForm.ShowDialog();
                refreshMaterials();
            }
            else
            {
                MessageBox.Show("Malzeme yok veya malzeme seçiniz!", "Malzeme düzenleme");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int malzeme_id = 0;
            var dataGridViewRow = this.materialsDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                malzeme_id = (int)dataGridViewRow.Cells[0].Value;
                switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "Malzeme silme", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        databaseOperations.DeletaMaterial(malzeme_id);
                        refreshMaterials();
                        break;
                }
            }
            else MessageBox.Show("Malzeme yok veya malzeme seçiniz!", "Malzeme silme");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var addWorkForm = new AddWorks(null);
            addWorkForm.ShowDialog();
            refreshWorks();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            var addGoodsForm = new AddWorks(this.worksDataGridView1.CurrentRow);
            addGoodsForm.Text = "İş düzenleme";
            addGoodsForm.label1.Text = "İş düzenleme";
            addGoodsForm.addWorkbutton1.Text = "Düzenle";
            var dataGridViewRow = this.worksDataGridView1.CurrentRow;
            if (dataGridViewRow != null)
            {
                addGoodsForm.workNameRichTextBox1.Text = dataGridViewRow.Cells[1].Value.ToString();
                addGoodsForm.unitTextBox1.Text = dataGridViewRow.Cells[2].Value.ToString();
                addGoodsForm.priceTextBox1.Text = dataGridViewRow.Cells[3].Value.ToString();
                addGoodsForm.ShowDialog();
                refreshWorks();
            }
            else
            {
                MessageBox.Show("İş yok veya iş seçiniz!", "İş düzenleme");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int work_id = 0;
            var dataGridViewRow = this.worksDataGridView1.CurrentRow;
            if (dataGridViewRow != null)
            {
                work_id = (int) dataGridViewRow.Cells[0].Value;
                switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "İşi silme", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        databaseOperations.DeleteWork(work_id);
                        refreshWorks();
                        break;
                }
            }
            else MessageBox.Show("İş yok!", "İşi silme");
        }

        private void işlerBölümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var workSectionAdd = new WorksSectionsForm();
            workSectionAdd.worksSectionsDataGridView.DataSource = databaseOperations.SelectSectionsWorks();
            workSectionAdd.ShowDialog();
        }

        private void worksDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var addGoodsForm = new AddWorks(this.worksDataGridView1.CurrentRow);
            addGoodsForm.Text = "İş düzenleme";
            addGoodsForm.label1.Text = "İş düzenleme";
            addGoodsForm.addWorkbutton1.Text = "Düzenle";
            var dataGridViewRow = this.worksDataGridView1.CurrentRow;
            if (dataGridViewRow != null)
            {
                addGoodsForm.workNameRichTextBox1.Text = dataGridViewRow.Cells[1].Value.ToString();
                addGoodsForm.unitTextBox1.Text = dataGridViewRow.Cells[2].Value.ToString();
                addGoodsForm.priceTextBox1.Text = dataGridViewRow.Cells[3].Value.ToString();
                addGoodsForm.ShowDialog();
                refreshWorks();
            }
            else
            {
                MessageBox.Show("İş yok veya iş seçiniz!", "İş düzenleme");
            }
        }
     }
}
