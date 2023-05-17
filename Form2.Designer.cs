namespace AMJJSystem
{
    partial class frmRegister
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
            clearBTN = new Button();
            registerBTN = new Button();
            showCheckBox = new CheckBox();
            loginLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtPassword = new TextBox();
            TxtLastname = new TextBox();
            TxtFirstname = new TextBox();
            label6 = new Label();
            TxtPhonenum = new TextBox();
            label7 = new Label();
            TxtUsername = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // clearBTN
            // 
            clearBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearBTN.Location = new Point(56, 538);
            clearBTN.Name = "clearBTN";
            clearBTN.Size = new Size(269, 31);
            clearBTN.TabIndex = 14;
            clearBTN.Text = "Clear";
            clearBTN.UseVisualStyleBackColor = true;
            clearBTN.Click += clearBTN_Click;
            // 
            // registerBTN
            // 
            registerBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerBTN.Location = new Point(56, 487);
            registerBTN.Name = "registerBTN";
            registerBTN.Size = new Size(269, 31);
            registerBTN.TabIndex = 15;
            registerBTN.Text = "Register";
            registerBTN.UseVisualStyleBackColor = true;
            registerBTN.Click += registerBTN_Click;
            // 
            // showCheckBox
            // 
            showCheckBox.AutoSize = true;
            showCheckBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showCheckBox.Location = new Point(263, 406);
            showCheckBox.Name = "showCheckBox";
            showCheckBox.Size = new Size(63, 23);
            showCheckBox.TabIndex = 13;
            showCheckBox.Text = "Show";
            showCheckBox.UseVisualStyleBackColor = true;
            showCheckBox.CheckedChanged += showCheckBox_CheckedChanged;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(192, 0, 0);
            loginLabel.Location = new Point(234, 585);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(45, 17);
            loginLabel.TabIndex = 10;
            loginLabel.Text = "Log in";
            loginLabel.Click += loginLabel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 585);
            label4.Name = "label4";
            label4.Size = new Size(162, 17);
            label4.TabIndex = 11;
            label4.Text = "Already have an account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 403);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 225);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 9;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(126, 112);
            label1.Name = "label1";
            label1.Size = new Size(138, 42);
            label1.TabIndex = 8;
            label1.Text = "Register";
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(58, 435);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(267, 38);
            TxtPassword.TabIndex = 6;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtLastname
            // 
            TxtLastname.Location = new Point(57, 253);
            TxtLastname.Multiline = true;
            TxtLastname.Name = "TxtLastname";
            TxtLastname.Size = new Size(272, 33);
            TxtLastname.TabIndex = 7;
            // 
            // TxtFirstname
            // 
            TxtFirstname.Location = new Point(56, 189);
            TxtFirstname.Multiline = true;
            TxtFirstname.Name = "TxtFirstname";
            TxtFirstname.Size = new Size(273, 33);
            TxtFirstname.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(56, 167);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 9;
            label6.Text = "Firstname";
            // 
            // TxtPhonenum
            // 
            TxtPhonenum.Location = new Point(57, 309);
            TxtPhonenum.Multiline = true;
            TxtPhonenum.Name = "TxtPhonenum";
            TxtPhonenum.Size = new Size(270, 33);
            TxtPhonenum.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 287);
            label7.Name = "label7";
            label7.Size = new Size(96, 19);
            label7.TabIndex = 9;
            label7.Text = "Phone number";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(57, 367);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(269, 33);
            TxtUsername.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(60, 345);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 9;
            label8.Text = "Username";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 644);
            Controls.Add(clearBTN);
            Controls.Add(registerBTN);
            Controls.Add(showCheckBox);
            Controls.Add(loginLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtFirstname);
            Controls.Add(TxtUsername);
            Controls.Add(TxtPhonenum);
            Controls.Add(TxtLastname);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegister";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearBTN;
        private Button registerBTN;
        private CheckBox showCheckBox;
        private Label loginLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtPassword;
        private TextBox TxtLastname;
        private TextBox TxtFirstname;
        private Label label6;
        private TextBox TxtPhonenum;
        private Label label7;
        private TextBox TxtUsername;
        private Label label8;
    }
}