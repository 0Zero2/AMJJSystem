﻿namespace AMJJSystem
{
    partial class frmUserDashboard
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Time = new Label();
            Date = new Label();
            pictureBox1 = new PictureBox();
            CompanyBTN = new Button();
            ReceiveBTN = new Button();
            DeliveryPickupBTN = new Button();
            ItemBTN = new Button();
            panel2 = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SignoutBTN = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Time);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(6, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 398);
            panel1.TabIndex = 0;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Time.Location = new Point(20, 348);
            Time.Name = "Time";
            Time.Size = new Size(83, 33);
            Time.TabIndex = 1;
            Time.Text = "Time:";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Date.Location = new Point(20, 272);
            Date.Name = "Date";
            Date.Size = new Size(77, 33);
            Date.TabIndex = 1;
            Date.Text = "Date:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 207);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CompanyBTN
            // 
            CompanyBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyBTN.Location = new Point(434, 200);
            CompanyBTN.Margin = new Padding(3, 2, 3, 2);
            CompanyBTN.Name = "CompanyBTN";
            CompanyBTN.Size = new Size(249, 38);
            CompanyBTN.TabIndex = 1;
            CompanyBTN.Text = "Edit Client's Information";
            CompanyBTN.UseVisualStyleBackColor = true;
            CompanyBTN.Click += CompanyBTN_Click;
            // 
            // ReceiveBTN
            // 
            ReceiveBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiveBTN.Location = new Point(973, 350);
            ReceiveBTN.Margin = new Padding(3, 2, 3, 2);
            ReceiveBTN.Name = "ReceiveBTN";
            ReceiveBTN.Size = new Size(190, 38);
            ReceiveBTN.TabIndex = 1;
            ReceiveBTN.Text = "Receive";
            ReceiveBTN.UseVisualStyleBackColor = true;
            ReceiveBTN.Click += ReceiveBTN_Click;
            // 
            // DeliveryPickupBTN
            // 
            DeliveryPickupBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryPickupBTN.Location = new Point(462, 345);
            DeliveryPickupBTN.Margin = new Padding(3, 2, 3, 2);
            DeliveryPickupBTN.Name = "DeliveryPickupBTN";
            DeliveryPickupBTN.Size = new Size(202, 38);
            DeliveryPickupBTN.TabIndex = 1;
            DeliveryPickupBTN.Text = "Delivery / Pick-up";
            DeliveryPickupBTN.UseVisualStyleBackColor = true;
            DeliveryPickupBTN.Click += DeliveryPickupBTN_Click;
            // 
            // ItemBTN
            // 
            ItemBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ItemBTN.Location = new Point(973, 200);
            ItemBTN.Margin = new Padding(3, 2, 3, 2);
            ItemBTN.Name = "ItemBTN";
            ItemBTN.Size = new Size(190, 38);
            ItemBTN.TabIndex = 1;
            ItemBTN.Text = "Client's Product ";
            ItemBTN.UseVisualStyleBackColor = true;
            ItemBTN.Click += ItemBTN_Click;
            // 
            // panel2
            // 
            panel2.AccessibleName = "";
            panel2.Controls.Add(label1);
            panel2.Location = new Point(379, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 83);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 7);
            label1.Name = "label1";
            label1.Size = new Size(836, 73);
            label1.TabIndex = 0;
            label1.Text = "AMJJ Logistics Record System";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SignoutBTN
            // 
            SignoutBTN.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SignoutBTN.Location = new Point(1213, 89);
            SignoutBTN.Margin = new Padding(3, 2, 3, 2);
            SignoutBTN.Name = "SignoutBTN";
            SignoutBTN.Size = new Size(108, 38);
            SignoutBTN.TabIndex = 1;
            SignoutBTN.Text = "Sign out";
            SignoutBTN.UseVisualStyleBackColor = true;
            SignoutBTN.Click += SignoutBTN_Click;
            // 
            // frmUserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 409);
            Controls.Add(panel2);
            Controls.Add(CompanyBTN);
            Controls.Add(panel1);
            Controls.Add(ReceiveBTN);
            Controls.Add(SignoutBTN);
            Controls.Add(ItemBTN);
            Controls.Add(DeliveryPickupBTN);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUserDashboard";
            Text = " User Dashboard";
            Load += frmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CompanyBTN;
        private Button ReceiveBTN;
        private Button DeliveryPickupBTN;
        private Button ItemBTN;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label Date;
        private System.Windows.Forms.Timer timer1;
        private Label Time;
        private Button SignoutBTN;
    }
}