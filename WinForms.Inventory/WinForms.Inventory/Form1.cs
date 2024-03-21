namespace WinForms.Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            listBox1.Items.Clear();
            List<InventoryItem> items = InventoryDB.GetItems();
            foreach (InventoryItem item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //Open the AddInventory form
            AddInventory addInventory = new AddInventory();
            addInventory.ShowDialog();
            RefreshList();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //Delete the selected item from the list
            int selectedIndex = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                InventoryDB.DeleteItem(selectedIndex);
                RefreshList();
                MessageBox.Show("Item deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select an item to delete","Error");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
