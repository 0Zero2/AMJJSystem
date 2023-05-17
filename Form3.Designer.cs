namespace AMJJSystem
{
    partial class frmDashboard
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            PickupBTN = new Button();
            ReceiveBTN = new Button();
            DeliveryBTN = new Button();
            HomeBTN = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(6, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 569);
            panel1.TabIndex = 0;
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
            // PickupBTN
            // 
            PickupBTN.Location = new Point(855, 471);
            PickupBTN.Margin = new Padding(3, 2, 3, 2);
            PickupBTN.Name = "PickupBTN";
            PickupBTN.Size = new Size(340, 38);
            PickupBTN.TabIndex = 1;
            PickupBTN.Text = "Pick-up";
            PickupBTN.UseVisualStyleBackColor = true;
            PickupBTN.Click += PickupBTN_Click;
            // 
            // ReceiveBTN
            // 
            ReceiveBTN.Location = new Point(482, 471);
            ReceiveBTN.Margin = new Padding(3, 2, 3, 2);
            ReceiveBTN.Name = "ReceiveBTN";
            ReceiveBTN.Size = new Size(340, 38);
            ReceiveBTN.TabIndex = 1;
            ReceiveBTN.Text = "Receive";
            ReceiveBTN.UseVisualStyleBackColor = true;
            ReceiveBTN.Click += ReceiveBTN_Click;
            // 
            // DeliveryBTN
            // 
            DeliveryBTN.Location = new Point(855, 252);
            DeliveryBTN.Margin = new Padding(3, 2, 3, 2);
            DeliveryBTN.Name = "DeliveryBTN";
            DeliveryBTN.Size = new Size(340, 38);
            DeliveryBTN.TabIndex = 1;
            DeliveryBTN.Text = "Delivery";
            DeliveryBTN.UseVisualStyleBackColor = true;
            DeliveryBTN.Click += DeliveryBTN_Click;
            // 
            // HomeBTN
            // 
            HomeBTN.Location = new Point(482, 252);
            HomeBTN.Margin = new Padding(3, 2, 3, 2);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Size = new Size(340, 38);
            HomeBTN.TabIndex = 1;
            HomeBTN.Text = "Home";
            HomeBTN.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AccessibleName = "";
            panel2.Controls.Add(label1);
            panel2.Location = new Point(379, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 79);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 6);
            label1.Name = "label1";
            label1.Size = new Size(636, 73);
            label1.TabIndex = 0;
            label1.Text = "AMJJ Logistics System";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 576);
            Controls.Add(panel2);
            Controls.Add(PickupBTN);
            Controls.Add(panel1);
            Controls.Add(ReceiveBTN);
            Controls.Add(HomeBTN);
            Controls.Add(DeliveryBTN);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button PickupBTN;
        private Button ReceiveBTN;
        private Button DeliveryBTN;
        private Button HomeBTN;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
    }
}