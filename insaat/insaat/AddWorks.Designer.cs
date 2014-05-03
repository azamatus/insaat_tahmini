namespace insaat
{
    partial class AddWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorks));
            this.cancelButton = new System.Windows.Forms.Button();
            this.addWorkbutton1 = new System.Windows.Forms.Button();
            this.priceTextBox1 = new System.Windows.Forms.TextBox();
            this.unitTextBox1 = new System.Windows.Forms.TextBox();
            this.workSectionsComboBox1 = new System.Windows.Forms.ComboBox();
            this.worksSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insaatDataSet = new insaat.insaatDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.workNameRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.worksSectionsTableAdapter = new insaat.insaatDataSetTableAdapters.WorksSectionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.worksSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(175, 315);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 39);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addWorkbutton1
            // 
            this.addWorkbutton1.Location = new System.Drawing.Point(37, 315);
            this.addWorkbutton1.Name = "addWorkbutton1";
            this.addWorkbutton1.Size = new System.Drawing.Size(86, 39);
            this.addWorkbutton1.TabIndex = 20;
            this.addWorkbutton1.Text = "Ekle";
            this.addWorkbutton1.UseVisualStyleBackColor = true;
            this.addWorkbutton1.Click += new System.EventHandler(this.addWorkbutton1_Click);
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.Location = new System.Drawing.Point(111, 246);
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(318, 27);
            this.priceTextBox1.TabIndex = 19;
            this.priceTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox1_KeyPress);
            // 
            // unitTextBox1
            // 
            this.unitTextBox1.Location = new System.Drawing.Point(111, 204);
            this.unitTextBox1.Name = "unitTextBox1";
            this.unitTextBox1.Size = new System.Drawing.Size(318, 27);
            this.unitTextBox1.TabIndex = 18;
            // 
            // workSectionsComboBox1
            // 
            this.workSectionsComboBox1.DataSource = this.worksSectionsBindingSource;
            this.workSectionsComboBox1.DisplayMember = "sectionName";
            this.workSectionsComboBox1.FormattingEnabled = true;
            this.workSectionsComboBox1.Location = new System.Drawing.Point(111, 154);
            this.workSectionsComboBox1.Name = "workSectionsComboBox1";
            this.workSectionsComboBox1.Size = new System.Drawing.Size(318, 27);
            this.workSectionsComboBox1.TabIndex = 17;
            this.workSectionsComboBox1.ValueMember = "id";
            // 
            // worksSectionsBindingSource
            // 
            this.worksSectionsBindingSource.DataMember = "WorksSections";
            this.worksSectionsBindingSource.DataSource = this.insaatDataSet;
            // 
            // insaatDataSet
            // 
            this.insaatDataSet.DataSetName = "insaatDataSet";
            this.insaatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kataloğa ekleme";
            // 
            // workNameRichTextBox1
            // 
            this.workNameRichTextBox1.Location = new System.Drawing.Point(111, 68);
            this.workNameRichTextBox1.Name = "workNameRichTextBox1";
            this.workNameRichTextBox1.Size = new System.Drawing.Size(318, 66);
            this.workNameRichTextBox1.TabIndex = 15;
            this.workNameRichTextBox1.Text = "";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(26, 247);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(54, 26);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Fiyat";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.Location = new System.Drawing.Point(26, 205);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(76, 26);
            this.unitLabel.TabIndex = 13;
            this.unitLabel.Text = "Ölç. bir.";
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sectionLabel.Location = new System.Drawing.Point(26, 154);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(67, 26);
            this.sectionLabel.TabIndex = 12;
            this.sectionLabel.Text = "Bölüm";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(26, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 26);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "İsim";
            // 
            // worksSectionsTableAdapter
            // 
            this.worksSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // AddWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 370);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addWorkbutton1);
            this.Controls.Add(this.priceTextBox1);
            this.Controls.Add(this.unitTextBox1);
            this.Controls.Add(this.workSectionsComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workNameRichTextBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWorks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İş ekleme";
            this.Load += new System.EventHandler(this.AddWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worksSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button addWorkbutton1;
        public System.Windows.Forms.TextBox priceTextBox1;
        public System.Windows.Forms.TextBox unitTextBox1;
        public System.Windows.Forms.ComboBox workSectionsComboBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox workNameRichTextBox1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label nameLabel;
        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource worksSectionsBindingSource;
        private insaatDataSetTableAdapters.WorksSectionsTableAdapter worksSectionsTableAdapter;
    }
}