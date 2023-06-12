namespace AMJJSystem
{
    partial class frmLogin
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
            TxtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            showCheckBox = new CheckBox();
            loginBTN = new Button();
            clearBTN = new Button();
            label4 = new Label();
            createLabel = new Label();
            TxtPassword = new TextBox();
            SuspendLayout();
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(50, 285);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(273, 33);
            TxtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 191);
            label1.Name = "label1";
            label1.Size = new Size(87, 42);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 261);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 323);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // showCheckBox
            // 
            showCheckBox.AutoSize = true;
            showCheckBox.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            showCheckBox.Location = new Point(263, 324);
            showCheckBox.Name = "showCheckBox";
            showCheckBox.Size = new Size(60, 21);
            showCheckBox.TabIndex = 4;
            showCheckBox.Text = "Show";
            showCheckBox.UseVisualStyleBackColor = true;
            showCheckBox.CheckedChanged += showCheckbox_CheckedChanged;
            // 
            // loginBTN
            // 
            loginBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBTN.Location = new Point(51, 405);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(272, 31);
            loginBTN.TabIndex = 5;
            loginBTN.Text = "Login";
            loginBTN.UseVisualStyleBackColor = true;
            loginBTN.Click += loginBTN_Click;
            // 
            // clearBTN
            // 
            clearBTN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearBTN.Location = new Point(51, 457);
            clearBTN.Name = "clearBTN";
            clearBTN.Size = new Size(272, 31);
            clearBTN.TabIndex = 5;
            clearBTN.Text = "Clear";
            clearBTN.UseVisualStyleBackColor = true;
            clearBTN.Click += clearBTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(101, 515);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 3;
            label4.Text = "New here? ";
            // 
            // createLabel
            // 
            createLabel.AutoSize = true;
            createLabel.BackColor = SystemColors.Control;
            createLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            createLabel.ForeColor = Color.FromArgb(192, 0, 0);
            createLabel.Location = new Point(174, 515);
            createLabel.Name = "createLabel";
            createLabel.Size = new Size(116, 17);
            createLabel.TabIndex = 3;
            createLabel.Text = "Create an account";
            createLabel.Click += createLabel_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(50, 351);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(273, 35);
            TxtPassword.TabIndex = 6;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(381, 631);
            Controls.Add(TxtPassword);
            Controls.Add(clearBTN);
            Controls.Add(loginBTN);
            Controls.Add(showCheckBox);
            Controls.Add(createLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox showCheckBox;
        private Button loginBTN;
        private Button clearBTN;
        private Label label4;
        private Label createLabel;
        private TextBox TxtPassword;
    }
}