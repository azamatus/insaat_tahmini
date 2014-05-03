namespace insaat
{
    partial class AddGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoods));
            this.nameLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.materialNameRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialSectionsComboBox1 = new System.Windows.Forms.ComboBox();
            this.materialsSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insaatDataSet = new insaat.insaatDataSet();
            this.materialsSectionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.unitTextBox1 = new System.Windows.Forms.TextBox();
            this.priceTextBox1 = new System.Windows.Forms.TextBox();
            this.addMaterialbutton1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.materialsSectionsTableAdapter = new insaat.insaatDataSetTableAdapters.MaterialsSectionsTableAdapter();
            this.materialsSectionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new insaat.insaatDataSetTableAdapters.MaterialsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(18, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 26);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "İsim";
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sectionLabel.Location = new System.Drawing.Point(18, 156);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(67, 26);
            this.sectionLabel.TabIndex = 1;
            this.sectionLabel.Text = "Bölüm";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.Location = new System.Drawing.Point(18, 207);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(76, 26);
            this.unitLabel.TabIndex = 2;
            this.unitLabel.Text = "Ölç. bir.";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(18, 249);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(54, 26);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Fiyat";
            // 
            // materialNameRichTextBox1
            // 
            this.materialNameRichTextBox1.Location = new System.Drawing.Point(103, 70);
            this.materialNameRichTextBox1.Name = "materialNameRichTextBox1";
            this.materialNameRichTextBox1.Size = new System.Drawing.Size(318, 66);
            this.materialNameRichTextBox1.TabIndex = 4;
            this.materialNameRichTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kataloğa ekleme";
            // 
            // materialSectionsComboBox1
            // 
            this.materialSectionsComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialsSectionsBindingSource, "sectionName", true));
            this.materialSectionsComboBox1.DataSource = this.materialsSectionsBindingSource;
            this.materialSectionsComboBox1.DisplayMember = "sectionName";
            this.materialSectionsComboBox1.FormattingEnabled = true;
            this.materialSectionsComboBox1.Location = new System.Drawing.Point(103, 156);
            this.materialSectionsComboBox1.Name = "materialSectionsComboBox1";
            this.materialSectionsComboBox1.Size = new System.Drawing.Size(318, 27);
            this.materialSectionsComboBox1.TabIndex = 6;
            this.materialSectionsComboBox1.ValueMember = "id";
            // 
            // materialsSectionsBindingSource
            // 
            this.materialsSectionsBindingSource.DataMember = "MaterialsSections";
            this.materialsSectionsBindingSource.DataSource = this.insaatDataSet;
            // 
            // insaatDataSet
            // 
            this.insaatDataSet.DataSetName = "insaatDataSet";
            this.insaatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsSectionsBindingSource2
            // 
            this.materialsSectionsBindingSource2.DataMember = "MaterialsSections";
            this.materialsSectionsBindingSource2.DataSource = this.insaatDataSet;
            // 
            // unitTextBox1
            // 
            this.unitTextBox1.Location = new System.Drawing.Point(103, 206);
            this.unitTextBox1.Name = "unitTextBox1";
            this.unitTextBox1.Size = new System.Drawing.Size(318, 27);
            this.unitTextBox1.TabIndex = 7;
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.Location = new System.Drawing.Point(103, 248);
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(318, 27);
            this.priceTextBox1.TabIndex = 8;
            this.priceTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox1_KeyPress);
            // 
            // addMaterialbutton1
            // 
            this.addMaterialbutton1.Location = new System.Drawing.Point(29, 317);
            this.addMaterialbutton1.Name = "addMaterialbutton1";
            this.addMaterialbutton1.Size = new System.Drawing.Size(86, 39);
            this.addMaterialbutton1.TabIndex = 9;
            this.addMaterialbutton1.Text = "Ekle";
            this.addMaterialbutton1.UseVisualStyleBackColor = true;
            this.addMaterialbutton1.Click += new System.EventHandler(this.addMaterialbutton1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(167, 317);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 39);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // materialsSectionsTableAdapter
            // 
            this.materialsSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsSectionsBindingSource1
            // 
            this.materialsSectionsBindingSource1.DataMember = "MaterialsSections";
            this.materialsSectionsBindingSource1.DataSource = this.insaatDataSet;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.insaatDataSet;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // AddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 370);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addMaterialbutton1);
            this.Controls.Add(this.priceTextBox1);
            this.Controls.Add(this.unitTextBox1);
            this.Controls.Add(this.materialSectionsComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialNameRichTextBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Malzeme ekleme";
            this.Load += new System.EventHandler(this.AddGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsSectionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button cancelButton;
        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource materialsSectionsBindingSource;
        private insaatDataSetTableAdapters.MaterialsSectionsTableAdapter materialsSectionsTableAdapter;
        private System.Windows.Forms.BindingSource materialsSectionsBindingSource1;
        public System.Windows.Forms.RichTextBox materialNameRichTextBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox materialSectionsComboBox1;
        public System.Windows.Forms.TextBox unitTextBox1;
        public System.Windows.Forms.TextBox priceTextBox1;
        public System.Windows.Forms.Button addMaterialbutton1;
        private System.Windows.Forms.BindingSource materialsSectionsBindingSource2;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private insaatDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
    }
}