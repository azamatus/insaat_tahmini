namespace insaat
{
    partial class AddingToEstimateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingToEstimateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Location = new System.Drawing.Point(138, 83);
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.Size = new System.Drawing.Size(309, 76);
            this.nameRichTextBox.TabIndex = 1;
            this.nameRichTextBox.Text = "";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(23, 177);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 23);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Miktar";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(138, 177);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(80, 27);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(138, 210);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(131, 27);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(27, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(155, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Keşifnameye ekleme";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.Location = new System.Drawing.Point(134, 251);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 19);
            this.totalLabel.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(275, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 23);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "değiştirme";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.Location = new System.Drawing.Point(224, 180);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(0, 19);
            this.unitLabel.TabIndex = 13;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(301, 27);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(0, 19);
            this.customerIdLabel.TabIndex = 14;
            this.customerIdLabel.Visible = false;
            // 
            // AddingToEstimateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 353);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameRichTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddingToEstimateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keşifnameye ekleme";
            this.Load += new System.EventHandler(this.AddingToEstimateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox nameRichTextBox;
        public System.Windows.Forms.Label quantityLabel;
        public System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label unitLabel;
        public System.Windows.Forms.Label customerIdLabel;

    }
}