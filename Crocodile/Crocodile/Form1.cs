namespace Crocodile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            // Настройки для кнопок
            btnPlay.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnPlay.ForeColor = System.Drawing.Color.White;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Arial", 10, FontStyle.Bold);

            btnSettings.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnSettings.ForeColor = System.Drawing.Color.White;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Arial", 10, FontStyle.Bold);

            btnResults.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnResults.ForeColor = System.Drawing.Color.White;
            btnResults.FlatStyle = FlatStyle.Flat;
            btnResults.Font = new Font("Arial", 10, FontStyle.Bold);

            // Настройки для меток
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}
