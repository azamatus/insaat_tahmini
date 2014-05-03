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
    public partial class WorksSectionsForm : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public WorksSectionsForm()
        {
            InitializeComponent();
        }

        private void WorksSectionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.WorksSections' table. You can move, or remove it, as needed.
            this.worksSectionsTableAdapter.Fill(this.insaatDataSet.WorksSections);
        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            var addSection = new AddWorkSection(this.worksSectionsDataGridView.CurrentRow);
            addSection.ShowDialog();
            refreshWorksSections();
        }
        public void refreshWorksSections()
        {
            worksSectionsDataGridView.DataSource = databaseOperations.SelectSectionsWorks();
        }

        private void editSectionButton_Click(object sender, EventArgs e)
        {
            var workSectionEdit = new AddWorkSection(this.worksSectionsDataGridView.CurrentRow);
            workSectionEdit.Text = "Düzenleme";
            workSectionEdit.label1.Text = "Düzenleme";
            workSectionEdit.addSectionButton.Text = "Düzenle";
            var dataGridViewRow = this.worksSectionsDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                workSectionEdit.addSectionRichTextBox1.Text = dataGridViewRow.Cells[1].Value.ToString();
                workSectionEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bölüm yok!", "İşler bölümün düzenleme");
            }

            refreshWorksSections();
        }

        private void deleteSectionButton_Click(object sender, EventArgs e)
        {
            var dataGridViewRow = this.worksSectionsDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                int worksSectionsId = (int)dataGridViewRow.Cells[0].Value;
                switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "İşler bölümün silme", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        databaseOperations.DeleteWorkSection(worksSectionsId);
                        refreshWorksSections();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Bölüm yok!", "İşler bölümün silme");
            }
        }
    }
}
