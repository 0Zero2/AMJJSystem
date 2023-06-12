namespace AMJJSystem
{
    partial class frmDriverDashboard
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Time = new Label();
            Date = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ReceiveBTN = new Button();
            DeliveryPickupBTN = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            DrInfoBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(Time);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 537);
            panel1.TabIndex = 3;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Time.Location = new Point(14, 372);
            Time.Name = "Time";
            Time.Size = new Size(83, 33);
            Time.TabIndex = 1;
            Time.Text = "Time:";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Date.Location = new Point(14, 294);
            Date.Name = "Date";
            Date.Size = new Size(77, 33);
            Date.TabIndex = 1;
            Date.Text = "Date:";
            // 
            // panel2
            // 
            panel2.AccessibleName = "";
            panel2.Controls.Add(label1);
            panel2.Location = new Point(373, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1138, 83);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 7);
            label1.Name = "label1";
            label1.Size = new Size(836, 73);
            label1.TabIndex = 0;
            label1.Text = "AMJJ Logistics Record System";
            // 
            // ReceiveBTN
            // 
            ReceiveBTN.Location = new Point(1259, 354);
            ReceiveBTN.Margin = new Padding(3, 2, 3, 2);
            ReceiveBTN.Name = "ReceiveBTN";
            ReceiveBTN.Size = new Size(138, 38);
            ReceiveBTN.TabIndex = 5;
            ReceiveBTN.Text = "Receive Information";
            ReceiveBTN.UseVisualStyleBackColor = true;
            ReceiveBTN.Click += ReceiveBTN_Click;
            // 
            // DeliveryPickupBTN
            // 
            DeliveryPickupBTN.Location = new Point(852, 354);
            DeliveryPickupBTN.Margin = new Padding(3, 2, 3, 2);
            DeliveryPickupBTN.Name = "DeliveryPickupBTN";
            DeliveryPickupBTN.Size = new Size(183, 38);
            DeliveryPickupBTN.TabIndex = 7;
            DeliveryPickupBTN.Text = "Delivery / Pick-up Information";
            DeliveryPickupBTN.UseVisualStyleBackColor = true;
            DeliveryPickupBTN.Click += DeliveryPickupBTN_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // DrInfoBTN
            // 
            DrInfoBTN.Location = new Point(484, 354);
            DrInfoBTN.Margin = new Padding(3, 2, 3, 2);
            DrInfoBTN.Name = "DrInfoBTN";
            DrInfoBTN.Size = new Size(133, 38);
            DrInfoBTN.TabIndex = 7;
            DrInfoBTN.Text = "Driver Inforamtion";
            DrInfoBTN.UseVisualStyleBackColor = true;
            DrInfoBTN.Click += DrInfoBTN_Click;
            // 
            // frmDriverDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 554);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(ReceiveBTN);
            Controls.Add(DrInfoBTN);
            Controls.Add(DeliveryPickupBTN);
            Name = "frmDriverDashboard";
            Text = "Driver Dashboard";
            Load += frmDriverDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label Time;
        private Label Date;
        private Panel panel2;
        private Label label1;
        private Button ReceiveBTN;
        private Button DeliveryPickupBTN;
        private System.Windows.Forms.Timer timer1;
        private Button DrInfoBTN;
    }
}