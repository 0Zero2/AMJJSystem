﻿namespace AMJJSystem
{
    partial class frmProduct
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
            TxtItemID = new TextBox();
            TxtNameOfItem = new TextBox();
            TxtSize = new TextBox();
            TxtWeight = new TextBox();
            CreateBTN = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CompProductTableView = new DataGridView();
            RefreshBTN = new Button();
            UpdateBTN = new Button();
            DeleteBTN = new Button();
            HomeBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)CompProductTableView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(465, 42);
            label1.TabIndex = 0;
            label1.Text = "Company Product Information\r\n";
            // 
            // TxtItemID
            // 
            TxtItemID.Location = new Point(50, 120);
            TxtItemID.Name = "TxtItemID";
            TxtItemID.Size = new Size(111, 23);
            TxtItemID.TabIndex = 1;
            // 
            // TxtNameOfItem
            // 
            TxtNameOfItem.Location = new Point(50, 171);
            TxtNameOfItem.Name = "TxtNameOfItem";
            TxtNameOfItem.Size = new Size(247, 23);
            TxtNameOfItem.TabIndex = 2;
            // 
            // TxtSize
            // 
            TxtSize.Location = new Point(50, 217);
            TxtSize.Name = "TxtSize";
            TxtSize.Size = new Size(122, 23);
            TxtSize.TabIndex = 3;
            // 
            // TxtWeight
            // 
            TxtWeight.Location = new Point(178, 217);
            TxtWeight.Name = "TxtWeight";
            TxtWeight.Size = new Size(119, 23);
            TxtWeight.TabIndex = 4;
            // 
            // CreateBTN
            // 
            CreateBTN.Location = new Point(50, 270);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(75, 23);
            CreateBTN.TabIndex = 9;
            CreateBTN.Text = "CREATE";
            CreateBTN.UseVisualStyleBackColor = true;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 102);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 10;
            label2.Text = "Item ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 153);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 11;
            label3.Text = "Name of Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 199);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 12;
            label4.Text = "Size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 199);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 13;
            label5.Text = "Weight";
            // 
            // CompProductTableView
            // 
            CompProductTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompProductTableView.Location = new Point(483, 12);
            CompProductTableView.Name = "CompProductTableView";
            CompProductTableView.RowTemplate.Height = 25;
            CompProductTableView.Size = new Size(746, 488);
            CompProductTableView.TabIndex = 17;
            CompProductTableView.CellClick += CompProductTableView_CellClick;
            // 
            // RefreshBTN
            // 
            RefreshBTN.Location = new Point(483, 506);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(75, 23);
            RefreshBTN.TabIndex = 18;
            RefreshBTN.Text = "REFRESH";
            RefreshBTN.UseVisualStyleBackColor = true;
            RefreshBTN.Click += RefreshBTN_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Location = new Point(151, 270);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(75, 23);
            UpdateBTN.TabIndex = 19;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(243, 270);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(75, 23);
            DeleteBTN.TabIndex = 20;
            DeleteBTN.Text = "DELETE";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(1124, 506);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(105, 31);
            HomeBTN.TabIndex = 90;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 547);
            Controls.Add(HomeBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBTN);
            Controls.Add(RefreshBTN);
            Controls.Add(CompProductTableView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CreateBTN);
            Controls.Add(TxtWeight);
            Controls.Add(TxtSize);
            Controls.Add(TxtNameOfItem);
            Controls.Add(TxtItemID);
            Controls.Add(label1);
            Name = "frmProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)CompProductTableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtItemID;
        private TextBox TxtNameOfItem;
        private TextBox TxtSize;
        private TextBox TxtWeight;
        private Button CreateBTN;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView CompProductTableView;
        private Button RefreshBTN;
        private Button UpdateBTN;
        private Button DeleteBTN;
        private Button HomeBTN;
    }
}