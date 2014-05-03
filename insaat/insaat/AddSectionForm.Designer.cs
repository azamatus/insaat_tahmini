namespace insaat
{
    partial class AddSectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSectionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.addSectionRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.insaatDataSet = new insaat.insaatDataSet();
            this.materialsSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsSectionsTableAdapter = new insaat.insaatDataSetTableAdapters.MaterialsSectionsTableAdapter();
            this.tableAdapterManager = new insaat.insaatDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekleme";
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(30, 146);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(82, 37);
            this.addSectionButton.TabIndex = 2;
            this.addSectionButton.Text = "Ekle";
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.addSectionButton_Click);
            // 
            // addSectionRichTextBox1
            // 
            this.addSectionRichTextBox1.Location = new System.Drawing.Point(30, 41);
            this.addSectionRichTextBox1.Name = "addSectionRichTextBox1";
            this.addSectionRichTextBox1.Size = new System.Drawing.Size(349, 99);
            this.addSectionRichTextBox1.TabIndex = 3;
            this.addSectionRichTextBox1.Text = "";
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
            this.tableAdapterManager.MaterialsSectionsTableAdapter = this.materialsSectionsTableAdapter;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = insaat.insaatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 189);
            this.Controls.Add(this.addSectionRichTextBox1);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button addSectionButton;
        public System.Windows.Forms.RichTextBox addSectionRichTextBox1;
        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource materialsSectionsBindingSource;
        private insaatDataSetTableAdapters.MaterialsSectionsTableAdapter materialsSectionsTableAdapter;
        private insaatDataSetTableAdapters.TableAdapterManager tableAdapterManager;

    }
}