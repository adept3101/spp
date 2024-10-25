using Newtonsoft.Json.Linq;

namespace Mainlb4
{
    public partial class Form3 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form3()
        {
            InitializeComponent();
            LoadCurrencies();
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTo_SelectedIndexChanged);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void LoadCurrencies()
        {
            comboBoxFrom.Items.AddRange(new string[] { "USD", "EUR", "RUB" });
            comboBoxTo.Items.AddRange(new string[] { "USD", "EUR", "RUB" });

        }

        private async void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateExchangeRate();
        }

        private async void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateExchangeRate();
        }

        private async Task UpdateExchangeRate()
        {
            if (comboBoxFrom.SelectedItem != null && comboBoxTo.SelectedItem != null)
            {
                string fromCurrency = comboBoxFrom.SelectedItem.ToString();
                string toCurrency = comboBoxTo.SelectedItem.ToString();
                Console.WriteLine($"Запрос курса: {fromCurrency} к {toCurrency}");

                try
                {
                    double rate = await GetExchangeRateAsync(fromCurrency, toCurrency);
                    labelRate.Text = $"Курс {fromCurrency} к {toCurrency}: {rate}";
                }
                catch (Exception ex)
                {
                    labelRate.Text = "Ошибка при получении курса валют: " + ex.Message;
                }
            }
            else
            {
                labelRate.Text = "Выберите валюты для отображения курса.";
            }
        }
    
        public async Task<double> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            string apiKey = "3849299e377e57142cdb2666"; 
            string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{fromCurrency}";

            try
            {
                string response = await client.GetStringAsync(url);
                var json = JObject.Parse(response);

                if (json["conversion_rates"] != null && json["conversion_rates"][toCurrency] != null)
                {
                    return Convert.ToDouble(json["conversion_rates"][toCurrency].ToString());
                }
                else
                {
                    throw new Exception($"Курс для {toCurrency} не найден.");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении курса валют: " + ex.Message);
                return 0;
            }
        }
    }
}