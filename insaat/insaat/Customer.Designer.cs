namespace insaat
{
    partial class Customer
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label objectLabel;
            System.Windows.Forms.Label typeOfWorkLabel;
            System.Windows.Forms.Label contractorLabel;
            System.Windows.Forms.Label brigadeLabel;
            System.Windows.Forms.Label label_title;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insaatDataSet = new insaat.insaatDataSet();
            this.objectTextBox = new System.Windows.Forms.TextBox();
            this.typeOfWorkTextBox = new System.Windows.Forms.TextBox();
            this.contractorTextBox = new System.Windows.Forms.TextBox();
            this.brigadeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customersTableAdapter = new insaat.insaatDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new insaat.insaatDataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            nameLabel = new System.Windows.Forms.Label();
            objectLabel = new System.Windows.Forms.Label();
            typeOfWorkLabel = new System.Windows.Forms.Label();
            contractorLabel = new System.Windows.Forms.Label();
            brigadeLabel = new System.Windows.Forms.Label();
            label_title = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(11, 61);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(79, 23);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Müşteri:";
            // 
            // objectLabel
            // 
            objectLabel.AutoSize = true;
            objectLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            objectLabel.Location = new System.Drawing.Point(11, 94);
            objectLabel.Name = "objectLabel";
            objectLabel.Size = new System.Drawing.Size(66, 23);
            objectLabel.TabIndex = 5;
            objectLabel.Text = "Nesne:";
            // 
            // typeOfWorkLabel
            // 
            typeOfWorkLabel.AutoSize = true;
            typeOfWorkLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            typeOfWorkLabel.Location = new System.Drawing.Point(13, 127);
            typeOfWorkLabel.Name = "typeOfWorkLabel";
            typeOfWorkLabel.Size = new System.Drawing.Size(81, 23);
            typeOfWorkLabel.TabIndex = 7;
            typeOfWorkLabel.Text = "İşin türü:";
            // 
            // contractorLabel
            // 
            contractorLabel.AutoSize = true;
            contractorLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contractorLabel.Location = new System.Drawing.Point(13, 160);
            contractorLabel.Name = "contractorLabel";
            contractorLabel.Size = new System.Drawing.Size(100, 23);
            contractorLabel.TabIndex = 9;
            contractorLabel.Text = "Müteahhit:";
            // 
            // brigadeLabel
            // 
            brigadeLabel.AutoSize = true;
            brigadeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            brigadeLabel.Location = new System.Drawing.Point(13, 193);
            brigadeLabel.Name = "brigadeLabel";
            brigadeLabel.Size = new System.Drawing.Size(106, 23);
            brigadeLabel.TabIndex = 11;
            brigadeLabel.Text = "İnşaat ekibi:";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_title.Location = new System.Drawing.Point(12, 9);
            label_title.Name = "label_title";
            label_title.Size = new System.Drawing.Size(149, 26);
            label_title.TabIndex = 17;
            label_title.Text = "Müşteri ekleme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(13, 234);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 23);
            label1.TabIndex = 18;
            label1.Text = "Tarih";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(124, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(380, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.insaatDataSet;
            // 
            // insaatDataSet
            // 
            this.insaatDataSet.DataSetName = "insaatDataSet";
            this.insaatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectTextBox
            // 
            this.objectTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectTextBox.Location = new System.Drawing.Point(124, 94);
            this.objectTextBox.Name = "objectTextBox";
            this.objectTextBox.Size = new System.Drawing.Size(380, 27);
            this.objectTextBox.TabIndex = 6;
            // 
            // typeOfWorkTextBox
            // 
            this.typeOfWorkTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfWorkTextBox.Location = new System.Drawing.Point(124, 127);
            this.typeOfWorkTextBox.Name = "typeOfWorkTextBox";
            this.typeOfWorkTextBox.Size = new System.Drawing.Size(380, 27);
            this.typeOfWorkTextBox.TabIndex = 8;
            // 
            // contractorTextBox
            // 
            this.contractorTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorTextBox.Location = new System.Drawing.Point(124, 160);
            this.contractorTextBox.Name = "contractorTextBox";
            this.contractorTextBox.Size = new System.Drawing.Size(380, 27);
            this.contractorTextBox.TabIndex = 10;
            // 
            // brigadeTextBox
            // 
            this.brigadeTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brigadeTextBox.Location = new System.Drawing.Point(124, 193);
            this.brigadeTextBox.Name = "brigadeTextBox";
            this.brigadeTextBox.Size = new System.Drawing.Size(380, 27);
            this.brigadeTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(124, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.EstimatesTableAdapter = null;
            this.tableAdapterManager.MaterialsSectionsTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = insaat.insaatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksSectionsTableAdapter = null;
            this.tableAdapterManager.WorksTableAdapter = null;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(380, 27);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2014, 5, 3, 0, 0, 0, 0);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 371);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(label1);
            this.Controls.Add(label_title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(objectLabel);
            this.Controls.Add(this.objectTextBox);
            this.Controls.Add(typeOfWorkLabel);
            this.Controls.Add(this.typeOfWorkTextBox);
            this.Controls.Add(contractorLabel);
            this.Controls.Add(this.contractorTextBox);
            this.Controls.Add(brigadeLabel);
            this.Controls.Add(this.brigadeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private insaatDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private insaatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox objectTextBox;
        public System.Windows.Forms.TextBox typeOfWorkTextBox;
        public System.Windows.Forms.TextBox contractorTextBox;
        public System.Windows.Forms.TextBox brigadeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

    }
}