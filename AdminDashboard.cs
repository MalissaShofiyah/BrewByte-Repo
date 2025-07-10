using project.BrewByteDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class AdminDashboard : Form
    {
        private MenuItemsTableAdapter adapter = new MenuItemsTableAdapter();

        public AdminDashboard()
        {
            InitializeComponent();
            this.FormClosed += AdminDashboard_FormClosed;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadMenu();
            DGVMenuItems.DataError += DGVMenuItems_DataError;
            DGVMenuItems.DataBindingComplete += DGVMenuItems_DataBindingComplete;
        }

        private void LoadMenu()
        {
            var table = adapter.GetData();
            DGVMenuItems.AutoGenerateColumns = false;
            DGVMenuItems.DataSource = table;

            DGVMenuItems.Columns.Clear();
            DGVMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "MenuID",
                DataPropertyName = "MenuID",
                Name = "MenuID",
                Width = 100
            });
            DGVMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Item Name",
                DataPropertyName = "ItemName",
                Name = "ItemName",
                Width = 150
            });
            DGVMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price (RM)",
                DataPropertyName = "Price",
                Name = "Price",
                Width = 100
            });
            DGVMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "Category",
                Name = "Category",
                Width = 120
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (decimal.TryParse(tbPrice.Text, out decimal price))
                {
                    adapter.InsertMenuItem(tbItemName.Text.Trim(), price, tbCategory.Text.Trim());
                    LoadMenu();
                    ClearFields();
                    MessageBox.Show("Item added successfully.");
                }
                else
                {
                    MessageBox.Show("Invalid price format.");
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbMenuID.Text, out int menuId) && decimal.TryParse(tbPrice.Text, out decimal price))
            {
                var table = adapter.GetData();
                var row = table.FirstOrDefault(r => r.MenuID == menuId);

                if (row != null)
                {
                    adapter.UpdateMenuItem(tbItemName.Text.Trim(), price, tbCategory.Text.Trim(), menuId);
                    LoadMenu();
                    ClearFields();
                    MessageBox.Show("Item updated.");
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
            }
            else
            {
                MessageBox.Show("Enter valid MenuID and Price.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbMenuID.Text, out int menuId))
            {
                adapter.DeleteMenuItem(menuId);
                LoadMenu();
                ClearFields();
                MessageBox.Show("Item deleted.");
            }
            else
            {
                MessageBox.Show("Enter valid MenuID.");
            }
        }

        private void DGVMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = DGVMenuItems.Rows[e.RowIndex];
                tbMenuID.Text = row.Cells["MenuID"].Value.ToString();
                tbItemName.Text = row.Cells["ItemName"].Value.ToString();
                tbPrice.Text = row.Cells["Price"].Value.ToString();
                tbCategory.Text = row.Cells["Category"].Value.ToString();
            }
        }

        private bool ValidateInputs()
        {
            return !(string.IsNullOrEmpty(tbItemName.Text) ||
                     string.IsNullOrEmpty(tbPrice.Text) ||
                     string.IsNullOrEmpty(tbCategory.Text));
        }

        private void ClearFields()
        {
            tbMenuID.Clear();
            tbItemName.Clear();
            tbPrice.Clear();
            tbCategory.Clear();
        }

        private void DGVMenuItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGVMenuItems.ClearSelection();
        }

        private void DGVMenuItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonBack2_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }
    }
}

