﻿namespace AMJJSystem
{
    partial class ReceivedInformation
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
            textBox1 = new TextBox();
            SearchBTN = new Button();
            HomeBTN = new Button();
            DriverInfoTableView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DriverInfoTableView).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(550, 500);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 36);
            textBox1.TabIndex = 96;
            // 
            // SearchBTN
            // 
            SearchBTN.Location = new Point(974, 500);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(105, 36);
            SearchBTN.TabIndex = 94;
            SearchBTN.Text = "SEARCH";
            SearchBTN.UseVisualStyleBackColor = true;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(1376, 594);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(105, 31);
            HomeBTN.TabIndex = 95;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            // 
            // DriverInfoTableView
            // 
            DriverInfoTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DriverInfoTableView.Location = new Point(2, 2);
            DriverInfoTableView.Name = "DriverInfoTableView";
            DriverInfoTableView.RowTemplate.Height = 25;
            DriverInfoTableView.Size = new Size(1520, 422);
            DriverInfoTableView.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(569, 433);
            label1.Name = "label1";
            label1.Size = new Size(432, 55);
            label1.TabIndex = 92;
            label1.Text = "Received Information";
            // 
            // ReceivedInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 637);
            Controls.Add(textBox1);
            Controls.Add(SearchBTN);
            Controls.Add(HomeBTN);
            Controls.Add(DriverInfoTableView);
            Controls.Add(label1);
            Name = "ReceivedInformation";
            Text = "ReceivedInformation";
            ((System.ComponentModel.ISupportInitialize)DriverInfoTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button SearchBTN;
        private Button HomeBTN;
        private DataGridView DriverInfoTableView;
        private Label label1;
    }
}