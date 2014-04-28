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
    public partial class AddSectionForm : Form
    {
        private readonly DataGridViewRow _currentRow;
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public AddSectionForm(DataGridViewRow currentRow)
        {
            _currentRow = currentRow;
            InitializeComponent();
        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            if (addSectionButton.Text == "Ekle")
            {
                MaterialsSections materialsSections = new MaterialsSections();
                materialsSections.SectionName = addSectionRichTextBox1.Text;
                databaseOperations.InsertSectionsMaterials(materialsSections);
                MessageBox.Show("Bölüm eklendi", "Bölüm");
                this.Close();
            }
            else
            {
                MaterialsSections materialsSections = new MaterialsSections();
                materialsSections.Id = int.Parse(_currentRow.Cells[0].Value.ToString());
                materialsSections.SectionName = addSectionRichTextBox1.Text;
                databaseOperations.UpdateMaterialsSections(materialsSections);
                MessageBox.Show("Malzeme bölümü düzenlendi", "Malzeme");
                this.Close();
            }
        }
    }
}
