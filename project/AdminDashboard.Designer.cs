namespace project
{
    partial class AdminDashboard
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
            this.DGVMenuItems = new System.Windows.Forms.DataGridView();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSet1 = new project.BrewByteDataSet1();
            this.menuItemsTableAdapter = new project.BrewByteDataSet1TableAdapters.MenuItemsTableAdapter();
            this.lblMenuID = new System.Windows.Forms.Label();
            this.tbMenuID = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.brewByteDataSet = new project.BrewByteDataSet();
            this.brewByteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemsTableAdapter1 = new project.BrewByteDataSetTableAdapters.MenuItemsTableAdapter();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMenuItems
            // 
            this.DGVMenuItems.AutoGenerateColumns = false;
            this.DGVMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.Quantity,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.DGVMenuItems.DataSource = this.menuItemsBindingSource1;
            this.DGVMenuItems.Location = new System.Drawing.Point(34, 12);
            this.DGVMenuItems.Name = "DGVMenuItems";
            this.DGVMenuItems.ReadOnly = true;
            this.DGVMenuItems.RowHeadersWidth = 62;
            this.DGVMenuItems.RowTemplate.Height = 28;
            this.DGVMenuItems.Size = new System.Drawing.Size(831, 116);
            this.DGVMenuItems.TabIndex = 0;
            this.DGVMenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMenuItems_CellContentClick);
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.brewByteDataSet1;
            // 
            // brewByteDataSet1
            // 
            this.brewByteDataSet1.DataSetName = "BrewByteDataSet1";
            this.brewByteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // lblMenuID
            // 
            this.lblMenuID.AutoSize = true;
            this.lblMenuID.Location = new System.Drawing.Point(230, 162);
            this.lblMenuID.Name = "lblMenuID";
            this.lblMenuID.Size = new System.Drawing.Size(74, 20);
            this.lblMenuID.TabIndex = 1;
            this.lblMenuID.Text = "MenuID: ";
            // 
            // tbMenuID
            // 
            this.tbMenuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMenuID.Location = new System.Drawing.Point(321, 160);
            this.tbMenuID.Name = "tbMenuID";
            this.tbMenuID.Size = new System.Drawing.Size(199, 26);
            this.tbMenuID.TabIndex = 2;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(230, 209);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(91, 20);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "ItemName: ";
            // 
            // tbItemName
            // 
            this.tbItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemName.Location = new System.Drawing.Point(321, 207);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(199, 26);
            this.tbItemName.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(230, 255);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price: ";
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Location = new System.Drawing.Point(322, 253);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(197, 26);
            this.tbPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(173, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(322, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(472, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 31);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(230, 300);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category: ";
            // 
            // tbCategory
            // 
            this.tbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCategory.Location = new System.Drawing.Point(322, 301);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(197, 26);
            this.tbCategory.TabIndex = 11;
            // 
            // brewByteDataSet
            // 
            this.brewByteDataSet.DataSetName = "BrewByteDataSet";
            this.brewByteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brewByteDataSetBindingSource
            // 
            this.brewByteDataSetBindingSource.DataSource = this.brewByteDataSet;
            this.brewByteDataSetBindingSource.Position = 0;
            // 
            // menuItemsBindingSource1
            // 
            this.menuItemsBindingSource1.DataMember = "MenuItems";
            this.menuItemsBindingSource1.DataSource = this.brewByteDataSetBindingSource;
            // 
            // menuItemsTableAdapter1
            // 
            this.menuItemsTableAdapter1.ClearBeforeFill = true;
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "MenuID";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.tbMenuID);
            this.Controls.Add(this.lblMenuID);
            this.Controls.Add(this.DGVMenuItems);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMenuItems;
        private BrewByteDataSet1 brewByteDataSet1;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private BrewByteDataSet1TableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private System.Windows.Forms.Label lblMenuID;
        private System.Windows.Forms.TextBox tbMenuID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbCategory;
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