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

        private void materialsSectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsSectionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.insaatDataSet);

        }

        private void AddSectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.MaterialsSections' table. You can move, or remove it, as needed.
            this.materialsSectionsTableAdapter.Fill(this.insaatDataSet.MaterialsSections);

        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            var addSection = new AddSectionForm(this.materialsSectionsDataGridView.CurrentRow);
            addSection.ShowDialog();
            refresh();
        }

        private void editSectionButton_Click(object sender, EventArgs e)
        {
            var editSection = new AddSectionForm(this.materialsSectionsDataGridView.CurrentRow);
            editSection.Text = "Düzenleme";
            editSection.label1.Text = "Düzenleme";
            editSection.addSectionButton.Text = "Düzenle";
            editSection.addSectionRichTextBox1.Text = this.materialsSectionsDataGridView.CurrentRow.Cells[1].Value.ToString();
            editSection.ShowDialog();
            refresh();
        }

        private void deleteSectionButton_Click(object sender, EventArgs e)
        {
            int materialsSectionsId = (int) this.materialsSectionsDataGridView.CurrentRow.Cells[0].Value;
            switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "Malzeme bölümün silme", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    databaseOperations.DeleteMaterialsSections(materialsSectionsId);
                    refresh();
                    break;
            }
        }
        public void refresh()
        {
            materialsSectionsDataGridView.DataSource = databaseOperations.SelectSectionsMaterials();
        }
    }
}
