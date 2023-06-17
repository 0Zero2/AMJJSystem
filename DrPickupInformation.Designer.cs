namespace AMJJSystem
{
    partial class DrPickupInformation
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
            TxtSearch = new TextBox();
            HomeBTN = new Button();
            DriverInfoTableView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DriverInfoTableView).BeginInit();
            SuspendLayout();
            // 
            // TxtSearch
            // 
            TxtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSearch.Location = new Point(528, 505);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(525, 36);
            TxtSearch.TabIndex = 96;
            TxtSearch.Text = "Enter-Company";
            TxtSearch.KeyPress += TxtSearch_KeyPress;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(412, 451);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(86, 51);
            HomeBTN.TabIndex = 95;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            // 
            // DriverInfoTableView
            // 
            DriverInfoTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DriverInfoTableView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            DriverInfoTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DriverInfoTableView.Location = new Point(2, 3);
            DriverInfoTableView.Name = "DriverInfoTableView";
            DriverInfoTableView.RowTemplate.Height = 25;
            DriverInfoTableView.Size = new Size(1419, 442);
            DriverInfoTableView.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(494, 447);
            label1.Name = "label1";
            label1.Size = new Size(579, 55);
            label1.TabIndex = 92;
            label1.Text = "Delivery/Pick-up Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(402, 510);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 97;
            label2.Text = "SEARCH";
            // 
            // DrPickupInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 636);
            Controls.Add(label2);
            Controls.Add(TxtSearch);
            Controls.Add(HomeBTN);
            Controls.Add(DriverInfoTableView);
            Controls.Add(label1);
            Name = "DrPickupInformation";
            Text = "DrPickupInformation";
            Load += DrPickupInformation_Load;
            ((System.ComponentModel.ISupportInitialize)DriverInfoTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSearch;
        private Button HomeBTN;
        private DataGridView DriverInfoTableView;
        private Label label1;
        private Label label2;
    }
}