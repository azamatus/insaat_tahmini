namespace insaat
{
    partial class AddWorkSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkSection));
            this.addSectionRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSectionRichTextBox1
            // 
            this.addSectionRichTextBox1.Location = new System.Drawing.Point(25, 39);
            this.addSectionRichTextBox1.Name = "addSectionRichTextBox1";
            this.addSectionRichTextBox1.Size = new System.Drawing.Size(349, 99);
            this.addSectionRichTextBox1.TabIndex = 6;
            this.addSectionRichTextBox1.Text = "";
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(25, 144);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(82, 37);
            this.addSectionButton.TabIndex = 5;
            this.addSectionButton.Text = "Ekle";
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.addSectionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ekleme";
            // 
            // AddWorkSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 189);
            this.Controls.Add(this.addSectionRichTextBox1);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddWorkSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İş ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox addSectionRichTextBox1;
        public System.Windows.Forms.Button addSectionButton;
        public System.Windows.Forms.Label label1;
    }
}