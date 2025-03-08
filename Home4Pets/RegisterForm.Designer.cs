namespace Home4Pets
{
    partial class RegisterForm
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
            cb_role = new ComboBox();
            label_log = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btn_Register = new Button();
            txt_email = new TextBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            txt_Phone = new TextBox();
            SuspendLayout();
            // 
            // cb_role
            // 
            cb_role.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(173, 237);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(185, 29);
            cb_role.TabIndex = 4;
            // 
            // label_log
            // 
            label_log.AutoSize = true;
            label_log.BackColor = Color.Transparent;
            label_log.Cursor = Cursors.Hand;
            label_log.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_log.ForeColor = Color.Black;
            label_log.Location = new Point(313, 333);
            label_log.Name = "label_log";
            label_log.Size = new Size(43, 20);
            label_log.TabIndex = 22;
            label_log.Text = "login";
            label_log.Click += label_log_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(53, 237);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 13;
            label8.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(53, 184);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 15;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(51, 85);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(51, 137);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(53, 36);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 18;
            label3.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(157, 335);
            label1.Name = "label1";
            label1.Size = new Size(150, 17);
            label1.TabIndex = 19;
            label1.Text = "Already have an account";
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.Transparent;
            btn_Register.Cursor = Cursors.Hand;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Segoe UI Symbol", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Register.Location = new Point(197, 281);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(124, 34);
            btn_Register.TabIndex = 5;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(171, 87);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(185, 29);
            txt_email.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(171, 139);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(185, 29);
            txt_password.TabIndex = 2;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(173, 36);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(185, 29);
            txt_username.TabIndex = 0;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(173, 189);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(185, 23);
            txt_Phone.TabIndex = 3;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(484, 461);
            Controls.Add(txt_Phone);
            Controls.Add(cb_role);
            Controls.Add(label_log);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btn_Register);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_role;
        private Label label_log;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btn_Register;
        private TextBox txt_email;
        private TextBox txt_password;
        private TextBox txt_username;
        private TextBox txt_Phone;
    }
}