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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryPickup));
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
            PuRadioBTN = new RadioButton();
            DrRadioBTN = new RadioButton();
            HomeBTN = new Button();
            ClientCompComboBox = new ComboBox();
            DriverComboBox = new ComboBox();
            DPlistView = new ListView();
            AddBTN = new Button();
            panel1 = new Panel();
            label17 = new Label();
            panel2 = new Panel();
            label16 = new Label();
            panel3 = new Panel();
            label15 = new Label();
            panel4 = new Panel();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)DeliveryTableView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // DateAndTime
            // 
            DateAndTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateAndTime.ImeMode = ImeMode.On;
            DateAndTime.Location = new Point(511, 426);
            DateAndTime.Name = "DateAndTime";
            DateAndTime.Size = new Size(291, 26);
            DateAndTime.TabIndex = 56;
            DateAndTime.Value = new DateTime(2023, 5, 20, 8, 38, 19, 0);
            // 
            // WeightBox
            // 
            WeightBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WeightBox.FormattingEnabled = true;
            WeightBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            WeightBox.Location = new Point(134, 164);
            WeightBox.Name = "WeightBox";
            WeightBox.Size = new Size(124, 27);
            WeightBox.TabIndex = 55;
            // 
            // SizeBox
            // 
            SizeBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            SizeBox.Location = new Point(4, 164);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(125, 27);
            SizeBox.TabIndex = 54;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBTN.Location = new Point(590, 616);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(112, 38);
            DeleteBTN.TabIndex = 52;
            DeleteBTN.Text = "DELETE";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBTN.Location = new Point(429, 619);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(121, 38);
            UpdateBTN.TabIndex = 51;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // CreateBTN
            // 
            CreateBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBTN.Location = new Point(109, 619);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(127, 38);
            CreateBTN.TabIndex = 50;
            CreateBTN.Text = "CREATE";
            CreateBTN.UseVisualStyleBackColor = true;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(582, 394);
            label10.Name = "label10";
            label10.Size = new Size(153, 27);
            label10.TabIndex = 48;
            label10.Text = "Date and Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(4, 146);
            label8.Name = "label8";
            label8.Size = new Size(34, 19);
            label8.TabIndex = 47;
            label8.Text = "Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(134, 143);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 46;
            label9.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(808, 616);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 45;
            label6.Text = "Remarks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 106);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 49;
            label4.Text = "Contact Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(164, 19);
            label2.TabIndex = 44;
            label2.Text = "Name of Client Company";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(4, 93);
            label7.Name = "label7";
            label7.Size = new Size(60, 19);
            label7.TabIndex = 43;
            label7.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(14, 152);
            label11.Name = "label11";
            label11.Size = new Size(96, 19);
            label11.TabIndex = 42;
            label11.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 108);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 41;
            label5.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 40;
            label3.Text = "Plate No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 39;
            label1.Text = "Name of Driver";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRemarks.Location = new Point(808, 638);
            TxtRemarks.Multiline = true;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(266, 31);
            TxtRemarks.TabIndex = 37;
            // 
            // TxtQuantity
            // 
            TxtQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtQuantity.Location = new Point(3, 119);
            TxtQuantity.Multiline = true;
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(255, 23);
            TxtQuantity.TabIndex = 36;
            // 
            // TxtCompanynumber
            // 
            TxtCompanynumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCompanynumber.Location = new Point(14, 174);
            TxtCompanynumber.Multiline = true;
            TxtCompanynumber.Name = "TxtCompanynumber";
            TxtCompanynumber.Size = new Size(204, 25);
            TxtCompanynumber.TabIndex = 35;
            // 
            // TxtDriverPhonenumber
            // 
            TxtDriverPhonenumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDriverPhonenumber.Location = new Point(6, 126);
            TxtDriverPhonenumber.Multiline = true;
            TxtDriverPhonenumber.Name = "TxtDriverPhonenumber";
            TxtDriverPhonenumber.Size = new Size(166, 25);
            TxtDriverPhonenumber.TabIndex = 34;
            // 
            // TxtContact
            // 
            TxtContact.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtContact.Location = new Point(14, 125);
            TxtContact.Multiline = true;
            TxtContact.Name = "TxtContact";
            TxtContact.Size = new Size(204, 24);
            TxtContact.TabIndex = 33;
            // 
            // TxtPlate
            // 
            TxtPlate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPlate.Location = new Point(6, 172);
            TxtPlate.Multiline = true;
            TxtPlate.Name = "TxtPlate";
            TxtPlate.Size = new Size(158, 26);
            TxtPlate.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 41);
            label12.Name = "label12";
            label12.Size = new Size(93, 19);
            label12.TabIndex = 43;
            label12.Text = "Name of Item";
            // 
            // NameItemBox
            // 
            NameItemBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameItemBox.FormattingEnabled = true;
            NameItemBox.Items.AddRange(new object[] { "Nihonweld", "TEST", "A", "C", "V", "B", "G" });
            NameItemBox.Location = new Point(4, 63);
            NameItemBox.Name = "NameItemBox";
            NameItemBox.Size = new Size(254, 27);
            NameItemBox.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(225, 296);
            label13.Name = "label13";
            label13.Size = new Size(1048, 55);
            label13.TabIndex = 39;
            label13.Text = "AMJJ DELIVERY/PICK-UP LOGISTICS RECORD";
            // 
            // RefreshBTN
            // 
            RefreshBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshBTN.Location = new Point(269, 619);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(120, 38);
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
            DeliveryTableView.Location = new Point(2, 3);
            DeliveryTableView.Margin = new Padding(3, 2, 3, 2);
            DeliveryTableView.Name = "DeliveryTableView";
            DeliveryTableView.RowHeadersWidth = 51;
            DeliveryTableView.RowTemplate.Height = 29;
            DeliveryTableView.Size = new Size(1435, 291);
            DeliveryTableView.TabIndex = 57;
            DeliveryTableView.CellClick += DeliveryTableView_CellClick;
            // 
            // TxtAddress
            // 
            TxtAddress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAddress.Location = new Point(511, 490);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(291, 26);
            TxtAddress.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(612, 460);
            label14.Name = "label14";
            label14.Size = new Size(90, 27);
            label14.TabIndex = 49;
            label14.Text = "Address";
            // 
            // PuRadioBTN
            // 
            PuRadioBTN.AutoSize = true;
            PuRadioBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PuRadioBTN.Location = new Point(98, 39);
            PuRadioBTN.Name = "PuRadioBTN";
            PuRadioBTN.Size = new Size(79, 23);
            PuRadioBTN.TabIndex = 58;
            PuRadioBTN.TabStop = true;
            PuRadioBTN.Text = "Pick-Up";
            PuRadioBTN.UseVisualStyleBackColor = true;
            // 
            // DrRadioBTN
            // 
            DrRadioBTN.AutoSize = true;
            DrRadioBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DrRadioBTN.Location = new Point(15, 38);
            DrRadioBTN.Name = "DrRadioBTN";
            DrRadioBTN.Size = new Size(77, 23);
            DrRadioBTN.TabIndex = 58;
            DrRadioBTN.TabStop = true;
            DrRadioBTN.Text = "Delivery";
            DrRadioBTN.UseVisualStyleBackColor = true;
            // 
            // HomeBTN
            // 
            HomeBTN.BackgroundImage = (Image)resources.GetObject("HomeBTN.BackgroundImage");
            HomeBTN.BackgroundImageLayout = ImageLayout.Zoom;
            HomeBTN.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            HomeBTN.Location = new Point(153, 296);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(66, 55);
            HomeBTN.TabIndex = 59;
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // ClientCompComboBox
            // 
            ClientCompComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientCompComboBox.FormattingEnabled = true;
            ClientCompComboBox.Location = new Point(14, 77);
            ClientCompComboBox.Name = "ClientCompComboBox";
            ClientCompComboBox.Size = new Size(204, 27);
            ClientCompComboBox.TabIndex = 60;
            ClientCompComboBox.SelectedIndexChanged += ClientCompComboBox_SelectedIndexChanged;
            // 
            // DriverComboBox
            // 
            DriverComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DriverComboBox.FormattingEnabled = true;
            DriverComboBox.Location = new Point(6, 79);
            DriverComboBox.Name = "DriverComboBox";
            DriverComboBox.Size = new Size(204, 27);
            DriverComboBox.TabIndex = 60;
            // 
            // DPlistView
            // 
            DPlistView.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DPlistView.FullRowSelect = true;
            DPlistView.GridLines = true;
            DPlistView.Location = new Point(1076, 373);
            DPlistView.Margin = new Padding(4);
            DPlistView.Name = "DPlistView";
            DPlistView.Size = new Size(349, 241);
            DPlistView.TabIndex = 61;
            DPlistView.UseCompatibleStateImageBehavior = false;
            // 
            // AddBTN
            // 
            AddBTN.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddBTN.Location = new Point(92, 200);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(75, 32);
            AddBTN.TabIndex = 52;
            AddBTN.Text = "ADD";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label17);
            panel1.Controls.Add(TxtDriverPhonenumber);
            panel1.Controls.Add(TxtPlate);
            panel1.Controls.Add(DriverComboBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(279, 375);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 207);
            panel1.TabIndex = 62;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(16, 16);
            label17.Name = "label17";
            label17.Size = new Size(194, 27);
            label17.TabIndex = 59;
            label17.Text = "Driver Information";
            // 
            // panel2
            // 
            panel2.Controls.Add(label16);
            panel2.Controls.Add(ClientCompComboBox);
            panel2.Controls.Add(TxtContact);
            panel2.Controls.Add(TxtCompanynumber);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(25, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 208);
            panel2.TabIndex = 63;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(9, 20);
            label16.Name = "label16";
            label16.Size = new Size(225, 27);
            label16.TabIndex = 59;
            label16.Text = "Company Information";
            // 
            // panel3
            // 
            panel3.Controls.Add(label15);
            panel3.Controls.Add(PuRadioBTN);
            panel3.Controls.Add(DrRadioBTN);
            panel3.Location = new Point(570, 522);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 71);
            panel3.TabIndex = 64;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(57, 8);
            label15.Name = "label15";
            label15.Size = new Size(70, 27);
            label15.TabIndex = 59;
            label15.Text = "Status";
            // 
            // panel4
            // 
            panel4.Controls.Add(label18);
            panel4.Controls.Add(NameItemBox);
            panel4.Controls.Add(TxtQuantity);
            panel4.Controls.Add(WeightBox);
            panel4.Controls.Add(SizeBox);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(AddBTN);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(808, 373);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 241);
            panel4.TabIndex = 65;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(54, 11);
            label18.Name = "label18";
            label18.Size = new Size(176, 27);
            label18.TabIndex = 59;
            label18.Text = "Item Information";
            // 
            // frmDeliveryPickup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1442, 674);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DPlistView);
            Controls.Add(HomeBTN);
            Controls.Add(DeliveryTableView);
            Controls.Add(DateAndTime);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBTN);
            Controls.Add(RefreshBTN);
            Controls.Add(CreateBTN);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(TxtRemarks);
            Controls.Add(TxtAddress);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDeliveryPickup";
            Text = " Delivery/Pick-Up Logistics Record System";
            Load += frmDelivery_Load;
            ((System.ComponentModel.ISupportInitialize)DeliveryTableView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private RadioButton PuRadioBTN;
        private RadioButton DrRadioBTN;
        private Button HomeBTN;
        private ComboBox ClientCompComboBox;
        private ComboBox DriverComboBox;
        private ListView DPlistView;
        private Button AddBTN;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label15;
        private Panel panel4;
        private Label label17;
        private Label label16;
        private Label label18;
    }
}