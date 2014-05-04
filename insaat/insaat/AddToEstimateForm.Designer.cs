namespace insaat
{
    partial class AddToEstimateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToEstimateForm));
            this.titleEstimateLabel1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.worksDataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.insaatDataSet = new insaat.insaatDataSet();
            this.worksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worksTableAdapter = new insaat.insaatDataSetTableAdapters.WorksTableAdapter();
            this.tableAdapterManager = new insaat.insaatDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.worksDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleEstimateLabel1
            // 
            this.titleEstimateLabel1.AutoSize = true;
            this.titleEstimateLabel1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleEstimateLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleEstimateLabel1.Location = new System.Drawing.Point(12, 18);
            this.titleEstimateLabel1.Name = "titleEstimateLabel1";
            this.titleEstimateLabel1.Size = new System.Drawing.Size(121, 33);
            this.titleEstimateLabel1.TabIndex = 0;
            this.titleEstimateLabel1.Text = "İşi seçiniz";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(92, 54);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(214, 27);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama";
            // 
            // worksDataGridView1
            // 
            this.worksDataGridView1.AllowUserToAddRows = false;
            this.worksDataGridView1.AllowUserToDeleteRows = false;
            this.worksDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.worksDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.worksDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worksDataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.worksDataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.worksDataGridView1.Location = new System.Drawing.Point(13, 88);
            this.worksDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.worksDataGridView1.Name = "worksDataGridView1";
            this.worksDataGridView1.ReadOnly = true;
            this.worksDataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worksDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.worksDataGridView1.ShowCellErrors = false;
            this.worksDataGridView1.ShowCellToolTips = false;
            this.worksDataGridView1.ShowEditingIcon = false;
            this.worksDataGridView1.ShowRowErrors = false;
            this.worksDataGridView1.Size = new System.Drawing.Size(959, 395);
            this.worksDataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seçme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(187, 502);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(0, 19);
            this.customerIdLabel.TabIndex = 5;
            this.customerIdLabel.Visible = false;
            // 
            // insaatDataSet
            // 
            this.insaatDataSet.DataSetName = "insaatDataSet";
            this.insaatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worksBindingSource
            // 
            this.worksBindingSource.DataMember = "Works";
            this.worksBindingSource.DataSource = this.insaatDataSet;
            // 
            // worksTableAdapter
            // 
            this.worksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EstimatesTableAdapter = null;
            this.tableAdapterManager.MaterialsSectionsTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = insaat.insaatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksSectionsTableAdapter = null;
            this.tableAdapterManager.WorksTableAdapter = this.worksTableAdapter;
            // 
            // AddToEstimateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 538);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.worksDataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.titleEstimateLabel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddToEstimateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keşifnameye ekleme";
            this.Load += new System.EventHandler(this.AddToEstimateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worksDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleEstimateLabel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView worksDataGridView1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label customerIdLabel;
        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource worksBindingSource;
        private insaatDataSetTableAdapters.WorksTableAdapter worksTableAdapter;
        private insaatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}