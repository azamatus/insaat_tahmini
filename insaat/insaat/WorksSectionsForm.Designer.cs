namespace insaat
{
    partial class WorksSectionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksSectionsForm));
            this.editSectionButton = new System.Windows.Forms.Button();
            this.deleteSectionButton = new System.Windows.Forms.Button();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.worksSectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.insaatDataSet = new insaat.insaatDataSet();
            this.worksSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worksSectionsTableAdapter = new insaat.insaatDataSetTableAdapters.WorksSectionsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.worksSectionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksSectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editSectionButton
            // 
            this.editSectionButton.Location = new System.Drawing.Point(144, 21);
            this.editSectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.editSectionButton.Name = "editSectionButton";
            this.editSectionButton.Size = new System.Drawing.Size(100, 34);
            this.editSectionButton.TabIndex = 8;
            this.editSectionButton.Text = "Düzenle";
            this.editSectionButton.UseVisualStyleBackColor = true;
            this.editSectionButton.Click += new System.EventHandler(this.editSectionButton_Click);
            // 
            // deleteSectionButton
            // 
            this.deleteSectionButton.Location = new System.Drawing.Point(269, 21);
            this.deleteSectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSectionButton.Name = "deleteSectionButton";
            this.deleteSectionButton.Size = new System.Drawing.Size(100, 34);
            this.deleteSectionButton.TabIndex = 7;
            this.deleteSectionButton.Text = "Sil";
            this.deleteSectionButton.UseVisualStyleBackColor = true;
            this.deleteSectionButton.Click += new System.EventHandler(this.deleteSectionButton_Click);
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(18, 21);
            this.addSectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(100, 34);
            this.addSectionButton.TabIndex = 6;
            this.addSectionButton.Text = "Ekle";
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.addSectionButton_Click);
            // 
            // worksSectionsDataGridView
            // 
            this.worksSectionsDataGridView.AllowUserToAddRows = false;
            this.worksSectionsDataGridView.AutoGenerateColumns = false;
            this.worksSectionsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.worksSectionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.worksSectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worksSectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sectionNameDataGridViewTextBoxColumn});
            this.worksSectionsDataGridView.DataSource = this.worksSectionsBindingSource;
            this.worksSectionsDataGridView.Location = new System.Drawing.Point(18, 63);
            this.worksSectionsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.worksSectionsDataGridView.Name = "worksSectionsDataGridView";
            this.worksSectionsDataGridView.ReadOnly = true;
            this.worksSectionsDataGridView.Size = new System.Drawing.Size(464, 258);
            this.worksSectionsDataGridView.TabIndex = 5;
            // 
            // insaatDataSet
            // 
            this.insaatDataSet.DataSetName = "insaatDataSet";
            this.insaatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worksSectionsBindingSource
            // 
            this.worksSectionsBindingSource.DataMember = "WorksSections";
            this.worksSectionsBindingSource.DataSource = this.insaatDataSet;
            // 
            // worksSectionsTableAdapter
            // 
            this.worksSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionNameDataGridViewTextBoxColumn
            // 
            this.sectionNameDataGridViewTextBoxColumn.DataPropertyName = "sectionName";
            this.sectionNameDataGridViewTextBoxColumn.HeaderText = "Bölüm adı";
            this.sectionNameDataGridViewTextBoxColumn.Name = "sectionNameDataGridViewTextBoxColumn";
            this.sectionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionNameDataGridViewTextBoxColumn.Width = 400;
            // 
            // WorksSectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 343);
            this.Controls.Add(this.editSectionButton);
            this.Controls.Add(this.deleteSectionButton);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.worksSectionsDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorksSectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İşler bölümü";
            this.Load += new System.EventHandler(this.WorksSectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worksSectionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksSectionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editSectionButton;
        private System.Windows.Forms.Button deleteSectionButton;
        private System.Windows.Forms.Button addSectionButton;
        public System.Windows.Forms.DataGridView worksSectionsDataGridView;
        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource worksSectionsBindingSource;
        private insaatDataSetTableAdapters.WorksSectionsTableAdapter worksSectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameDataGridViewTextBoxColumn;
    }
}