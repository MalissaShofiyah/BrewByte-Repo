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
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSet = new project.BrewByteDataSet();
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
            this.menuItemsTableAdapter1 = new project.BrewByteDataSetTableAdapters.MenuItemsTableAdapter();
            this.ButtonBack2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMenuItems
            // 
            this.DGVMenuItems.AutoGenerateColumns = false;
            this.DGVMenuItems.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGVMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.Quantity,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.DGVMenuItems.DataSource = this.menuItemsBindingSource1;
            this.DGVMenuItems.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVMenuItems.Location = new System.Drawing.Point(30, 56);
            this.DGVMenuItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVMenuItems.Name = "DGVMenuItems";
            this.DGVMenuItems.ReadOnly = true;
            this.DGVMenuItems.RowHeadersWidth = 62;
            this.DGVMenuItems.RowTemplate.Height = 28;
            this.DGVMenuItems.Size = new System.Drawing.Size(739, 239);
            this.DGVMenuItems.TabIndex = 0;
            this.DGVMenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMenuItems_CellContentClick);
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
            this.lblMenuID.Location = new System.Drawing.Point(278, 320);
            this.lblMenuID.Name = "lblMenuID";
            this.lblMenuID.Size = new System.Drawing.Size(59, 16);
            this.lblMenuID.TabIndex = 1;
            this.lblMenuID.Text = "MenuID: ";
            // 
            // tbMenuID
            // 
            this.tbMenuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMenuID.Location = new System.Drawing.Point(359, 318);
            this.tbMenuID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMenuID.Name = "tbMenuID";
            this.tbMenuID.Size = new System.Drawing.Size(177, 22);
            this.tbMenuID.TabIndex = 2;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(278, 357);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(75, 16);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "ItemName: ";
            // 
            // tbItemName
            // 
            this.tbItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemName.Location = new System.Drawing.Point(359, 356);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(177, 22);
            this.tbItemName.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(278, 394);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price: ";
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Location = new System.Drawing.Point(360, 392);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(175, 22);
            this.tbPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(228, 476);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(360, 476);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(494, 476);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(278, 430);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category: ";
            // 
            // tbCategory
            // 
            this.tbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCategory.Location = new System.Drawing.Point(360, 431);
            this.tbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(175, 22);
            this.tbCategory.TabIndex = 11;
            // 
            // menuItemsTableAdapter1
            // 
            this.menuItemsTableAdapter1.ClearBeforeFill = true;
            // 
            // ButtonBack2
            // 
            this.ButtonBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack2.ForeColor = System.Drawing.Color.White;
            this.ButtonBack2.Location = new System.Drawing.Point(12, 11);
            this.ButtonBack2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack2.Name = "ButtonBack2";
            this.ButtonBack2.Size = new System.Drawing.Size(35, 32);
            this.ButtonBack2.TabIndex = 14;
            this.ButtonBack2.Text = "<";
            this.ButtonBack2.UseVisualStyleBackColor = false;
            this.ButtonBack2.Click += new System.EventHandler(this.ButtonBack2_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(801, 528);
            this.Controls.Add(this.ButtonBack2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet1)).EndInit();
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
        private System.Windows.Forms.Button ButtonBack2;
    }
}