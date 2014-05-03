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
    public partial class AddWorkSection : Form
    {
        private readonly DataGridViewRow _currentRow;
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public AddWorkSection(DataGridViewRow currentRow)
        {
            _currentRow = currentRow;
            InitializeComponent();
        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            if (addSectionRichTextBox1.Text != "")
            {
                if (addSectionButton.Text == "Ekle")
                {
                    WorksSections worksSections = new WorksSections();
                    worksSections.SectionName = addSectionRichTextBox1.Text;
                    databaseOperations.InsertSectionsWorks(worksSections);
                    MessageBox.Show("Bölüm eklendi", "Bölüm");
                    this.Close();
                }
                else
                {
                    WorksSections worksSections = new WorksSections();
                    worksSections.Id = int.Parse(_currentRow.Cells[0].Value.ToString());
                    worksSections.SectionName = addSectionRichTextBox1.Text;
                    databaseOperations.UpdateWorksSections(worksSections);
                    MessageBox.Show("İşler bölümü düzenlendi", "İşler");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("İşin bölümün yazınız", "İş");
            }
        }
    }
}
