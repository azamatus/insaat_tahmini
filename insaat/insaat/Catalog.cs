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

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.insaatDataSet);

        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.insaatDataSet.Materials);
        }

        private void malzemeBölümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var materialAdd = new SectionForm();
            materialAdd.materialsSectionsDataGridView.DataSource = databaseOperations.SelectSectionsMaterials();
            materialAdd.ShowDialog();
            
        }
    }
}
