using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Crocodile
{
    public partial class GameForm : Form
    {
        private string playerName;
        private ResultsForm resultsForm;
        private string currentWord;
        private Queue<string> wordsQueue = new Queue<string>();

        public GameForm(string playerName, ResultsForm resultsForm)
        {
            InitializeComponent();
            this.playerName = playerName;
            this.resultsForm = resultsForm;
            resultsForm.AddPlayerName(playerName);
            this.FormClosing += GameForm_FormClosing;

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            btnSports.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnSports.ForeColor = System.Drawing.Color.White;
            btnSports.FlatStyle = FlatStyle.Flat;
            btnSports.Font = new Font("Arial", 10, FontStyle.Bold);

            btnNature.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnNature.ForeColor = System.Drawing.Color.White;
            btnNature.FlatStyle = FlatStyle.Flat;
            btnNature.Font = new Font("Arial", 10, FontStyle.Bold);

            btnAnimals.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnAnimals.ForeColor = System.Drawing.Color.White;
            btnAnimals.FlatStyle = FlatStyle.Flat;
            btnAnimals.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.Load += new System.EventHandler(this.GameForm_Load);
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            OpenWordForm("Спорт");
        }

        private void btnNature_Click(object sender, EventArgs e)
        {
            OpenWordForm("Природа");
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            OpenWordForm("Животные");
        }

        private void OpenWordForm(string category)
        {
            var wordForm = new WordForm(category, playerName);

            wordForm.GameFinished += (guessed, notGuessed) =>
            {
                resultsForm.AddResult(playerName, guessed, notGuessed);
            };

            wordForm.ShowDialog();
        }

    }
}
