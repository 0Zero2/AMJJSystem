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
            TxtUsername = new TextBox();
            label8 = new Label();
            ClientRB = new RadioButton();
            driverRB = new RadioButton();
            DriverLabel = new Label();
            SuspendLayout();
            // 
            // clearBTN
            // 
            clearBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearBTN.Location = new Point(54, 526);
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
            registerBTN.Location = new Point(54, 475);
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
            showCheckBox.Location = new Point(261, 388);
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
            loginLabel.Location = new Point(232, 573);
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
            label4.Location = new Point(70, 573);
            label4.Name = "label4";
            label4.Size = new Size(162, 17);
            label4.TabIndex = 11;
            label4.Text = "Already have an account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 388);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 225);
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
            TxtPassword.Location = new Point(56, 417);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(267, 38);
            TxtPassword.TabIndex = 10;
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
            // TxtUsername
            // 
            TxtUsername.Location = new Point(57, 311);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(269, 33);
            TxtUsername.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(54, 289);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 9;
            label8.Text = "Username";
            // 
            // ClientRB
            // 
            ClientRB.AutoSize = true;
            ClientRB.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClientRB.Location = new Point(141, 359);
            ClientRB.Name = "ClientRB";
            ClientRB.Size = new Size(71, 25);
            ClientRB.TabIndex = 16;
            ClientRB.TabStop = true;
            ClientRB.Text = "Client";
            ClientRB.UseVisualStyleBackColor = true;
            ClientRB.CheckedChanged += ClientRB_CheckedChanged;
            // 
            // driverRB
            // 
            driverRB.AutoSize = true;
            driverRB.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            driverRB.Location = new Point(57, 359);
            driverRB.Name = "driverRB";
            driverRB.Size = new Size(74, 25);
            driverRB.TabIndex = 17;
            driverRB.TabStop = true;
            driverRB.Text = "Driver";
            driverRB.UseVisualStyleBackColor = true;
            driverRB.CheckedChanged += driverRB_CheckedChanged;
            // 
            // DriverLabel
            // 
            DriverLabel.AutoSize = true;
            DriverLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DriverLabel.ForeColor = Color.FromArgb(192, 0, 0);
            DriverLabel.Location = new Point(166, 599);
            DriverLabel.Name = "DriverLabel";
            DriverLabel.Size = new Size(46, 17);
            DriverLabel.TabIndex = 10;
            DriverLabel.Text = "Driver";
            DriverLabel.Click += DriverLabel_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 644);
            Controls.Add(driverRB);
            Controls.Add(ClientRB);
            Controls.Add(clearBTN);
            Controls.Add(registerBTN);
            Controls.Add(showCheckBox);
            Controls.Add(DriverLabel);
            Controls.Add(loginLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtFirstname);
            Controls.Add(TxtUsername);
            Controls.Add(TxtLastname);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegister";
            Text = "Register";
            Load += frmRegister_Load;
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
        private TextBox TxtUsername;
        private Label label8;
        private RadioButton ClientRB;
        private RadioButton driverRB;
        private Label DriverLabel;
    }
}