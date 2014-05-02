namespace insaat
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insaatDataSet = new insaat.insaatDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialsTableAdapter = new insaat.insaatDataSetTableAdapters.MaterialsTableAdapter();
            this.tableAdapterManager = new insaat.insaatDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeBölümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlerBölümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialsSectionsTableAdapter = new insaat.insaatDataSetTableAdapters.MaterialsSectionsTableAdapter();
            this.addMaterial = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 94);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.materialsDataGridView);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1039, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Malzemeler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.AllowUserToAddRows = false;
            this.materialsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.materialsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.GridColor = System.Drawing.Color.DarkGray;
            this.materialsDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialsDataGridView.Location = new System.Drawing.Point(8, 9);
            this.materialsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.ReadOnly = true;
            this.materialsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialsDataGridView.Size = new System.Drawing.Size(1019, 412);
            this.materialsDataGridView.TabIndex = 0;
            this.materialsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialsDataGridView_CellDoubleClick);
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.insaatDataSet;
            // 
            // insaatDataSet
            // 
            this.insaatDataSet.DataSetName = "insaatDataSet";
            this.insaatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1309, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İşler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.MaterialsSectionsTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.UpdateOrder = insaat.insaatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1077, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malzemeBölümüToolStripMenuItem,
            this.işlerBölümüToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // malzemeBölümüToolStripMenuItem
            // 
            this.malzemeBölümüToolStripMenuItem.Name = "malzemeBölümüToolStripMenuItem";
            this.malzemeBölümüToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.malzemeBölümüToolStripMenuItem.Text = "Malzeme bölümü";
            this.malzemeBölümüToolStripMenuItem.Click += new System.EventHandler(this.malzemeBölümüToolStripMenuItem_Click);
            // 
            // işlerBölümüToolStripMenuItem
            // 
            this.işlerBölümüToolStripMenuItem.Name = "işlerBölümüToolStripMenuItem";
            this.işlerBölümüToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.işlerBölümüToolStripMenuItem.Text = "İşler bölümü";
            // 
            // materialsBindingSource1
            // 
            this.materialsBindingSource1.DataMember = "Materials";
            this.materialsBindingSource1.DataSource = this.insaatDataSet;
            // 
            // materialsSectionsTableAdapter
            // 
            this.materialsSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // addMaterial
            // 
            this.addMaterial.Location = new System.Drawing.Point(20, 33);
            this.addMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addMaterial.Name = "addMaterial";
            this.addMaterial.Size = new System.Drawing.Size(131, 39);
            this.addMaterial.TabIndex = 2;
            this.addMaterial.Text = "Malzeme ekleme";
            this.addMaterial.UseVisualStyleBackColor = true;
            this.addMaterial.Click += new System.EventHandler(this.button1_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 572);
            this.Controls.Add(this.addMaterial);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Catalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Katalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insaatDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private insaatDataSet insaatDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private insaatDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private insaatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView materialsDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeBölümüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlerBölümüToolStripMenuItem;
        private System.Windows.Forms.BindingSource materialsBindingSource1;
        private insaatDataSetTableAdapters.MaterialsSectionsTableAdapter materialsSectionsTableAdapter;
        private System.Windows.Forms.Button addMaterial;
    }
}