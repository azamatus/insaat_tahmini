namespace insaat
{
    partial class SectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionForm));
            this.insaatDataSet = new insaat.insaatDataSet();
            this.materialsSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsSectionsTableAdapter = new insaat.insaatDataSetTableAdapters.MaterialsSectionsTableAdapter();
            this.tableAdapterManager = new insaat.insaatDataSetTableAdapters.TableAdapterManager();
            this.materialsSectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.deleteSectionButton = new System.Windows.Forms.Button();
            this.editSectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insaatDataSet
            // 
            this.insaatDataSet.DataSetName = "insaatDataSet";
            this.insaatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsSectionsBindingSource
            // 
            this.materialsSectionsBindingSource.DataMember = "MaterialsSections";
            this.materialsSectionsBindingSource.DataSource = this.insaatDataSet;
            // 
            // materialsSectionsTableAdapter
            // 
            this.materialsSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EstimatesTableAdapter = null;
            this.tableAdapterManager.MaterialsSectionsTableAdapter = this.materialsSectionsTableAdapter;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = insaat.insaatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksSectionsTableAdapter = null;
            this.tableAdapterManager.WorksTableAdapter = null;
            // 
            // materialsSectionsDataGridView
            // 
            this.materialsSectionsDataGridView.AllowUserToAddRows = false;
            this.materialsSectionsDataGridView.AutoGenerateColumns = false;
            this.materialsSectionsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.materialsSectionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialsSectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsSectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.materialsSectionsDataGridView.DataSource = this.materialsSectionsBindingSource;
            this.materialsSectionsDataGridView.Location = new System.Drawing.Point(13, 55);
            this.materialsSectionsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.materialsSectionsDataGridView.Name = "materialsSectionsDataGridView";
            this.materialsSectionsDataGridView.ReadOnly = true;
            this.materialsSectionsDataGridView.Size = new System.Drawing.Size(464, 258);
            this.materialsSectionsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sectionName";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Bölüm adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(13, 13);
            this.addSectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(100, 34);
            this.addSectionButton.TabIndex = 2;
            this.addSectionButton.Text = "Ekle";
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.addSectionButton_Click);
            // 
            // deleteSectionButton
            // 
            this.deleteSectionButton.Location = new System.Drawing.Point(264, 13);
            this.deleteSectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSectionButton.Name = "deleteSectionButton";
            this.deleteSectionButton.Size = new System.Drawing.Size(100, 34);
            this.deleteSectionButton.TabIndex = 3;
            this.deleteSectionButton.Text = "Sil";
            this.deleteSectionButton.UseVisualStyleBackColor = true;
            this.deleteSectionButton.Click += new System.EventHandler(this.deleteSectionButton_Click);
            // 
            // editSectionButton
            // 
            this.editSectionButton.Location = new System.Drawing.Point(139, 13);
            this.editSectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.editSectionButton.Name = "editSectionButton";
            this.editSectionButton.Size = new System.Drawing.Size(100, 34);
            this.editSectionButton.TabIndex = 4;
            this.editSectionButton.Text = "Düzenle";
            this.editSectionButton.UseVisualStyleBackColor = true;
            this.editSectionButton.Click += new System.EventHandler(this.editSectionButton_Click);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 343);
            this.Controls.Add(this.editSectionButton);
            this.Controls.Add(this.deleteSectionButton);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.materialsSectionsDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Malzeme";
            this.Load += new System.EventHandler(this.AddSectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource materialsSectionsBindingSource;
        private insaatDataSetTableAdapters.MaterialsSectionsTableAdapter materialsSectionsTableAdapter;
        private insaatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button addSectionButton;
        private System.Windows.Forms.Button deleteSectionButton;
        private System.Windows.Forms.Button editSectionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridView materialsSectionsDataGridView;
    }
}