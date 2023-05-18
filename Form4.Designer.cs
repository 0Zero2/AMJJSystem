namespace AMJJSystem
{
    partial class frmDelivery
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
            DeleteAllBTN = new Button();
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
            TxtCompany = new TextBox();
            TxtDriver = new TextBox();
            label12 = new Label();
            NameItemBox = new ComboBox();
            label13 = new Label();
            ReadBTN = new Button();
            HomeBTN = new Button();
            ReceiveBTN = new Button();
            PickupBTN = new Button();
            DeliveryTableView = new DataGridView();
            TxtAddress = new TextBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)DeliveryTableView).BeginInit();
            SuspendLayout();
            // 
            // DateAndTime
            // 
            DateAndTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateAndTime.Location = new Point(339, 544);
            DateAndTime.Name = "DateAndTime";
            DateAndTime.Size = new Size(239, 26);
            DateAndTime.TabIndex = 56;
            DateAndTime.Value = new DateTime(2023, 5, 18, 19, 40, 35, 0);
            // 
            // WeightBox
            // 
            WeightBox.FormattingEnabled = true;
            WeightBox.Items.AddRange(new object[] { "dawd", "gvqaw", "gar", "fsef", "hrtsef", "aef", "awd" });
            WeightBox.Location = new Point(685, 580);
            WeightBox.Name = "WeightBox";
            WeightBox.Size = new Size(137, 23);
            WeightBox.TabIndex = 55;
            // 
            // SizeBox
            // 
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "cwad", "awd", "afw", "awd", "awd" });
            SizeBox.Location = new Point(685, 536);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(137, 23);
            SizeBox.TabIndex = 54;
            // 
            // DeleteAllBTN
            // 
            DeleteAllBTN.Location = new Point(533, 590);
            DeleteAllBTN.Name = "DeleteAllBTN";
            DeleteAllBTN.Size = new Size(87, 23);
            DeleteAllBTN.TabIndex = 53;
            DeleteAllBTN.Text = "DELETE ALL";
            DeleteAllBTN.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(420, 590);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(75, 23);
            DeleteBTN.TabIndex = 52;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Location = new Point(298, 590);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(84, 23);
            UpdateBTN.TabIndex = 51;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // CreateBTN
            // 
            CreateBTN.Location = new Point(72, 590);
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
            label10.Location = new Point(339, 520);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 48;
            label10.Text = "Date and Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(685, 518);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 47;
            label8.Text = "Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(685, 562);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 46;
            label9.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(859, 403);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 45;
            label6.Text = "Remarks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 464);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 49;
            label4.Text = "Contact Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 464);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 44;
            label2.Text = "Name of Client Company";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(685, 464);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 43;
            label7.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(496, 464);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 42;
            label11.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 410);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 41;
            label5.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 410);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 40;
            label3.Text = "Plate No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 410);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 39;
            label1.Text = "Name of Driver";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Location = new Point(859, 421);
            TxtRemarks.Multiline = true;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(264, 202);
            TxtRemarks.TabIndex = 37;
            // 
            // TxtQuantity
            // 
            TxtQuantity.Location = new Point(685, 482);
            TxtQuantity.Multiline = true;
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(137, 31);
            TxtQuantity.TabIndex = 36;
            // 
            // TxtCompanynumber
            // 
            TxtCompanynumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCompanynumber.Location = new Point(496, 482);
            TxtCompanynumber.Multiline = true;
            TxtCompanynumber.Name = "TxtCompanynumber";
            TxtCompanynumber.Size = new Size(158, 31);
            TxtCompanynumber.TabIndex = 35;
            // 
            // TxtDriverPhonenumber
            // 
            TxtDriverPhonenumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDriverPhonenumber.Location = new Point(420, 428);
            TxtDriverPhonenumber.Multiline = true;
            TxtDriverPhonenumber.Name = "TxtDriverPhonenumber";
            TxtDriverPhonenumber.Size = new Size(158, 31);
            TxtDriverPhonenumber.TabIndex = 34;
            // 
            // TxtContact
            // 
            TxtContact.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtContact.Location = new Point(286, 482);
            TxtContact.Multiline = true;
            TxtContact.Name = "TxtContact";
            TxtContact.Size = new Size(204, 31);
            TxtContact.TabIndex = 33;
            // 
            // TxtPlate
            // 
            TxtPlate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPlate.Location = new Point(256, 428);
            TxtPlate.Multiline = true;
            TxtPlate.Name = "TxtPlate";
            TxtPlate.Size = new Size(158, 31);
            TxtPlate.TabIndex = 32;
            // 
            // TxtCompany
            // 
            TxtCompany.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCompany.Location = new Point(46, 482);
            TxtCompany.Multiline = true;
            TxtCompany.Name = "TxtCompany";
            TxtCompany.Size = new Size(234, 31);
            TxtCompany.TabIndex = 31;
            // 
            // TxtDriver
            // 
            TxtDriver.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDriver.Location = new Point(46, 428);
            TxtDriver.Multiline = true;
            TxtDriver.Name = "TxtDriver";
            TxtDriver.Size = new Size(204, 31);
            TxtDriver.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(685, 409);
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
            NameItemBox.Location = new Point(685, 435);
            NameItemBox.Name = "NameItemBox";
            NameItemBox.Size = new Size(137, 27);
            NameItemBox.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 42F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(194, 331);
            label13.Name = "label13";
            label13.Size = new Size(743, 64);
            label13.TabIndex = 39;
            label13.Text = "AMJJ DELIVERY LOGISTICS";
            // 
            // ReadBTN
            // 
            ReadBTN.Location = new Point(183, 590);
            ReadBTN.Name = "ReadBTN";
            ReadBTN.Size = new Size(75, 23);
            ReadBTN.TabIndex = 50;
            ReadBTN.Text = "READ";
            ReadBTN.UseVisualStyleBackColor = true;
            ReadBTN.Click += ReadBTN_Click;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(825, 629);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(105, 31);
            HomeBTN.TabIndex = 53;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            // 
            // ReceiveBTN
            // 
            ReceiveBTN.Location = new Point(936, 629);
            ReceiveBTN.Name = "ReceiveBTN";
            ReceiveBTN.Size = new Size(105, 31);
            ReceiveBTN.TabIndex = 53;
            ReceiveBTN.Text = "RECEIVE";
            ReceiveBTN.UseVisualStyleBackColor = true;
            // 
            // PickupBTN
            // 
            PickupBTN.Location = new Point(1047, 629);
            PickupBTN.Name = "PickupBTN";
            PickupBTN.Size = new Size(105, 31);
            PickupBTN.TabIndex = 53;
            PickupBTN.Text = "PICKUP";
            PickupBTN.UseVisualStyleBackColor = true;
            // 
            // DeliveryTableView
            // 
            DeliveryTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeliveryTableView.Location = new Point(4, 3);
            DeliveryTableView.Margin = new Padding(3, 2, 3, 2);
            DeliveryTableView.Name = "DeliveryTableView";
            DeliveryTableView.RowHeadersWidth = 51;
            DeliveryTableView.RowTemplate.Height = 29;
            DeliveryTableView.Size = new Size(1152, 326);
            DeliveryTableView.TabIndex = 57;
            // 
            // TxtAddress
            // 
            TxtAddress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAddress.Location = new Point(46, 536);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(271, 31);
            TxtAddress.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 518);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 49;
            label14.Text = "Address";
            // 
            // frmDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1166, 681);
            Controls.Add(DeliveryTableView);
            Controls.Add(DateAndTime);
            Controls.Add(WeightBox);
            Controls.Add(NameItemBox);
            Controls.Add(SizeBox);
            Controls.Add(PickupBTN);
            Controls.Add(ReceiveBTN);
            Controls.Add(HomeBTN);
            Controls.Add(DeleteAllBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBTN);
            Controls.Add(ReadBTN);
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
            Controls.Add(TxtCompany);
            Controls.Add(TxtDriver);
            Name = "frmDelivery";
            Text = "DELIVERY System";
            Load += frmDelivery_Load;
            ((System.ComponentModel.ISupportInitialize)DeliveryTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker DateAndTime;
        private ComboBox WeightBox;
        private ComboBox SizeBox;
        private Button DeleteAllBTN;
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
        private TextBox TxtCompany;
        private TextBox TxtDriver;
        private Label label12;
        private ComboBox NameItemBox;
        private Label label13;
        private Button ReadBTN;
        private Button HomeBTN;
        private Button ReceiveBTN;
        private Button PickupBTN;
        private DataGridView DeliveryTableView;
        private TextBox TxtAddress;
        private Label label14;
    }
}