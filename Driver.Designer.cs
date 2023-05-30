namespace AMJJSystem
{
    partial class frmDriver
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
            label1 = new Label();
            DriverInfoTableView = new DataGridView();
            HomeBTN = new Button();
            textBox1 = new TextBox();
            SearchBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)DriverInfoTableView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(531, 429);
            label1.Name = "label1";
            label1.Size = new Size(380, 55);
            label1.TabIndex = 0;
            label1.Text = "Driver Information";
            // 
            // DriverInfoTableView
            // 
            DriverInfoTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DriverInfoTableView.Location = new Point(3, 4);
            DriverInfoTableView.Name = "DriverInfoTableView";
            DriverInfoTableView.RowTemplate.Height = 25;
            DriverInfoTableView.Size = new Size(1438, 422);
            DriverInfoTableView.TabIndex = 20;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(1336, 554);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(105, 31);
            HomeBTN.TabIndex = 90;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(512, 496);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 36);
            textBox1.TabIndex = 91;
            // 
            // SearchBTN
            // 
            SearchBTN.Location = new Point(936, 496);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(105, 36);
            SearchBTN.TabIndex = 90;
            SearchBTN.Text = "SEARCH";
            SearchBTN.UseVisualStyleBackColor = true;
            SearchBTN.Click += HomeBTN_Click;
            // 
            // frmDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 597);
            Controls.Add(textBox1);
            Controls.Add(SearchBTN);
            Controls.Add(HomeBTN);
            Controls.Add(DriverInfoTableView);
            Controls.Add(label1);
            Name = "frmDriver";
            Text = "Driver";
            Load += Driver_Load;
            ((System.ComponentModel.ISupportInitialize)DriverInfoTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DriverInfoTableView;
        private Button HomeBTN;
        private TextBox textBox1;
        private Button SearchBTN;
    }
}