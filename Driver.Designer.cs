namespace AMJJSystem
{
    partial class frmDr
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
            TxtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DriverInfoTableView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 471);
            label1.Name = "label1";
            label1.Size = new Size(380, 55);
            label1.TabIndex = 0;
            label1.Text = "Driver Information";
            // 
            // DriverInfoTableView
            // 
            DriverInfoTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DriverInfoTableView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            DriverInfoTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DriverInfoTableView.Location = new Point(3, 4);
            DriverInfoTableView.Name = "DriverInfoTableView";
            DriverInfoTableView.RowTemplate.Height = 25;
            DriverInfoTableView.Size = new Size(936, 450);
            DriverInfoTableView.TabIndex = 20;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(834, 575);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(105, 31);
            HomeBTN.TabIndex = 90;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSearch.Location = new Point(258, 529);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(414, 33);
            TxtSearch.TabIndex = 91;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 529);
            label2.Name = "label2";
            label2.Size = new Size(105, 27);
            label2.TabIndex = 92;
            label2.Text = "SEARCH";
            // 
            // frmDr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 609);
            Controls.Add(label2);
            Controls.Add(TxtSearch);
            Controls.Add(HomeBTN);
            Controls.Add(DriverInfoTableView);
            Controls.Add(label1);
            Name = "frmDr";
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
        private TextBox TxtSearch;
        private Label label2;
    }
}