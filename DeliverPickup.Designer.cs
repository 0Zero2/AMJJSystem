namespace AMJJSystem
{
    partial class frmDeliveryPickup
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
            SizeBox = new ComboBox();
            DeleteBTN = new Button();
            UpdateBTN = new Button();
            CreateBTN = new Button();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            label11 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            TxtRemarks = new TextBox();
            TxtQuantity = new TextBox();
            TxtCompanynumber = new TextBox();
            TxtDriverPhonenumber = new TextBox();
            TxtContact = new TextBox();
            TxtPlate = new TextBox();
            label12 = new Label();
            NameItemBox = new ComboBox();
            label13 = new Label();
            RefreshBTN = new Button();
            DeliveryTableView = new DataGridView();
            TxtAddress = new TextBox();
            label14 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            HomeBTN = new Button();
            ClientCompComboBox = new ComboBox();
            DriverComboBox = new ComboBox();
            DPlistView = new ListView();
            AddBTN = new Button();
            ClearBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)DeliveryTableView).BeginInit();
            SuspendLayout();
            // 
            // DateAndTime
            // 
            DateAndTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateAndTime.ImeMode = ImeMode.Alpha;
            DateAndTime.Location = new Point(490, 578);
            DateAndTime.Name = "DateAndTime";
            DateAndTime.Size = new Size(239, 26);
            DateAndTime.TabIndex = 56;
            DateAndTime.Value = new DateTime(2023, 5, 20, 8, 38, 19, 0);
            // 
            // WeightBox
            // 
            WeightBox.FormattingEnabled = true;
            WeightBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            WeightBox.Location = new Point(964, 576);
            WeightBox.Name = "WeightBox";
            WeightBox.Size = new Size(137, 23);
            WeightBox.TabIndex = 55;
            // 
            // SizeBox
            // 
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            SizeBox.Location = new Point(964, 532);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(137, 23);
            SizeBox.TabIndex = 54;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(741, 637);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(75, 23);
            DeleteBTN.TabIndex = 52;
            DeleteBTN.Text = "DELETE";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Location = new Point(619, 637);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(84, 23);
            UpdateBTN.TabIndex = 51;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // CreateBTN
            // 
            CreateBTN.Location = new Point(393, 637);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(75, 23);
            CreateBTN.TabIndex = 50;
            CreateBTN.Text = "CREATE";
            CreateBTN.UseVisualStyleBackColor = true;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(490, 557);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 48;
            label10.Text = "Date and Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(964, 514);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 47;
            label8.Text = "Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(964, 558);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 46;
            label9.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1118, 620);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 45;
            label6.Text = "Remarks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 501);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 49;
            label4.Text = "Contact Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 501);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 44;
            label2.Text = "Name of Client Company";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(964, 460);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 43;
            label7.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(579, 501);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 42;
            label11.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 447);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 41;
            label5.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 447);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 40;
            label3.Text = "Plate No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 447);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 39;
            label1.Text = "Name of Driver";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Location = new Point(1118, 638);
            TxtRemarks.Multiline = true;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(294, 31);
            TxtRemarks.TabIndex = 37;
            // 
            // TxtQuantity
            // 
            TxtQuantity.Location = new Point(964, 478);
            TxtQuantity.Multiline = true;
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(137, 31);
            TxtQuantity.TabIndex = 36;
            // 
            // TxtCompanynumber
            // 
            TxtCompanynumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCompanynumber.Location = new Point(579, 519);
            TxtCompanynumber.Multiline = true;
            TxtCompanynumber.Name = "TxtCompanynumber";
            TxtCompanynumber.Size = new Size(158, 31);
            TxtCompanynumber.TabIndex = 35;
            // 
            // TxtDriverPhonenumber
            // 
            TxtDriverPhonenumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDriverPhonenumber.Location = new Point(407, 465);
            TxtDriverPhonenumber.Multiline = true;
            TxtDriverPhonenumber.Name = "TxtDriverPhonenumber";
            TxtDriverPhonenumber.Size = new Size(166, 31);
            TxtDriverPhonenumber.TabIndex = 34;
            // 
            // TxtContact
            // 
            TxtContact.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtContact.Location = new Point(407, 519);
            TxtContact.Multiline = true;
            TxtContact.Name = "TxtContact";
            TxtContact.Size = new Size(166, 31);
            TxtContact.TabIndex = 33;
            // 
            // TxtPlate
            // 
            TxtPlate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPlate.Location = new Point(579, 465);
            TxtPlate.Multiline = true;
            TxtPlate.Name = "TxtPlate";
            TxtPlate.Size = new Size(158, 31);
            TxtPlate.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(964, 405);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 43;
            label12.Text = "Name of Item";
            // 
            // NameItemBox
            // 
            NameItemBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameItemBox.FormattingEnabled = true;
            NameItemBox.Items.AddRange(new object[] { "Nihonweld", "TEST", "A", "C", "V", "B", "G" });
            NameItemBox.Location = new Point(964, 431);
            NameItemBox.Name = "NameItemBox";
            NameItemBox.Size = new Size(137, 27);
            NameItemBox.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(210, 337);
            label13.Name = "label13";
            label13.Size = new Size(1048, 55);
            label13.TabIndex = 39;
            label13.Text = "AMJJ DELIVERY/PICK-UP LOGISTICS RECORD";
            // 
            // RefreshBTN
            // 
            RefreshBTN.Location = new Point(504, 637);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(75, 23);
            RefreshBTN.TabIndex = 50;
            RefreshBTN.Text = "REFRESH";
            RefreshBTN.UseVisualStyleBackColor = true;
            RefreshBTN.Click += RefreshBTN_Click;
            // 
            // DeliveryTableView
            // 
            DeliveryTableView.AllowUserToAddRows = false;
            DeliveryTableView.AllowUserToDeleteRows = false;
            DeliveryTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeliveryTableView.Location = new Point(12, 3);
            DeliveryTableView.Margin = new Padding(3, 2, 3, 2);
            DeliveryTableView.Name = "DeliveryTableView";
            DeliveryTableView.RowHeadersWidth = 51;
            DeliveryTableView.RowTemplate.Height = 29;
            DeliveryTableView.Size = new Size(1424, 326);
            DeliveryTableView.TabIndex = 57;
            DeliveryTableView.CellClick += DeliveryTableView_CellClick;
            // 
            // TxtAddress
            // 
            TxtAddress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAddress.Location = new Point(197, 573);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(271, 31);
            TxtAddress.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(197, 555);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 49;
            label14.Text = "Address";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(307, 410);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 58;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(197, 410);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 58;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton1";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(1327, 345);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(75, 23);
            HomeBTN.TabIndex = 59;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // ClientCompComboBox
            // 
            ClientCompComboBox.FormattingEnabled = true;
            ClientCompComboBox.Location = new Point(197, 527);
            ClientCompComboBox.Name = "ClientCompComboBox";
            ClientCompComboBox.Size = new Size(204, 23);
            ClientCompComboBox.TabIndex = 60;
            ClientCompComboBox.SelectedIndexChanged += ClientCompComboBox_SelectedIndexChanged;
            // 
            // DriverComboBox
            // 
            DriverComboBox.FormattingEnabled = true;
            DriverComboBox.Location = new Point(197, 468);
            DriverComboBox.Name = "DriverComboBox";
            DriverComboBox.Size = new Size(204, 23);
            DriverComboBox.TabIndex = 60;
            // 
            // DPlistView
            // 
            DPlistView.Location = new Point(1118, 399);
            DPlistView.Name = "DPlistView";
            DPlistView.Size = new Size(294, 214);
            DPlistView.TabIndex = 61;
            DPlistView.UseCompatibleStateImageBehavior = false;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(988, 605);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(75, 23);
            AddBTN.TabIndex = 52;
            AddBTN.Text = "ADD";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // ClearBTN
            // 
            ClearBTN.Location = new Point(988, 646);
            ClearBTN.Name = "ClearBTN";
            ClearBTN.Size = new Size(75, 23);
            ClearBTN.TabIndex = 52;
            ClearBTN.Text = "CLEAR";
            ClearBTN.UseVisualStyleBackColor = true;
            ClearBTN.Click += ClearBTN_Click;
            // 
            // frmDeliveryPickup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1441, 681);
            Controls.Add(DPlistView);
            Controls.Add(DriverComboBox);
            Controls.Add(ClientCompComboBox);
            Controls.Add(HomeBTN);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(DeliveryTableView);
            Controls.Add(DateAndTime);
            Controls.Add(WeightBox);
            Controls.Add(NameItemBox);
            Controls.Add(SizeBox);
            Controls.Add(ClearBTN);
            Controls.Add(AddBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBTN);
            Controls.Add(RefreshBTN);
            Controls.Add(CreateBTN);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label14);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(TxtRemarks);
            Controls.Add(TxtQuantity);
            Controls.Add(TxtCompanynumber);
            Controls.Add(TxtDriverPhonenumber);
            Controls.Add(TxtAddress);
            Controls.Add(TxtContact);
            Controls.Add(TxtPlate);
            Name = "frmDeliveryPickup";
            Text = " ";
            Load += frmDelivery_Load;
            ((System.ComponentModel.ISupportInitialize)DeliveryTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker DateAndTime;
        private ComboBox WeightBox;
        private ComboBox SizeBox;
        private Button DeleteBTN;
        private Button UpdateBTN;
        private Button CreateBTN;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label7;
        private Label label11;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox TxtRemarks;
        private TextBox TxtQuantity;
        private TextBox TxtCompanynumber;
        private TextBox TxtDriverPhonenumber;
        private TextBox TxtContact;
        private TextBox TxtPlate;
        private Label label12;
        private ComboBox NameItemBox;
        private Label label13;
        private Button RefreshBTN;
        private DataGridView DeliveryTableView;
        private TextBox TxtAddress;
        private Label label14;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button HomeBTN;
        private ComboBox ClientCompComboBox;
        private ComboBox DriverComboBox;
        private ListView DPlistView;
        private Button AddBTN;
        private Button ClearBTN;
    }
}