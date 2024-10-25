using Newtonsoft.Json.Linq;

namespace Mainlb4
{
    public partial class Form2 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string fromCurrency;
        private string toCurrency;
        private double amount;

        public Form2(string fromCurrency, string toCurrency, double amount)
        {
            InitializeComponent();
            this.fromCurrency = fromCurrency;
            this.toCurrency = toCurrency;
            this.amount = amount;
            LoadResult();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private async void LoadResult()
        {

            try
            {
                double rate = await GetExchangeRateAsync(fromCurrency, toCurrency);
                double result = amount * rate;

                label1.Text = $"{amount} {fromCurrency} = {result} {toCurrency}";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        
        }

        private async Task<double> GetExchangeRateAsync(string fromCurrency, string toCurrency)
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
                    MessageBox.Show($"Курс для {toCurrency} не найден.");
                    throw new Exception($"Курс для {toCurrency} не найден.");
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("Ошибка сети при получении курса валют: " + httpEx.Message);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении курса валют: " + ex.Message);
                return 0;
            }
        }
    }
}
