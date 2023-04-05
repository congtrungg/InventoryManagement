using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        DataTable inventory = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Mã ");
            inventory.Columns.Add("Tên ");
            inventory.Columns.Add("Mục");
            inventory.Columns.Add("Số lượng");
            inventory.Columns.Add("Giá");
            inventory.Columns.Add("Mô tả");

            inventoryGridView.DataSource = inventory;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            priceTextBox.Text = "";
            categoryBox.SelectedIndex = -1;
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String ID  = IDTextBox.Text;
            String price = priceTextBox.Text;
            String name = nameTextBox.Text;
            String quantity = quantityTextBox.Text;
            String description = descriptionTextBox.Text;
            String category = (string)categoryBox.SelectedItem;

            inventory.Rows.Add(ID, name, category, price, description, quantity);

            newButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               IDTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
               nameTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
               priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
               descriptionTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
               quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();
               String itemToLookFor= inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
               categoryBox.SelectedIndex= categoryBox.Items.IndexOf(itemToLookFor);
            }
            catch(Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }
        }
    }
}
