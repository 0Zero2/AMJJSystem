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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 275);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 33);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 351);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 33);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 205);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 247);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 323);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(240, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(51, 438);
            button1.Name = "button1";
            button1.Size = new Size(272, 31);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(51, 494);
            button2.Name = "button2";
            button2.Size = new Size(272, 31);
            button2.TabIndex = 5;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 551);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 578);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 3;
            label5.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(381, 631);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
    }
}