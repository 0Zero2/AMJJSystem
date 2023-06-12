namespace AMJJSystem
{
    partial class frmDriver
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
            ShowCheckBox = new CheckBox();
            BtnLogin = new Button();
            BtnClear = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 176);
            label1.Name = "label1";
            label1.Size = new Size(112, 42);
            label1.TabIndex = 0;
            label1.Text = "Driver";
            // 
            // ShowCheckBox
            // 
            ShowCheckBox.AutoSize = true;
            ShowCheckBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowCheckBox.Location = new Point(262, 312);
            ShowCheckBox.Name = "ShowCheckBox";
            ShowCheckBox.Size = new Size(63, 23);
            ShowCheckBox.TabIndex = 3;
            ShowCheckBox.Text = "Show";
            ShowCheckBox.UseVisualStyleBackColor = true;
            ShowCheckBox.CheckedChanged += ShowCheckBox_CheckedChanged;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Location = new Point(52, 403);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(273, 34);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClear.Location = new Point(52, 457);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(273, 33);
            BtnClear.TabIndex = 5;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 515);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 6;
            label2.Text = "Go to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(175, 515);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 7;
            label3.Text = "Register";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 249);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(52, 273);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(273, 33);
            TxtUsername.TabIndex = 9;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(52, 347);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(273, 26);
            TxtPassword.TabIndex = 10;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 323);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // frmDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 631);
            Controls.Add(label5);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnClear);
            Controls.Add(BtnLogin);
            Controls.Add(ShowCheckBox);
            Controls.Add(label1);
            Name = "frmDriver";
            Text = "DRIVER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox ShowCheckBox;
        private Button BtnLogin;
        private Button BtnClear;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label label5;
    }
}