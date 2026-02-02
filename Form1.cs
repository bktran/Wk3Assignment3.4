namespace Wk3Assignment3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgMenu.DataSource = Data.CoffeeList;
            dgMenu.Columns["Cost"].DisplayIndex = dgMenu.Columns.Count - 1; //move cost to the last column

            cbIce.DataSource = Enum.GetValues(typeof(IceLevel));
            cbSugar.DataSource = Enum.GetValues(typeof(SugarLevel));
            cbSize.DataSource = Enum.GetValues(typeof(BeverageSize));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Coffee coffee = (Coffee)dgMenu.CurrentRow.DataBoundItem;
            var result = MessageBox.Show($"Do you want to delete {coffee.Name}?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.CoffeeList.Remove(coffee);
                dgMenu.DataSource = null;
                dgMenu.DataSource = Data.CoffeeList;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Name cannot be blank");
            }
            else
            {
                Coffee newCoffee = new Coffee();
                newCoffee.Name = txtName.Text;
                newCoffee.Size = (BeverageSize)cbSize.SelectedItem;
                newCoffee.IceLevel = (IceLevel)cbIce.SelectedItem;
                newCoffee.SugarLevel = (SugarLevel)cbSugar.SelectedItem;
                Data.CoffeeList.Add(newCoffee);
            }

            dgMenu.DataSource = null;
            dgMenu.DataSource = Data.CoffeeList;
        }
    }
}
