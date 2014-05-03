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
    public partial class AddWorks : Form
    {
        private readonly DataGridViewRow _currentRow;
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public AddWorks(DataGridViewRow currentRow)
        {
            _currentRow = currentRow;
            InitializeComponent();
        }

        private void AddWorks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insaatDataSet.WorksSections' table. You can move, or remove it, as needed.
            refreshComboBox();
            this.worksSectionsTableAdapter.Fill(this.insaatDataSet.WorksSections);
        }

        private void addWorkbutton1_Click(object sender, EventArgs e)
        {
            if (workNameRichTextBox1.Text != "" && priceTextBox1.Text != "")
            {
                if (addWorkbutton1.Text == "Ekle")
                {
                    Works works = new Works();
                    works.WorkName = workNameRichTextBox1.Text;
                    works.Unit = unitTextBox1.Text;
                    works.Price = Convert.ToDouble(priceTextBox1.Text);
                    WorksSections drv = (WorksSections)workSectionsComboBox1.SelectedItem;
                    String valueOfItem = drv.Id.ToString();
                    works.SectionId = Convert.ToInt32(valueOfItem);
                    databaseOperations.InsertWorks(works);
                    MessageBox.Show("İş eklendi", "İşler");
                    this.Close();
                }
                else
                {
                    Works works = new Works();
                    works.Id = int.Parse(_currentRow.Cells[0].Value.ToString());
                    works.WorkName = workNameRichTextBox1.Text;
                    works.Unit = unitTextBox1.Text;
                    works.Price = Convert.ToDouble(priceTextBox1.Text);
                    WorksSections drv = (WorksSections)workSectionsComboBox1.SelectedItem;
                    String valueOfItem = drv.Id.ToString();
                    works.SectionId = Convert.ToInt32(valueOfItem);
                    databaseOperations.UpdateWorks(works);
                    MessageBox.Show("İş düzenlendi", "İşler");
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("İş yazınız", "İş");
            }
        
        }
        
        private void priceTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public void refreshComboBox()
        {
            this.workSectionsComboBox1.DataSource = databaseOperations.SelectSectionsWorks();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
