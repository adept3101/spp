namespace Crocodile
{
    partial class GameForm
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
            btnSports = new Button();
            btnAnimals = new Button();
            btnNature = new Button();
            SuspendLayout();
            // 
            // btnSports
            // 
            btnSports.Location = new Point(330, 160);
            btnSports.Name = "btnSports";
            btnSports.Size = new Size(113, 30);
            btnSports.TabIndex = 0;
            btnSports.Text = "Спорт";
            btnSports.UseVisualStyleBackColor = true;
            btnSports.Click += btnSports_Click;
            // 
            // btnAnimals
            // 
            btnAnimals.Location = new Point(330, 195);
            btnAnimals.Name = "btnAnimals";
            btnAnimals.Size = new Size(113, 30);
            btnAnimals.TabIndex = 1;
            btnAnimals.Text = "Животные";
            btnAnimals.UseVisualStyleBackColor = true;
            btnAnimals.Click += btnAnimals_Click;
            // 
            // btnNature
            // 
            btnNature.Location = new Point(330, 230);
            btnNature.Name = "btnNature";
            btnNature.Size = new Size(113, 30);
            btnNature.TabIndex = 2;
            btnNature.Text = "Природа";
            btnNature.UseVisualStyleBackColor = true;
            btnNature.Click += btnNature_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNature);
            Controls.Add(btnAnimals);
            Controls.Add(btnSports);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSports;
        private Button btnAnimals;
        private Button btnNature;
    }
}