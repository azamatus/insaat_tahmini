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
    public partial class SectionForm : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public SectionForm()
        {
            InitializeComponent();
        }
        private void AddSectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.MaterialsSections' table. You can move, or remove it, as needed.
            this.materialsSectionsTableAdapter.Fill(this.insaatDataSet.MaterialsSections);

        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            var addSection = new AddSectionForm(null);
            addSection.ShowDialog();
            refreshMaterialsSections();
        }

        private void editSectionButton_Click(object sender, EventArgs e)
        {
            var editSection = new AddSectionForm(this.materialsSectionsDataGridView.CurrentRow);
            editSection.Text = "Düzenleme";
            editSection.label1.Text = "Düzenleme";
            editSection.addSectionButton.Text = "Düzenle";
            var dataGridViewRow = this.materialsSectionsDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                editSection.addSectionRichTextBox1.Text = dataGridViewRow.Cells[1].Value.ToString();
                editSection.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bölüm yok!", "Malzeme bölümün düzenleme");
            }

            refreshMaterialsSections();
        }

        private void deleteSectionButton_Click(object sender, EventArgs e)
        {
            var dataGridViewRow = this.materialsSectionsDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                int materialsSectionsId = (int) dataGridViewRow.Cells[0].Value;
                switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "Malzeme bölümün silme", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        databaseOperations.DeleteMaterialsSections(materialsSectionsId);
                        refreshMaterialsSections();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Bölüm yok!", "Malzeme bölümün silme");
            }
        }

        public void refreshMaterialsSections()
        {
            materialsSectionsDataGridView.DataSource = databaseOperations.SelectSectionsMaterials();
        }
    }
}
