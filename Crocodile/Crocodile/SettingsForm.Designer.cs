namespace Crocodile
{
    partial class SettingsForm
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
            trackBarTime = new TrackBar();
            lblTime = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).BeginInit();
            SuspendLayout();
            // 
            // trackBarTime
            // 
            trackBarTime.Location = new Point(12, 12);
            trackBarTime.Name = "trackBarTime";
            trackBarTime.Size = new Size(158, 45);
            trackBarTime.TabIndex = 0;
            trackBarTime.Scroll += trackBarTime_Scroll;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(12, 60);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 15);
            lblTime.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 99);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lblTime);
            Controls.Add(trackBarTime);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarTime;
        private Label lblTime;
        private Button btnSave;
    }
}