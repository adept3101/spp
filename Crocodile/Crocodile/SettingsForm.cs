using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crocodile
{
    public partial class SettingsForm : Form
    {
        public static int GameTime { get; private set; } = 60;
        public SettingsForm()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            // Настройки для кнопок
            btnSave.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 10, FontStyle.Bold);

            

            // Настройки для меток
            lblTime.ForeColor = System.Drawing.Color.White;
            lblTime.BackColor = System.Drawing.Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            trackBarTime.Minimum = 10;
            trackBarTime.Maximum = 120;
            GameTime = 60;
            trackBarTime.Value = GameTime;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            GameTime = trackBarTime.Value;

            lblTime.Text = $"Время: {GameTime} сек";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameTime = trackBarTime.Value;
            MessageBox.Show("Время игры сохранено!", "Настройки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
