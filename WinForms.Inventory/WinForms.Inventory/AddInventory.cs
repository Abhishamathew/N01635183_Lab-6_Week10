using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Inventory
{
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //retrieve the data and parsing from the form and save it to the file
            // Check if any of the fields are empty.
            if (string.IsNullOrWhiteSpace(ItemNumbertxt.Text) || string.IsNullOrWhiteSpace(pricetxt.Text) || string.IsNullOrWhiteSpace(Desctxt.Text))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                // Attempt to parse the item number from the ItemNumbertxt TextBox.
                if (!int.TryParse(ItemNumbertxt.Text, out int itemNo))
                {
                    MessageBox.Show("Invalid item number entered. Please enter a valid integer.");
                }
                // Attempt to parse the price from the pricetxt TextBox.
                else if (!decimal.TryParse(pricetxt.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price entered. Please enter a valid decimal number.");
                }
                else
                {
                    InventoryItem item = new InventoryItem(itemNo, Desctxt.Text, price);

                    // Retrieve the list of existing items from the InventoryDB.
                    List<InventoryItem> items = InventoryDB.GetItems();
                    items.Add(item);
                    InventoryDB.SaveItems(items);
                    MessageBox.Show("Item added successfully");
                    this.Close();
                }
            }

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
