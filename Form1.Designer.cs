namespace AMJJSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button2 = new Button();
            label5 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(520, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 682);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(307, 596);
            button2.Name = "button2";
            button2.Size = new Size(131, 34);
            button2.TabIndex = 10;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(105, 608);
            label5.Name = "label5";
            label5.Size = new Size(196, 22);
            label5.TabIndex = 9;
            label5.Text = "Don't have an account ?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(439, 405);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 26);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 477);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 472);
            label4.Name = "label4";
            label4.Size = new Size(107, 33);
            label4.TabIndex = 6;
            label4.Text = "Security";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 398);
            label3.Name = "label3";
            label3.Size = new Size(121, 33);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 324);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(15, 526);
            button1.Name = "button1";
            button1.Size = new Size(501, 40);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 434);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(501, 35);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 360);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(501, 35);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(219, 272);
            label1.Name = "label1";
            label1.Size = new Size(104, 42);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(54, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(411, 548);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1067, 715);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}