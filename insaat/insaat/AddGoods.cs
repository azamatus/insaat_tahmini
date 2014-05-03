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
    public partial class AddGoods : Form
    {
        private readonly DataGridViewRow _currentRow;
        private DatabaseOperations databaseOperations = new DatabaseOperations();

        public AddGoods(DataGridViewRow currentRow)
        {
            _currentRow = currentRow;
            InitializeComponent();
        }

        private void addMaterialbutton1_Click(object sender, EventArgs e)
        {
            if (materialNameRichTextBox1.Text != "" && priceTextBox1.Text != "")
            {
                if (addMaterialbutton1.Text == "Ekle")
                {
                    Materials materials = new Materials();
                    materials.MaterialName = materialNameRichTextBox1.Text;
                    materials.Unit = unitTextBox1.Text;
                    materials.Price = Convert.ToDouble(priceTextBox1.Text);
                    MaterialsSections drv = (MaterialsSections)materialSectionsComboBox1.SelectedItem;
                    String valueOfItem = drv.Id.ToString();
                    materials.SectionId = Convert.ToInt32(valueOfItem);
                    databaseOperations.InsertMaterials(materials);
                    MessageBox.Show("Malzeme eklendi", "Malzeme");
                    this.Close();
                }
                else
                {
                    Materials materials = new Materials();
                    materials.Id = int.Parse(_currentRow.Cells[0].Value.ToString());
                    materials.MaterialName = materialNameRichTextBox1.Text;
                    materials.Unit = unitTextBox1.Text;
                    materials.Price = Convert.ToDouble(priceTextBox1.Text);
                    MaterialsSections drv = (MaterialsSections)materialSectionsComboBox1.SelectedItem;
                    String valueOfItem = drv.Id.ToString();
                    materials.SectionId = Convert.ToInt32(valueOfItem);
                    databaseOperations.UpdateMaterials(materials);
                    MessageBox.Show("Malzeme düzenlendi", "Malzeme");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Malzeme yazınız", "Malzeme");
            }
          
        }

        private void priceTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void AddGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.Materials' table. You can move, or remove it, as needed.
            refreshComboBox();
            this.materialsTableAdapter.Fill(this.insaatDataSet.Materials);
        }

        public void refreshComboBox()
        {
            this.materialSectionsComboBox1.DataSource = databaseOperations.SelectSectionsMaterials();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
