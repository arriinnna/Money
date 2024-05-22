namespace Фин_учёт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddlncome_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtlncome.Text, out decimal income))
            {
                decimal currentBudget = decimal.Parse(txtCurrentBudget.Text);
                currentBudget += income;
                txtCurrentBudget.Text = currentBudget.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for income.");
            }
        }

        private void btnSubtractExpense_Click(object sender, EventArgs e)
        {
            {
                if (decimal.TryParse(txtExpense.Text, out decimal expense))
                {
                    decimal currentBudget = decimal.Parse(txtCurrentBudget.Text);
                    currentBudget -= expense;
                    txtCurrentBudget.Text = currentBudget.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for expense.");
                }
            }
        }

        private void txtBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBudget_Click(object sender, EventArgs e)
        {
            {
                if (decimal.TryParse(txtBudget.Text, out decimal budget))
                {
                    txtCurrentBudget.Text = budget.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for the budget.");
                }
            }

        }

        private void txtCurrentBudget_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
