﻿namespace Mainlb4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxFrom = new ComboBox();
            comboBoxTo = new ComboBox();
            textBoxAmount = new TextBox();
            buttonResult = new Button();
            buttonCurse = new Button();
            SuspendLayout();
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(141, 27);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(121, 23);
            comboBoxFrom.TabIndex = 0;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(141, 56);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(121, 23);
            comboBoxTo.TabIndex = 1;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(35, 27);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 2;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(60, 139);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(75, 23);
            buttonResult.TabIndex = 3;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonCurse
            // 
            buttonCurse.Location = new Point(141, 139);
            buttonCurse.Name = "buttonCurse";
            buttonCurse.Size = new Size(75, 23);
            buttonCurse.TabIndex = 4;
            buttonCurse.Text = "Курс";
            buttonCurse.UseVisualStyleBackColor = true;
            buttonCurse.Click += buttonCurse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCurse);
            Controls.Add(buttonResult);
            Controls.Add(textBoxAmount);
            Controls.Add(comboBoxTo);
            Controls.Add(comboBoxFrom);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFrom;
        private ComboBox comboBoxTo;
        private TextBox textBoxAmount;
        private Button buttonResult;
        private Button buttonCurse;
    }
}
