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
    public partial class OrderForm : Form
    {
        public OrderForm(int orderId, string customerName, string paymentType, decimal total, List<string> orderDetails)
        {
            InitializeComponent();

            lblOrderID.Text = $"Order ID: {orderId}";
            lblCustName.Text = $"Customer: {customerName}";
            lblPayType.Text = $"Payment: {paymentType}";
            lblTotal.Text = $"Total: RM {total:F2}";

            foreach (var item in orderDetails)
            {
                lbOrder.Items.Add(item);
            }
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
