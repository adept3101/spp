using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Crocodile
{
    public delegate void GameFinishedHandler(List<string> guessedWords, List<string> notGuessedWords);

    public partial class WordForm : Form
    {
        private string currentWord;
        private string category;
        private System.Windows.Forms.Timer countdownTimer;
        private int timeLeft;
        private string playerName;
        public event GameFinishedHandler GameFinished;

        public static List<string> guessedWords = new List<string>();
        public static List<string> notGuessedWords = new List<string>();

        private static Dictionary<string, List<string>> words = new Dictionary<string, List<string>>()
        {
            {"Спорт", new List<string> {"Футбол", "Теннис", "Баскетбол", "Хоккей", "Плавание", "Волейбол", "Бадминтон", "Гольф", "Регби", "Крикет",
            "Бокс", "Борьба", "Каратэ", "Дзюдо", "Самбо", "Сквош", "Фехтование", "Серфинг", "Скейтбординг", "Сноубординг", "Лыжи", "Биатлон",
            "Конькобежный спорт", "Шахматы", "Бильярд", "Дартс", "Автоспорт", "Прыжки в воду", "Водное поло", "Гимнастика", "Бейсбол",
            "Американский футбол", "Фигурное катание", "Тхэквондо", "Сумо", "Триатлон", "Парусный спорт", "Прыжки на батуте", "Альпинизм",
            "Лёгкая атлетика", "Настольный теннис", "Скалолазание", "Керлинг", "Синхронное плавание", "Гандбол", "Парашютный спорт", "Стрельба",
            "Прыжки с трамплина", "Мотоспорт", "Армрестлинг", "Пауэрлифтинг"}},

            {"Природа", new List<string> {"Собака", "Кошка", "Тигр", "Слон", "Лев", "Волк", "Лиса", "Лошадь", "Кролик", "Обезьяна", "Медведь", "Жираф",
            "Зебра", "Панда", "Кенгуру", "Енот", "Бегемот", "Крокодил", "Орел", "Сова", "Пингвин", "Тюлень", "Дельфин", "Акула", "Кит", "Леопард",
            "Рысь", "Пума", "Як", "Антилопа", "Верблюд", "Лама", "Белка", "Барсук", "Гепард", "Еж", "Сурикат", "Фламинго", "Страус", "Павлин",
            "Попугай", "Чайка", "Лебедь", "Игуана", "Змея", "Черепаха", "Жаба", "Скорпион", "Муравей", "Пчела"}},

            {"Животные", new List<string> {"Гора", "Лес", "Озеро", "Река", "Песок", "Пляж", "Океан", "Пустыня", "Водопад", "Долина", "Пещера", "Тундра",
            "Плато", "Саванна", "Луг", "Поле", "Болото", "Ледник", "Пруд", "Ручей", "Лагуна", "Залив", "Фьорд", "Скала", "Утес", "Равнина", "Каньон",
            "Вулкан", "Холм", "Тайга", "Манговые леса", "Джунгли", "Эстуарий", "Гейзер", "Коралловый риф", "Лагуна", "Оазис", "Тропики",
            "Альпийские луга", "Море", "Тропический лес", "Скалистый утес", "Побережье", "Водно-болотные угодья", "Ледяная пустыня",
            "Тропический остров", "Пастбище", "Рифтовая долина", "Залив", "Кипарисовая роща"}}
        };

        public WordForm(string category, string playerName)
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            btnGuessed.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnGuessed.ForeColor = System.Drawing.Color.White;
            btnGuessed.FlatStyle = FlatStyle.Flat;
            btnGuessed.Font = new Font("Arial", 10, FontStyle.Bold);

            btnNotGuessed.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            btnNotGuessed.ForeColor = System.Drawing.Color.White;
            btnNotGuessed.FlatStyle = FlatStyle.Flat;
            btnNotGuessed.Font = new Font("Arial", 10, FontStyle.Bold);

            lblWord.ForeColor = System.Drawing.Color.White;
            lblTime.ForeColor = System.Drawing.Color.White;
            lblWord.BackColor = System.Drawing.Color.Transparent;
            lblTime.BackColor = System.Drawing.Color.Transparent;
            lblWord.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTime.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            this.category = category;
            this.playerName = playerName;
            timeLeft = SettingsForm.GameTime;
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            ShowRandomWord();
            UpdateTimeLabel();
        }

        private void ShowRandomWord()
        {
            if (words.ContainsKey(category))
            {
                var wordList = words[category];
                Random rnd = new Random();
                currentWord = wordList[rnd.Next(wordList.Count)];
                lblWord.Text = currentWord;
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            UpdateTimeLabel();

            if (timeLeft <= 0)
            {
                countdownTimer.Stop();
                notGuessedWords.Add(currentWord);
                CloseWordForm();
            }
        }

        private void CloseWordForm()
        {
            GameFinished?.Invoke(new List<string>(guessedWords), new List<string>(notGuessedWords));

            guessedWords.Clear();
            notGuessedWords.Clear();

            this.Close();
        }

        private void UpdateTimeLabel()
        {
            lblTime.Text = $"Осталось времени: {timeLeft} сек";
        }

        private void btnGuessed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentWord))
            {
                guessedWords.Add(currentWord);
                ShowRandomWord();
            }
        }

        private void btnNotGuessed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentWord))
            {
                notGuessedWords.Add(currentWord);
                ShowRandomWord();
            }
        }

        private void WordForm_Load(object sender, EventArgs e)
        {

        }
    }
}