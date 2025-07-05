using project.BrewByteDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class PaymentForm : Form
    {
        private List<MenuForm.SelectedItem> orderList;
        private decimal totalAmount;

        public PaymentForm(List<MenuForm.SelectedItem> items, decimal total)
        {
            InitializeComponent();
            orderList = items;
            totalAmount = total;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblTotal.Text = $"Total: RM {totalAmount:0.00}";

            var dt = new DataTable();
            dt.Columns.Add("Item");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");

            foreach (var item in orderList)
            {
                dt.Rows.Add(item.Item, item.Price.ToString("0.00"), item.Quantity);
            }

            dataGridView1.DataSource = dt;

            var deliveryAdapter = new DeliveryOptionsTableAdapter();
            var deliveryTable = new BrewByteDataSet.DeliveryOptionsDataTable();
            deliveryAdapter.Fill(deliveryTable);
            cbDelivery.DataSource = deliveryTable;
            cbDelivery.DisplayMember = "OptionName";
            cbDelivery.ValueMember = "DeliveryOptionID";

            cbPayment.DataSource = new List<string> { "Cash", "e-Wallet", "Card" };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedId = cbDelivery.SelectedValue;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string custName = tbCustName.Text.Trim();
            if (string.IsNullOrWhiteSpace(custName))
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }
            if (cbPayment.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            int deliveryOption = Convert.ToInt32(cbDelivery.SelectedValue);
            string paymentType = cbPayment.SelectedItem.ToString();

            try
            {
                var orderAdapter = new OrdersTableAdapter();
                orderAdapter.InsertOrder(DateTime.Now, custName, deliveryOption, totalAmount);
                int orderId = (int)orderAdapter.GetData()
                    .OrderByDescending(o => o.OrderID).First().OrderID;

                var detailAdapter = new OrderDetailsTableAdapter();
                var menuAdapter = new MenuItemsTableAdapter();
                var menuData = menuAdapter.GetData();

                foreach (var item in orderList)
                {
                    var match = menuData.FirstOrDefault(m => m.ItemName == item.Item);
                    if (match != null)
                    {
                        detailAdapter.Insert1(orderId, match.MenuID, item.Quantity);
                    }
                }

                var paymentAdapter = new PaymentTableAdapter();
                paymentAdapter.Insert1(orderId, paymentType, DateTime.Now);

                var summary = orderList
                    .Select(i => $"{i.Quantity} x {i.Item} (RM {i.Price:0.00})")
                    .ToList();

                MessageBox.Show($"Thank you, {custName}!\nYour order ID is {orderId}");
                new OrderForm(orderId, custName, paymentType, totalAmount, summary).Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm Menu = new MenuForm();  // ganti dengan nama form yang nak dibuka
            Menu.Show(); // buka form baru
            this.Hide();
        }
    }
}
