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
    public partial class EnterNameForm : Form
    {
        public string PlayerName { get; private set; }

        public EnterNameForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#212121");

            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#424242");
            button1.ForeColor = System.Drawing.Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void EnterNameForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя игрока.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlayerName = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
