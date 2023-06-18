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
            DateTimePicker = new DateTimePicker();
            WeightComboBox = new ComboBox();
            ItemComboBox = new ComboBox();
            SizeComboBox = new ComboBox();
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
            label1 = new Label();
            TxtRemarks = new TextBox();
            TxtQuantity = new TextBox();
            TxtRbyPn = new TextBox();
            TxtNccPn = new TextBox();
            TxtRby = new TextBox();
            label13 = new Label();
            HomeBTN = new Button();
            ReceiveDataGridView = new DataGridView();
            panel1 = new Panel();
            label15 = new Label();
            AddBTN = new Button();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            RfComboBox = new ComboBox();
            NccComboBox = new ComboBox();
            ItemReceivedListView = new ListView();
            ((System.ComponentModel.ISupportInitialize)ReceiveDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // DateTimePicker
            // 
            DateTimePicker.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePicker.Location = new Point(295, 591);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(239, 26);
            DateTimePicker.TabIndex = 85;
            // 
            // WeightComboBox
            // 
            WeightComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WeightComboBox.FormattingEnabled = true;
            WeightComboBox.Location = new Point(140, 171);
            WeightComboBox.Name = "WeightComboBox";
            WeightComboBox.Size = new Size(123, 27);
            WeightComboBox.TabIndex = 84;
            // 
            // ItemComboBox
            // 
            ItemComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(12, 66);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(251, 27);
            ItemComboBox.TabIndex = 83;
            ItemComboBox.SelectedIndexChanged += ItemComboBox_SelectedIndexChanged;
            // 
            // SizeComboBox
            // 
            SizeComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SizeComboBox.FormattingEnabled = true;
            SizeComboBox.Location = new Point(12, 171);
            SizeComboBox.Name = "SizeComboBox";
            SizeComboBox.Size = new Size(122, 27);
            SizeComboBox.TabIndex = 82;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBTN.Location = new Point(425, 631);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(97, 28);
            DeleteBTN.TabIndex = 80;
            DeleteBTN.Text = "DELETE";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBTN.Location = new Point(298, 632);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(98, 28);
            UpdateBTN.TabIndex = 79;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // RefreshBTN
            // 
            RefreshBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshBTN.Location = new Point(173, 631);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(93, 28);
            RefreshBTN.TabIndex = 78;
            RefreshBTN.Text = "REFRESH";
            RefreshBTN.UseVisualStyleBackColor = true;
            RefreshBTN.Click += RefreshBTN_Click;
            // 
            // CreateBTN
            // 
            CreateBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateBTN.Location = new Point(49, 632);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(94, 28);
            CreateBTN.TabIndex = 77;
            CreateBTN.Text = "CREATE";
            CreateBTN.UseVisualStyleBackColor = true;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(346, 565);
            label10.Name = "label10";
            label10.Size = new Size(130, 23);
            label10.TabIndex = 75;
            label10.Text = "Date and Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(140, 149);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 74;
            label8.Text = "Weight";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 146);
            label9.Name = "label9";
            label9.Size = new Size(54, 19);
            label9.TabIndex = 73;
            label9.Text = "Volume";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(826, 612);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 72;
            label6.Text = "Remarks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 44);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 76;
            label4.Text = "Received By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 51);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 71;
            label2.Text = "Name of Company";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 44);
            label12.Name = "label12";
            label12.Size = new Size(93, 19);
            label12.TabIndex = 70;
            label12.Text = "Name of Item";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 95);
            label7.Name = "label7";
            label7.Size = new Size(60, 19);
            label7.TabIndex = 69;
            label7.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 95);
            label11.Name = "label11";
            label11.Size = new Size(96, 19);
            label11.TabIndex = 68;
            label11.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 149);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 67;
            label5.Text = "Phone number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 103);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 65;
            label1.Text = "Received from";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRemarks.Location = new Point(826, 634);
            TxtRemarks.Multiline = true;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(350, 29);
            TxtRemarks.TabIndex = 63;
            // 
            // TxtQuantity
            // 
            TxtQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtQuantity.Location = new Point(12, 117);
            TxtQuantity.Multiline = true;
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(251, 26);
            TxtQuantity.TabIndex = 62;
            // 
            // TxtRbyPn
            // 
            TxtRbyPn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRbyPn.Location = new Point(3, 118);
            TxtRbyPn.Multiline = true;
            TxtRbyPn.Name = "TxtRbyPn";
            TxtRbyPn.Size = new Size(233, 26);
            TxtRbyPn.TabIndex = 61;
            // 
            // TxtNccPn
            // 
            TxtNccPn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNccPn.Location = new Point(22, 170);
            TxtNccPn.Name = "TxtNccPn";
            TxtNccPn.Size = new Size(235, 26);
            TxtNccPn.TabIndex = 60;
            // 
            // TxtRby
            // 
            TxtRby.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRby.Location = new Point(3, 66);
            TxtRby.Multiline = true;
            TxtRby.Name = "TxtRby";
            TxtRby.Size = new Size(233, 26);
            TxtRby.TabIndex = 59;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 42F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(108, 339);
            label13.Name = "label13";
            label13.Size = new Size(975, 64);
            label13.TabIndex = 86;
            label13.Text = "AMJJ RECEIVE LOGISTICS RECORDS";
            // 
            // HomeBTN
            // 
            HomeBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomeBTN.Location = new Point(49, 342);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(70, 50);
            HomeBTN.TabIndex = 89;
            HomeBTN.Text = "HOME";
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // ReceiveDataGridView
            // 
            ReceiveDataGridView.AllowUserToAddRows = false;
            ReceiveDataGridView.AllowUserToDeleteRows = false;
            ReceiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            ReceiveDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            ReceiveDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReceiveDataGridView.Location = new Point(3, 3);
            ReceiveDataGridView.Margin = new Padding(3, 2, 3, 2);
            ReceiveDataGridView.Name = "ReceiveDataGridView";
            ReceiveDataGridView.RowHeadersWidth = 51;
            ReceiveDataGridView.RowTemplate.Height = 29;
            ReceiveDataGridView.Size = new Size(1183, 334);
            ReceiveDataGridView.TabIndex = 90;
            ReceiveDataGridView.CellClick += ReceiveDataGridView_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label15);
            panel1.Controls.Add(ItemComboBox);
            panel1.Controls.Add(TxtQuantity);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(WeightComboBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(AddBTN);
            panel1.Controls.Add(SizeComboBox);
            panel1.Location = new Point(540, 406);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 257);
            panel1.TabIndex = 91;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(67, 12);
            label15.Name = "label15";
            label15.Size = new Size(151, 23);
            label15.TabIndex = 77;
            label15.Text = "Item Information";
            // 
            // AddBTN
            // 
            AddBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBTN.Location = new Point(84, 216);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(97, 28);
            AddBTN.TabIndex = 80;
            AddBTN.Text = "ADD";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TxtRbyPn);
            panel2.Controls.Add(TxtRby);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(295, 406);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 151);
            panel2.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 12);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 77;
            label3.Text = "Logistics Company";
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(RfComboBox);
            panel3.Controls.Add(NccComboBox);
            panel3.Controls.Add(TxtNccPn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 406);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 213);
            panel3.TabIndex = 93;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(54, 12);
            label14.Name = "label14";
            label14.Size = new Size(177, 23);
            label14.TabIndex = 77;
            label14.Text = "Client's Information";
            // 
            // RfComboBox
            // 
            RfComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RfComboBox.FormattingEnabled = true;
            RfComboBox.Location = new Point(22, 124);
            RfComboBox.Name = "RfComboBox";
            RfComboBox.Size = new Size(235, 27);
            RfComboBox.TabIndex = 94;
            // 
            // NccComboBox
            // 
            NccComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NccComboBox.FormattingEnabled = true;
            NccComboBox.Location = new Point(22, 73);
            NccComboBox.Name = "NccComboBox";
            NccComboBox.Size = new Size(235, 27);
            NccComboBox.TabIndex = 94;
            NccComboBox.SelectedIndexChanged += NccComboBox_SelectedIndexChanged;
            // 
            // ItemReceivedListView
            // 
            ItemReceivedListView.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemReceivedListView.Location = new Point(824, 406);
            ItemReceivedListView.Name = "ItemReceivedListView";
            ItemReceivedListView.Size = new Size(352, 198);
            ItemReceivedListView.TabIndex = 94;
            ItemReceivedListView.UseCompatibleStateImageBehavior = false;
            // 
            // frmReceive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 672);
            Controls.Add(ItemReceivedListView);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ReceiveDataGridView);
            Controls.Add(HomeBTN);
            Controls.Add(label13);
            Controls.Add(DateTimePicker);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBTN);
            Controls.Add(RefreshBTN);
            Controls.Add(CreateBTN);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(TxtRemarks);
            Name = "frmReceive";
            Text = "Form5";
            Load += frmReceive_Load;
            ((System.ComponentModel.ISupportInitialize)ReceiveDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker DateTimePicker;
        private ComboBox WeightComboBox;
        private ComboBox ItemComboBox;
        private ComboBox SizeComboBox;
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
        private Label label1;
        private TextBox TxtRemarks;
        private TextBox TxtQuantity;
        private TextBox TxtRbyPn;
        private TextBox TxtNccPn;
        private TextBox TxtRby;
        private Label label13;
        private Button button8;
        private Button button7;
        private Button HomeBTN;
        private DataGridView ReceiveDataGridView;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox NccComboBox;
        private Label label15;
        private Label label3;
        private Label label14;
        private ComboBox RfComboBox;
        private ListView ItemReceivedListView;
        private Button AddBTN;
    }
}