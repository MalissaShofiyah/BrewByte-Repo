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
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
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
            HeaderText = "ID",
            DataPropertyName = "MenuID",
            Name = "MenuID",
            ReadOnly = true,
            Width = 50
            });

            DGVMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
            HeaderText = "Item",
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

        private void DGVMenuItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGVMenuItems.ClearSelection();
        }

        private void DGVMenuItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // Cegah error popup bila data tak valid
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbMenuID.Text, out int menuId) && decimal.TryParse(tbPrice.Text, out decimal price))
            {
            var table = adapter.GetData();
            var row = table.FirstOrDefault(r => r.MenuID == menuId);

                if (row != null)
                {
                    adapter.InsertMenuItem(tbItemName.Text.Trim(), price, tbCategory.Text.Trim());
                    LoadMenu();
                    ClearFields();
                    MessageBox.Show("Item Added.");
                }
            else
            {
                MessageBox.Show("Select a valid item to add.");
            }
            }
            
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(tbMenuID.Text) || string.IsNullOrEmpty(tbItemName.Text) || string.IsNullOrEmpty(tbPrice.Text) ||string.IsNullOrEmpty(tbCategory.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbMenuID.Text, out int menuId) && decimal.TryParse(tbPrice.Text, out decimal price))
            {
                var table = adapter.GetData();
                var row = table.FirstOrDefault(r => r.MenuID == menuId);

                if (row != null)
                {
                    row.ItemName = tbItemName.Text.Trim();
                    row.Price = price;
                    row.Category = tbCategory.Text.Trim();
                    adapter.UpdateMenuItem(tbItemName.Text.Trim(), price, tbCategory.Text.Trim(), menuId);
                    LoadMenu();
                    ClearFields();
                    MessageBox.Show("Item updated.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid details to update.");
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
                MessageBox.Show("Select a valid item to delete.");
            }
        }

        private void ClearFields()
        {
            tbMenuID.Clear();
            tbItemName.Clear();
            tbPrice.Clear();
            tbCategory.Clear();
        }
        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
 }

