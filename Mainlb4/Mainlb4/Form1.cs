namespace Mainlb4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCurrencies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadCurrencies()
        {
            comboBoxFrom.Items.AddRange(new string[] { "USD", "EUR", "RUB" });
            comboBoxTo.Items.AddRange(new string[] { "USD", "EUR", "RUB" });
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            var fromCurrency = comboBoxFrom.SelectedItem.ToString();
            var toCurrency = comboBoxTo.SelectedItem.ToString();
            var amount = Convert.ToDouble(textBoxAmount.Text);

            var conversionForm = new Form2(fromCurrency, toCurrency, amount);
            conversionForm.Show();
        }

        private void buttonCurse_Click(object sender, EventArgs e)
        {
            var fromCurrency = comboBoxFrom.SelectedItem.ToString();
            var toCurrency = comboBoxTo.SelectedItem.ToString();
            var amount = Convert.ToDouble(textBoxAmount.Text);

            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
