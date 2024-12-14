using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crocodile
{
    public partial class ResultsForm : Form
    {
        private Dictionary<string, List<string>> guessedWords = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> notGuessedWords = new Dictionary<string, List<string>>();
        public ResultsForm()
        {
            InitializeComponent();
            LoadResults();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            btnClearResults.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnClearResults.ForeColor = System.Drawing.Color.White;
            btnClearResults.FlatStyle = FlatStyle.Flat;
            btnClearResults.Font = new Font("Arial", 10, FontStyle.Bold);



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

            foreach (var player in guessedWords.Keys)
            {
                foreach (var word in guessedWords[player])
                {
                    lstGuessedWords.Items.Add($"{player}: {word}");
                }
            }

            foreach (var player in notGuessedWords.Keys)
            {
                foreach (var word in notGuessedWords[player])
                {
                    lstNotGuessedWords.Items.Add($"{player}: {word}");
                }
            }
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            
        }

        public void AddResult(string playerName, List<string> guessed, List<string> notGuessed)
        {
            // Добавляем угаданные и неугаданные слова в словари
            if (!guessedWords.ContainsKey(playerName))
            {
                guessedWords[playerName] = new List<string>();
            }
            guessedWords[playerName].AddRange(guessed);

            if (!notGuessedWords.ContainsKey(playerName))
            {
                notGuessedWords[playerName] = new List<string>();
            }
            notGuessedWords[playerName].AddRange(notGuessed);

            // После добавления слов обновляем историю
            UpdatePlayerHistory();
        }

        private void UpdatePlayerHistory()
        {
            // Очистка списка
            listBox1.Items.Clear();

            // Сортировка игроков по количеству угаданных слов
            var sortedPlayerScores = guessedWords
                .Select(kv => new { Player = kv.Key, GuessedCount = kv.Value.Count })
                .OrderByDescending(x => x.GuessedCount)  // Сортируем по убыванию количества угаданных слов
                .ToList();

            // Добавляем игроков в listBox с количеством угаданных слов
            foreach (var player in sortedPlayerScores)
            {
                listBox1.Items.Add($"{player.Player} ({player.GuessedCount})");
            }
        }


        private void btnClearResults_Click(object sender, EventArgs e)
        {
            guessedWords.Clear();
            notGuessedWords.Clear();

            lstGuessedWords.Items.Clear();
            lstNotGuessedWords.Items.Clear();
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            string selectedPlayer = listBox1.SelectedItem.ToString();
            lstGuessedWords.Items.Clear();
            lstNotGuessedWords.Items.Clear();

            if (guessedWords.ContainsKey(selectedPlayer))
            {
                //MessageBox.Show($"Угаданные слова для {selectedPlayer}: {string.Join(", ", guessedWords[selectedPlayer])}");
                foreach (string word in guessedWords[selectedPlayer])
                {
                    lstGuessedWords.Items.Add(word);
                }
            }
            //else
            //{
            //    //MessageBox.Show($"Угаданных слов для {selectedPlayer} нет.");
            //}
            
            if (notGuessedWords.ContainsKey(selectedPlayer))
            {
               // MessageBox.Show($"Неугаданные слова для {selectedPlayer}: {string.Join(", ", notGuessedWords[selectedPlayer])}");
                foreach (string word in notGuessedWords[selectedPlayer])
                {
                    lstNotGuessedWords.Items.Add(word);
                }
            }
            //else
            //{
            //    MessageBox.Show($"Неугаданных слов для {selectedPlayer} нет.");
            //}
        }

        public void AddPlayerName(string playerName)
        {
            if (!string.IsNullOrEmpty(playerName) && !listBox1.Items.Contains(playerName))
            {
                listBox1.Items.Add(playerName);
            }
        }

        public void DebugPrintDictionaries()
        {
            string guessed = string.Join("\n", guessedWords.Select(kv => $"{kv.Key}: {string.Join(", ", kv.Value)}"));
            string notGuessed = string.Join("\n", notGuessedWords.Select(kv => $"{kv.Key}: {string.Join(", ", kv.Value)}"));

            //MessageBox.Show($"Угаданные слова:\n{guessed}\n\nНеугаданные слова:\n{notGuessed}");
        }
    }
}