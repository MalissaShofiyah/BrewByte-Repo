namespace project
{
    partial class PaymentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryOptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSet = new project.BrewByteDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbDelivery = new System.Windows.Forms.ComboBox();
            this.deliveryOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSet3 = new project.BrewByteDataSet3();
            this.deliveryOptionsTableAdapter = new project.BrewByteDataSet3TableAdapters.DeliveryOptionsTableAdapter();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brewByteDataSet4 = new project.BrewByteDataSet4();
            this.paymentTableAdapter = new project.BrewByteDataSet4TableAdapters.PaymentTableAdapter();
            this.lblCustName = new System.Windows.Forms.Label();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.ordersTableAdapter = new project.BrewByteDataSetTableAdapters.OrdersTableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.deliveryOptionIDDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(835, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryOptionIDDataGridViewTextBoxColumn
            // 
            this.deliveryOptionIDDataGridViewTextBoxColumn.DataPropertyName = "DeliveryOptionID";
            this.deliveryOptionIDDataGridViewTextBoxColumn.HeaderText = "DeliveryOptionID";
            this.deliveryOptionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deliveryOptionIDDataGridViewTextBoxColumn.Name = "deliveryOptionIDDataGridViewTextBoxColumn";
            this.deliveryOptionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.brewByteDataSetBindingSource;
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.brewByteDataSetBindingSource;
            // 
            // cbDelivery
            // 
            this.cbDelivery.DataSource = this.deliveryOptionsBindingSource;
            this.cbDelivery.FormattingEnabled = true;
            this.cbDelivery.Location = new System.Drawing.Point(268, 305);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(121, 28);
            this.cbDelivery.TabIndex = 1;
            this.cbDelivery.SelectedIndexChanged += new System.EventHandler(this.cbDelivery_SelectedIndexChanged);
            // 
            // deliveryOptionsBindingSource
            // 
            this.deliveryOptionsBindingSource.DataMember = "DeliveryOptions";
            this.deliveryOptionsBindingSource.DataSource = this.brewByteDataSet3;
            // 
            // brewByteDataSet3
            // 
            this.brewByteDataSet3.DataSetName = "BrewByteDataSet3";
            this.brewByteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryOptionsTableAdapter
            // 
            this.deliveryOptionsTableAdapter.ClearBeforeFill = true;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(96, 305);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(166, 25);
            this.lblDelivery.TabIndex = 2;
            this.lblDelivery.Text = "Delivery Options: ";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(96, 353);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(145, 25);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.Text = "Payment Type:";
            // 
            // cbPayment
            // 
            this.cbPayment.DataSource = this.paymentBindingSource;
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(267, 357);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(121, 28);
            this.cbPayment.TabIndex = 4;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.brewByteDataSet4;
            // 
            // brewByteDataSet4
            // 
            this.brewByteDataSet4.DataSetName = "BrewByteDataSet4";
            this.brewByteDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(96, 259);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(160, 25);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "Customer Name:";
            // 
            // tbCustName
            // 
            this.tbCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustName.Location = new System.Drawing.Point(269, 259);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(226, 26);
            this.tbCustName.TabIndex = 6;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(736, 404);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(148, 39);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(96, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total: RM ";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.brewByteDataSetBindingSource;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(557, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(913, 506);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.cbDelivery);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brewByteDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbDelivery;
        private BrewByteDataSet3 brewByteDataSet3;
        private System.Windows.Forms.BindingSource deliveryOptionsBindingSource;
        private BrewByteDataSet3TableAdapters.DeliveryOptionsTableAdapter deliveryOptionsTableAdapter;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cbPayment;
        private BrewByteDataSet4 brewByteDataSet4;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private BrewByteDataSet4TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.BindingSource brewByteDataSetBindingSource;
        private BrewByteDataSet brewByteDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BrewByteDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryOptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.Button btnBack;
    }
}