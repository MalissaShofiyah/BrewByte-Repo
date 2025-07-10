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
    public partial class MenuForm : Form
    {
        public class SelectedItem
        {
            public string Item { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        
        private List<SelectedItem> selectedItems = new List<SelectedItem>();

        public MenuForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brewByteDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter1.Fill(this.brewByteDataSet.MenuItems);
            DGVMenu.AutoGenerateColumns = false;
            DGVMenu.Columns.Clear();

            DGVMenu.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Item",
                DataPropertyName = "ItemName",
                Name = "ItemName",
                ReadOnly = true,
                Width = 180
            });

            DGVMenu.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price (RM)",
                DataPropertyName = "Price",
                Name = "Price",
                ReadOnly = true,
                Width = 100
            });

            DGVMenu.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                Name = "Quantity",
                Width = 80
            });

            DGVMenu.DataSource = brewByteDataSet.MenuItems;

            DGVMenu.DataError += (s, args) => { args.ThrowException = false; };
        }


        private void lblTotal_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DGVMenu.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(Convert.ToString(row.Cells["Quantity"].Value), out int qty) &&
                    decimal.TryParse(Convert.ToString(row.Cells["Price"].Value), out decimal price))
                {
                    total += qty * price;
                }
            }
            lblTotal.Text = $"Total: RM {total:0.00}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            selectedItems.Clear();

            foreach (DataGridViewRow row in DGVMenu.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(Convert.ToString(row.Cells["Quantity"].Value), out int qty) && qty > 0)
                {
                    string name = Convert.ToString(row.Cells["ItemName"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    selectedItems.Add(new SelectedItem
                    {
                        Item = name,
                        Price = price,
                        Quantity = qty
                    });

                    total += qty * price;
                }
            }
            new PaymentForm(selectedItems, total).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm Form2 = new LoginForm();
            Form2.Show();
            this.Hide();
        }

        private void DGVMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
