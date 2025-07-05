namespace project
{
    partial class MenuForm
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
            this.DGVMenu = new System.Windows.Forms.DataGridView();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSet = new project.BrewByteDataSet();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSet2 = new project.BrewByteDataSet2();
            this.menuItemsTableAdapter = new project.BrewByteDataSet2TableAdapters.MenuItemsTableAdapter();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuItemsTableAdapter1 = new project.BrewByteDataSetTableAdapters.MenuItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMenu
            // 
            this.DGVMenu.AutoGenerateColumns = false;
            this.DGVMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.Quantity,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.DGVMenu.DataSource = this.menuItemsBindingSource1;
            this.DGVMenu.Location = new System.Drawing.Point(48, 26);
            this.DGVMenu.Name = "DGVMenu";
            this.DGVMenu.RowHeadersWidth = 62;
            this.DGVMenu.RowTemplate.Height = 28;
            this.DGVMenu.Size = new System.Drawing.Size(841, 196);
            this.DGVMenu.TabIndex = 0;
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "MenuID";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // menuItemsBindingSource1
            // 
            this.menuItemsBindingSource1.DataMember = "MenuItems";
            this.menuItemsBindingSource1.DataSource = this.brewByteDataSetBindingSource;
            // 
            // brewByteDataSetBindingSource
            // 
            this.brewByteDataSetBindingSource.DataSource = this.brewByteDataSet;
            this.brewByteDataSetBindingSource.Position = 0;
            // 
            // brewByteDataSet
            // 
            this.brewByteDataSet.DataSetName = "BrewByteDataSet";
            this.brewByteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.brewByteDataSet2;
            // 
            // brewByteDataSet2
            // 
            this.brewByteDataSet2.DataSetName = "BrewByteDataSet2";
            this.brewByteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.Location = new System.Drawing.Point(607, 389);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(632, 354);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 32);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = " Total";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // menuItemsTableAdapter1
            // 
            this.menuItemsTableAdapter1.ClearBeforeFill = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.DGVMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMenu;
        private BrewByteDataSet2 brewByteDataSet2;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private BrewByteDataSet2TableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.BindingSource brewByteDataSetBindingSource;
        private BrewByteDataSet brewByteDataSet;
        private System.Windows.Forms.BindingSource menuItemsBindingSource1;
        private BrewByteDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}