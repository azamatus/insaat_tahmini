using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace insaat
{
    public partial class SmetaForm : Form
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public SmetaForm()
        {
            InitializeComponent();
        }

        public string dateOfEstimate;
        public string customerOfEstimate;
        public string objectOfEstimate;
        public string typeOfEstimate;
        public string contractorOfEstimate;

        private void SmetaForm_Load(object sender, EventArgs e)
        {
            refreshEstimate();
            dataGridCorrection();
            multiply();
        }

        public void refreshEstimate()
        {
            int customer_id = Convert.ToInt32(customerIdLabel.Text);
            estimateDataGridView.DataSource = databaseOperations.SelectEstimateById(customer_id);
        }
        public void multiply()
        {
            double total = 0;
            for (int i = 0; i < estimateDataGridView.Rows.Count; i++)
            {
                total += double.Parse(estimateDataGridView.Rows[i].Cells[5].Value.ToString());
            }
            totalLabel.Text = total.ToString();
        }
        public void dataGridCorrection(){

            estimateDataGridView.Columns[0].Visible = false;
            estimateDataGridView.Columns[6].DisplayIndex = 1;
            estimateDataGridView.Columns[6].Width = 400;
            estimateDataGridView.Columns[6].HeaderText = "İsim";
            estimateDataGridView.Columns[1].HeaderText = "Ölç. bir.";
            estimateDataGridView.Columns[2].HeaderText = "Miktar";
            estimateDataGridView.Columns[3].HeaderText = "Fiyat";
            estimateDataGridView.Columns[4].Visible = false;
            estimateDataGridView.Columns[5].HeaderText = "Toplam";
            estimateDataGridView.Columns[5].DisplayIndex = 5;
        }
        
     private void button1_Click_1(object sender, EventArgs e)
        {
            var addWorkForm = new AddToEstimateForm();
            addWorkForm.customerIdLabel.Text = customerIdLabel.Text;
            addWorkForm.ShowDialog();
            refreshEstimate();
            dataGridCorrection();
            multiply();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addMaterials = new AddToEstimateMaterialsForm();
            addMaterials.customerIdLabel.Text = customerIdLabel.Text;
            addMaterials.ShowDialog();
            refreshEstimate();
            dataGridCorrection();
            multiply();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var editEstimate = new AddingToEstimateForm(this.estimateDataGridView.CurrentRow);
            editEstimate.Text = "Keşifname düzenleme";
            editEstimate.label4.Text = "Keşifname düzenleme";
            editEstimate.button1.Text = "Düzenle"; 
            var dataGridViewRow = this.estimateDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                editEstimate.nameRichTextBox.Text = estimateDataGridView.CurrentRow.Cells[6].Value.ToString();
                editEstimate.priceTextBox.Text = estimateDataGridView.CurrentRow.Cells[3].Value.ToString();
                editEstimate.unitLabel.Text = estimateDataGridView.CurrentRow.Cells[1].Value.ToString();
                editEstimate.customerIdLabel.Text = customerIdLabel.Text;
                editEstimate.ShowDialog();
                refreshEstimate();
                dataGridCorrection();
                multiply();
            }
            else
            {
                MessageBox.Show("İş yok veya iş seçiniz!", "İş düzenleme");
            }
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            Range excelCellrange;
            Excel.Application Excel = new Excel.Application();
            Excel.Application.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (Worksheet)Excel.ActiveSheet;

            int columnIndex = 1;
            for (int i = 0; i < estimateDataGridView.Columns.Count; i++)
            {
                if (estimateDataGridView.Columns[i].Visible)
                {
                    columnIndex++;
                }
            }

            excelCellrange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[estimateDataGridView.Rows.Count+2, columnIndex -1 ]];
            excelCellrange.EntireColumn.AutoFit();
            Borders borders = excelCellrange.Borders;
            borders.LineStyle = XlLineStyle.xlContinuous;
            borders.Weight = 2d;
            Excel.Visible = true;
            Excel.Rows[1].Font.Bold = true;
            worksheet.Cells[1, 1].Font.Size = 24;
            worksheet.Cells[1, 1] = "Keşifname";
            worksheet.Name = "Keşifname";
            Excel.Rows[2].Font.Bold = true;
            Excel.Rows[2].Font.Size = 14;
            Excel.Columns.ColumnWidth = 10;
            Excel.Columns[1].ColumnWidth = 60;
            Excel.Columns[2].ColumnWidth = 20;
            columnIndex = 1;
            for (int i = 0; i < estimateDataGridView.Columns.Count; i++)
            {
                if (estimateDataGridView.Columns[i].Visible)
                {
                    Excel.Cells[2, estimateDataGridView.Columns[i].DisplayIndex] = estimateDataGridView.Columns[i].HeaderText;
                    columnIndex++;
                }
            }
            int startRow = 3;
            int endRow = 0;
            for (int i = startRow; i <= estimateDataGridView.Rows.Count+2; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < estimateDataGridView.Columns.Count; j++)
                {
                    if (estimateDataGridView.Columns[j].Visible)
                    {
                        worksheet.Cells[i, estimateDataGridView.Columns[j].DisplayIndex] = estimateDataGridView.Rows[i - startRow].Cells[j].Value;
                        columnIndex++;
                        
                    }
                }
                endRow++;
            }
            Excel.Rows[endRow + 3].Font.Bold = true;
            Excel.Rows[endRow + 3].Font.Size = 14;
            Excel.Rows[endRow + 5].Font.Bold = true;
            Excel.Rows[endRow + 5].Font.Size = 14;
            Excel.Rows[endRow + 6].Font.Bold = true;
            Excel.Rows[endRow + 6].Font.Size = 14;
            Excel.Rows[endRow + 7].Font.Bold = true;
            Excel.Rows[endRow + 7].Font.Size = 14;
            Excel.Rows[endRow + 8].Font.Bold = true;
            Excel.Rows[endRow + 8].Font.Size = 14;
            Excel.Rows[endRow + 9].Font.Bold = true;
            Excel.Rows[endRow + 9].Font.Size = 14;
            worksheet.Cells[endRow + 3, 1] = "Genel toplam:";
            worksheet.Cells[endRow + 3, 5] = totalLabel.Text;
            worksheet.Cells[endRow + 5, 1] = "Müşteri:";
            worksheet.Cells[endRow + 5, 2] = customerOfEstimate;
            worksheet.Cells[endRow + 6, 1] = "İşin türü:";
            worksheet.Cells[endRow + 6, 2] = typeOfEstimate;
            worksheet.Cells[endRow + 7, 1] = "Nesne:";
            worksheet.Cells[endRow + 7, 2] = objectOfEstimate;
            worksheet.Cells[endRow + 8, 1] = "Mütteahit:";
            worksheet.Cells[endRow + 8, 2] = contractorOfEstimate;
            worksheet.Cells[endRow + 9, 4] = "Tarih: " + dateOfEstimate;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int estimate_id = 0;
            var dataGridViewRow = this.estimateDataGridView.CurrentRow;
            if (dataGridViewRow != null)
            {
                estimate_id = (int)dataGridViewRow.Cells[0].Value;
                switch (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "Silme", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        databaseOperations.DeleteEstimate(estimate_id);
                        refreshEstimate();
                        dataGridCorrection();
                        multiply();
                        break;
                }
            }
            else MessageBox.Show("Keşifnamede iş ve malzeme yok!", "Silme");
        }
        
    }

}
