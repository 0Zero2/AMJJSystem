namespace AMJJSystem
{
    partial class Form3
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
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
            panel1.Location = new Point(7, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 759);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(725, 628);
            button4.Name = "button4";
            button4.Size = new Size(389, 51);
            button4.TabIndex = 1;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(949, 484);
            button3.Name = "button3";
            button3.Size = new Size(389, 51);
            button3.TabIndex = 1;
            button3.Text = "Pick-up";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(522, 484);
            button2.Name = "button2";
            button2.Size = new Size(389, 51);
            button2.TabIndex = 1;
            button2.Text = "Receive";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(949, 335);
            button5.Name = "button5";
            button5.Size = new Size(389, 51);
            button5.TabIndex = 1;
            button5.Text = "Delivery";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(522, 335);
            button1.Name = "button1";
            button1.Size = new Size(389, 51);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 276);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AccessibleName = "";
            panel2.Controls.Add(label1);
            panel2.Location = new Point(433, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 105);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 768);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Name = "Form3";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
    }
}