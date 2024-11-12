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
    public partial class GameForm : Form
    {
       

  

        public GameForm()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            // Настроим кнопки категорий
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
        

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            OpenWordForm("Спорт");
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            OpenWordForm("Природа");
        }

        private void btnNature_Click(object sender, EventArgs e)
        {
            OpenWordForm("Животные");
        }

        private void OpenWordForm(string category)
        {
            WordForm wordForm = new WordForm(category);
            wordForm.ShowDialog();
        }
       
    }
}
