namespace AMJJSystem
{
    partial class frmReceive
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
            DateAndTime = new DateTimePicker();
            WeightBox = new ComboBox();
            NameItemBox = new ComboBox();
            SizeBox = new ComboBox();
            DeleteBTN = new Button();
            UpdateBTN = new Button();
            RefreshBTN = new Button();
            CreateBTN = new Button();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label12 = new Label();
            label7 = new Label();
            label11 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            TxtRemarks = new TextBox();
            TxtQuantity = new TextBox();
            TxtClientPhone = new TextBox();
            TxtReceivedfrmPhone = new TextBox();
            TxtReceiveby = new TextBox();
            TxtPlate = new TextBox();
            label13 = new Label();
            HomeBTN = new Button();
            ReceiveTableView = new DataGridView();
            ReceivefrmComboBox = new ComboBox();
            NameofClientComboBox = new ComboBox();
            ClearBtn = new Button();
            AddBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)ReceiveTableView).BeginInit();
            SuspendLayout();
            // 
            // DateAndTime
            // 
            DateAndTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateAndTime.Location = new Point(58, 538);
            DateAndTime.Name = "DateAndTime";
            DateAndTime.Size = new Size(239, 26);
            DateAndTime.TabIndex = 85;
            // 
            // WeightBox
            // 
            WeightBox.FormattingEnabled = true;
            WeightBox.Location = new Point(697, 572);
            WeightBox.Name = "WeightBox";
            WeightBox.Size = new Size(137, 23);
            WeightBox.TabIndex = 84;
            // 
            // NameItemBox
            // 
            NameItemBox.FormattingEnabled = true;
            NameItemBox.Location = new Point(697, 427);
            NameItemBox.Name = "NameItemBox";
            NameItemBox.Size = new Size(137, 23);
            NameItemBox.TabIndex = 83;
            // 
            // SizeBox
            // 
            SizeBox.FormattingEnabled = true;
            SizeBox.Location = new Point(697, 528);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(137, 23);
            SizeBox.TabIndex = 82;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(443, 592);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(75, 23);
            DeleteBTN.TabIndex = 80;
            DeleteBTN.Text = "DELETE";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Location = new Point(321, 592);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(84, 23);
            UpdateBTN.TabIndex = 79;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // RefreshBTN
            // 
            RefreshBTN.Location = new Point(206, 592);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(75, 23);
            RefreshBTN.TabIndex = 78;
            RefreshBTN.Text = "REFRESH";
            RefreshBTN.UseVisualStyleBackColor = true;
            RefreshBTN.Click += RefreshBTN_Click;
            // 
            // CreateBTN
            // 
            CreateBTN.Location = new Point(95, 592);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(75, 23);
            CreateBTN.TabIndex = 77;
            CreateBTN.Text = "CREATE";
            CreateBTN.UseVisualStyleBackColor = true;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 515);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 75;
            label10.Text = "Date and Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(697, 510);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 74;
            label8.Text = "Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(697, 554);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 73;
            label9.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(871, 395);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 72;
            label6.Text = "Remarks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 456);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 76;
            label4.Text = "Received By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 456);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 71;
            label2.Text = "Name of Client Company";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(697, 401);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 70;
            label12.Text = "Name of Item";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(697, 456);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 69;
            label7.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(508, 456);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 68;
            label11.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 402);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 67;
            label5.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 402);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 66;
            label3.Text = "Plate No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 402);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 65;
            label1.Text = "Received from";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Location = new Point(871, 413);
            TxtRemarks.Multiline = true;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(264, 202);
            TxtRemarks.TabIndex = 63;
            // 
            // TxtQuantity
            // 
            TxtQuantity.Location = new Point(697, 474);
            TxtQuantity.Multiline = true;
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(137, 31);
            TxtQuantity.TabIndex = 62;
            // 
            // TxtClientPhone
            // 
            TxtClientPhone.Location = new Point(499, 474);
            TxtClientPhone.Multiline = true;
            TxtClientPhone.Name = "TxtClientPhone";
            TxtClientPhone.Size = new Size(158, 31);
            TxtClientPhone.TabIndex = 61;
            // 
            // TxtReceivedfrmPhone
            // 
            TxtReceivedfrmPhone.Location = new Point(432, 420);
            TxtReceivedfrmPhone.Multiline = true;
            TxtReceivedfrmPhone.Name = "TxtReceivedfrmPhone";
            TxtReceivedfrmPhone.Size = new Size(158, 31);
            TxtReceivedfrmPhone.TabIndex = 60;
            // 
            // TxtReceiveby
            // 
            TxtReceiveby.Location = new Point(58, 474);
            TxtReceiveby.Multiline = true;
            TxtReceiveby.Name = "TxtReceiveby";
            TxtReceiveby.Size = new Size(204, 31);
            TxtReceiveby.TabIndex = 59;
            TxtReceiveby.Text = "AMJJ LOGISTICS";
            // 
            // TxtPlate
            // 
            TxtPlate.Location = new Point(268, 420);
            TxtPlate.Multiline = true;
            TxtPlate.Name = "TxtPlate";
            TxtPlate.Size = new Size(158, 31);
            TxtPlate.TabIndex = 58;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 42F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(95, 337);
            label13.Name = "label13";
            label13.Size = new Size(975, 64);
            label13.TabIndex = 86;
            label13.Text = "AMJJ RECEIVE LOGISTICS RECORDS";
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(953, 629);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(105, 31);
            HomeBTN.TabIndex = 89;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // ReceiveTableView
            // 
            ReceiveTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReceiveTableView.Location = new Point(3, 3);
            ReceiveTableView.Margin = new Padding(3, 2, 3, 2);
            ReceiveTableView.Name = "ReceiveTableView";
            ReceiveTableView.RowHeadersWidth = 51;
            ReceiveTableView.RowTemplate.Height = 29;
            ReceiveTableView.Size = new Size(1183, 334);
            ReceiveTableView.TabIndex = 90;
            ReceiveTableView.CellContentClick += ReceiveTableView_CellContentClick;
            // 
            // ReceivefrmComboBox
            // 
            ReceivefrmComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReceivefrmComboBox.FormattingEnabled = true;
            ReceivefrmComboBox.Location = new Point(58, 420);
            ReceivefrmComboBox.Name = "ReceivefrmComboBox";
            ReceivefrmComboBox.Size = new Size(204, 28);
            ReceivefrmComboBox.TabIndex = 91;
            // 
            // NameofClientComboBox
            // 
            NameofClientComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameofClientComboBox.FormattingEnabled = true;
            NameofClientComboBox.Location = new Point(270, 477);
            NameofClientComboBox.Name = "NameofClientComboBox";
            NameofClientComboBox.Size = new Size(223, 28);
            NameofClientComboBox.TabIndex = 92;
            NameofClientComboBox.SelectedIndexChanged += NameofClientComboBox_SelectedIndexChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(697, 637);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 23);
            ClearBtn.TabIndex = 93;
            ClearBtn.Text = "CLEAR";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(697, 608);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(75, 23);
            AddBTN.TabIndex = 94;
            AddBTN.Text = "ADD";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // frmReceive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 672);
            Controls.Add(AddBTN);
            Controls.Add(ClearBtn);
            Controls.Add(NameofClientComboBox);
            Controls.Add(ReceivefrmComboBox);
            Controls.Add(ReceiveTableView);
            Controls.Add(HomeBTN);
            Controls.Add(label13);
            Controls.Add(DateAndTime);
            Controls.Add(WeightBox);
            Controls.Add(NameItemBox);
            Controls.Add(SizeBox);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBTN);
            Controls.Add(RefreshBTN);
            Controls.Add(CreateBTN);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(TxtRemarks);
            Controls.Add(TxtQuantity);
            Controls.Add(TxtClientPhone);
            Controls.Add(TxtReceivedfrmPhone);
            Controls.Add(TxtReceiveby);
            Controls.Add(TxtPlate);
            Name = "frmReceive";
            Text = "Form5";
            Load += frmReceive_Load;
            ((System.ComponentModel.ISupportInitialize)ReceiveTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker DateAndTime;
        private ComboBox WeightBox;
        private ComboBox NameItemBox;
        private ComboBox SizeBox;
        private Button DeleteBTN;
        private Button UpdateBTN;
        private Button RefreshBTN;
        private Button CreateBTN;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label12;
        private Label label7;
        private Label label11;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox TxtRemarks;
        private TextBox TxtQuantity;
        private TextBox TxtClientPhone;
        private TextBox TxtReceivedfrmPhone;
        private TextBox TxtReceiveby;
        private TextBox TxtPlate;
        private Label label13;
        private Button button8;
        private Button button7;
        private Button HomeBTN;
        private DataGridView ReceiveTableView;
        private ComboBox ReceivefrmComboBox;
        private ComboBox NameofClientComboBox;
        private Button ClearBtn;
        private Button AddBTN;
    }
}