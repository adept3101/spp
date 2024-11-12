namespace Crocodile
{
    partial class WordForm
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
            components = new System.ComponentModel.Container();
            lblWord = new Label();
            btnGuessed = new Button();
            btnNotGuessed = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Location = new Point(337, 175);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(38, 15);
            lblWord.TabIndex = 0;
            lblWord.Text = "label1";
            // 
            // btnGuessed
            // 
            btnGuessed.Location = new Point(325, 230);
            btnGuessed.Name = "btnGuessed";
            btnGuessed.Size = new Size(100, 25);
            btnGuessed.TabIndex = 1;
            btnGuessed.Text = "Угадано";
            btnGuessed.UseVisualStyleBackColor = true;
            btnGuessed.Click += btnGuessed_Click;
            // 
            // btnNotGuessed
            // 
            btnNotGuessed.Location = new Point(430, 230);
            btnNotGuessed.Name = "btnNotGuessed";
            btnNotGuessed.Size = new Size(100, 25);
            btnNotGuessed.TabIndex = 2;
            btnNotGuessed.Text = "Не угадано";
            btnNotGuessed.UseVisualStyleBackColor = true;
            btnNotGuessed.Click += btnNotGuessed_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(337, 201);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(42, 15);
            lblTime.TabIndex = 3;
            lblTime.Text = "label1t";
            // 
            // WordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTime);
            Controls.Add(btnNotGuessed);
            Controls.Add(btnGuessed);
            Controls.Add(lblWord);
            Name = "WordForm";
            Text = "WordForm";
            Load += WordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private Button btnGuessed;
        private Button btnNotGuessed;
        private System.Windows.Forms.Timer Timer;
        private Label lblTime;

    }
}