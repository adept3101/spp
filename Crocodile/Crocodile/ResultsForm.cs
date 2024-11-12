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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            LoadResults();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            // Настройки для кнопок
            btnClearResults.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnClearResults.ForeColor = System.Drawing.Color.White;
            btnClearResults.FlatStyle = FlatStyle.Flat;
            btnClearResults.Font = new Font("Arial", 10, FontStyle.Bold);

           

            // Настройки для меток
            lblGuessedWords.ForeColor = System.Drawing.Color.White;
            lblNotGuessedWords.ForeColor = System.Drawing.Color.White;
            lblGuessedWords.BackColor = System.Drawing.Color.Transparent;
            lblNotGuessedWords.BackColor = System.Drawing.Color.Transparent;
            lblGuessedWords.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblNotGuessedWords.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

        private void LoadResults()
        {
            lstGuessedWords.Items.Clear();
            lstNotGuessedWords.Items.Clear();

            foreach (var word in WordForm.guessedWords)
            {
                lstGuessedWords.Items.Add(word);
            }

            foreach (var word in WordForm.notGuessedWords)
            {
                lstNotGuessedWords.Items.Add(word);
            }
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            WordForm.guessedWords.Clear();
            WordForm.notGuessedWords.Clear();
            LoadResults();
        }
    }
}
