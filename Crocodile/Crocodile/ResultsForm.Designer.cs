namespace Crocodile
{
    partial class ResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstGuessedWords = new ListBox();
            lstNotGuessedWords = new ListBox();
            btnClearResults = new Button();
            lblGuessedWords = new Label();
            lblNotGuessedWords = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lstGuessedWords
            // 
            lstGuessedWords.FormattingEnabled = true;
            lstGuessedWords.ItemHeight = 15;
            lstGuessedWords.Location = new Point(12, 12);
            lstGuessedWords.Name = "lstGuessedWords";
            lstGuessedWords.Size = new Size(120, 94);
            lstGuessedWords.TabIndex = 0;
            // 
            // lstNotGuessedWords
            // 
            lstNotGuessedWords.FormattingEnabled = true;
            lstNotGuessedWords.ItemHeight = 15;
            lstNotGuessedWords.Location = new Point(12, 112);
            lstNotGuessedWords.Name = "lstNotGuessedWords";
            lstNotGuessedWords.Size = new Size(120, 94);
            lstNotGuessedWords.TabIndex = 1;
            // 
            // btnClearResults
            // 
            btnClearResults.Location = new Point(12, 212);
            btnClearResults.Name = "btnClearResults";
            btnClearResults.Size = new Size(177, 28);
            btnClearResults.TabIndex = 2;
            btnClearResults.Text = "Очистить историю";
            btnClearResults.UseVisualStyleBackColor = true;
            btnClearResults.Click += btnClearResults_Click;
            // 
            // lblGuessedWords
            // 
            lblGuessedWords.AutoSize = true;
            lblGuessedWords.Location = new Point(138, 12);
            lblGuessedWords.Name = "lblGuessedWords";
            lblGuessedWords.Size = new Size(51, 15);
            lblGuessedWords.TabIndex = 3;
            lblGuessedWords.Text = "Угадано";
            // 
            // lblNotGuessedWords
            // 
            lblNotGuessedWords.AutoSize = true;
            lblNotGuessedWords.Location = new Point(138, 112);
            lblNotGuessedWords.Name = "lblNotGuessedWords";
            lblNotGuessedWords.Size = new Size(68, 15);
            lblNotGuessedWords.TabIndex = 4;
            lblNotGuessedWords.Text = "Не угадано";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(668, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(lblNotGuessedWords);
            Controls.Add(lblGuessedWords);
            Controls.Add(btnClearResults);
            Controls.Add(lstNotGuessedWords);
            Controls.Add(lstGuessedWords);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGuessedWords;
        private ListBox lstNotGuessedWords;
        private Button btnClearResults;
        private Label lblGuessedWords;
        private Label lblNotGuessedWords;
        private ListBox listBox1;
    }
}