﻿namespace AMJJSystem
{
    partial class frmClientCompany
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
            CreateBTN = new Button();
            Label = new Label();
            TxtCompanyName = new TextBox();
            label2 = new Label();
            TxtCompanyNumber = new TextBox();
            label3 = new Label();
            TxtCompanyID = new TextBox();
            TxtContactPerson = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TxtPhoneNumber = new TextBox();
            TxtDriver = new TextBox();
            TxtPlateNumber = new TextBox();
            TxtContactNumber = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ClientCompTableView = new DataGridView();
            RefreshBTN = new Button();
            UpdateBTN = new Button();
            DeleteBTN = new Button();
            HomeBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)ClientCompTableView).BeginInit();
            SuspendLayout();
            // 
            // CreateBTN
            // 
            CreateBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBTN.Location = new Point(23, 358);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(86, 40);
            CreateBTN.TabIndex = 0;
            CreateBTN.Text = "CREATE";
            CreateBTN.UseVisualStyleBackColor = true;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Times New Roman", 29.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label.Location = new Point(5, 30);
            Label.Name = "Label";
            Label.Size = new Size(485, 43);
            Label.TabIndex = 1;
            Label.Text = "Client's Company Information";
            // 
            // TxtCompanyName
            // 
            TxtCompanyName.Location = new Point(10, 172);
            TxtCompanyName.Multiline = true;
            TxtCompanyName.Name = "TxtCompanyName";
            TxtCompanyName.Size = new Size(181, 27);
            TxtCompanyName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Name of Company";
            // 
            // TxtCompanyNumber
            // 
            TxtCompanyNumber.Location = new Point(198, 172);
            TxtCompanyNumber.Multiline = true;
            TxtCompanyNumber.Name = "TxtCompanyNumber";
            TxtCompanyNumber.Size = new Size(136, 27);
            TxtCompanyNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 154);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Company Number";
            // 
            // TxtCompanyID
            // 
            TxtCompanyID.Location = new Point(10, 115);
            TxtCompanyID.Multiline = true;
            TxtCompanyID.Name = "TxtCompanyID";
            TxtCompanyID.ReadOnly = true;
            TxtCompanyID.Size = new Size(181, 27);
            TxtCompanyID.TabIndex = 2;
            // 
            // TxtContactPerson
            // 
            TxtContactPerson.Location = new Point(10, 222);
            TxtContactPerson.Multiline = true;
            TxtContactPerson.Name = "TxtContactPerson";
            TxtContactPerson.Size = new Size(181, 27);
            TxtContactPerson.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Company ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 204);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 3;
            label5.Text = "Contact Person";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(198, 222);
            TxtPhoneNumber.Multiline = true;
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Size = new Size(136, 27);
            TxtPhoneNumber.TabIndex = 2;
            // 
            // TxtDriver
            // 
            TxtDriver.Location = new Point(10, 277);
            TxtDriver.Multiline = true;
            TxtDriver.Name = "TxtDriver";
            TxtDriver.Size = new Size(181, 27);
            TxtDriver.TabIndex = 2;
            // 
            // TxtPlateNumber
            // 
            TxtPlateNumber.Location = new Point(340, 277);
            TxtPlateNumber.Multiline = true;
            TxtPlateNumber.Name = "TxtPlateNumber";
            TxtPlateNumber.Size = new Size(107, 27);
            TxtPlateNumber.TabIndex = 2;
            // 
            // TxtContactNumber
            // 
            TxtContactNumber.Location = new Point(197, 277);
            TxtContactNumber.Multiline = true;
            TxtContactNumber.Name = "TxtContactNumber";
            TxtContactNumber.Size = new Size(137, 27);
            TxtContactNumber.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 204);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 3;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 259);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 3;
            label7.Text = "Plate No.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 259);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 3;
            label8.Text = "Driver";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(197, 259);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 3;
            label9.Text = "Contact Number";
            // 
            // ClientCompTableView
            // 
            ClientCompTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            ClientCompTableView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            ClientCompTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientCompTableView.Location = new Point(496, 5);
            ClientCompTableView.Name = "ClientCompTableView";
            ClientCompTableView.RowHeadersWidth = 51;
            ClientCompTableView.RowTemplate.Height = 25;
            ClientCompTableView.Size = new Size(940, 575);
            ClientCompTableView.TabIndex = 4;
            ClientCompTableView.CellClick += ClientCompTableView_CellClick;
            // 
            // RefreshBTN
            // 
            RefreshBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshBTN.Location = new Point(141, 358);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(90, 40);
            RefreshBTN.TabIndex = 5;
            RefreshBTN.Text = "REFRESH";
            RefreshBTN.UseVisualStyleBackColor = true;
            RefreshBTN.Click += RefreshBTN_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBTN.Location = new Point(273, 358);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(90, 40);
            UpdateBTN.TabIndex = 6;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBTN.Location = new Point(397, 358);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(82, 40);
            DeleteBTN.TabIndex = 7;
            DeleteBTN.Text = "DELETE";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // HomeBTN
            // 
            HomeBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomeBTN.Location = new Point(197, 446);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(105, 41);
            HomeBTN.TabIndex = 90;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // frmClientCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 586);
            Controls.Add(HomeBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBTN);
            Controls.Add(RefreshBTN);
            Controls.Add(ClientCompTableView);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(TxtContactNumber);
            Controls.Add(TxtPlateNumber);
            Controls.Add(TxtContactPerson);
            Controls.Add(TxtDriver);
            Controls.Add(TxtCompanyID);
            Controls.Add(TxtPhoneNumber);
            Controls.Add(TxtCompanyNumber);
            Controls.Add(TxtCompanyName);
            Controls.Add(Label);
            Controls.Add(CreateBTN);
            Name = "frmClientCompany";
            Text = "Company";
            Load += ClientCompany_Load;
            ((System.ComponentModel.ISupportInitialize)ClientCompTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateBTN;
        private Label Label;
        private TextBox TxtCompanyName;
        private Label label2;
        private TextBox TxtCompanyNumber;
        private Label label3;
        private TextBox TxtCompanyID;
        private TextBox TxtContactPerson;
        private Label label4;
        private Label label5;
        private TextBox TxtPhoneNumber;
        private TextBox TxtDriver;
        private TextBox TxtPlateNumber;
        private TextBox TxtContactNumber;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView ClientCompTableView;
        private Button RefreshBTN;
        private Button UpdateBTN;
        private Button DeleteBTN;
        private Button HomeBTN;
    }
}