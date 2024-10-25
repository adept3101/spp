namespace Mainlb4
{
    partial class Form3
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
            labelRate = new Label();
            comboBoxFrom = new ComboBox();
            comboBoxTo = new ComboBox();
            SuspendLayout();
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Location = new Point(12, 80);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(32, 15);
            labelRate.TabIndex = 0;
            labelRate.Text = "label";
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(12, 12);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(121, 23);
            comboBoxFrom.TabIndex = 1;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(12, 41);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(121, 23);
            comboBoxTo.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxTo);
            Controls.Add(comboBoxFrom);
            Controls.Add(labelRate);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRate;
        private ComboBox comboBoxFrom;
        private ComboBox comboBoxTo;
    }
}