namespace Home4Pets
{
    partial class loginForm
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
            create_one = new Label();
            btn_SignIn = new Button();
            label_msg1 = new Label();
            label_Password = new Label();
            label_Email = new Label();
            txt_password = new TextBox();
            txt_email = new TextBox();
            SuspendLayout();
            // 
            // create_one
            // 
            create_one.AutoSize = true;
            create_one.BackColor = Color.Transparent;
            create_one.Cursor = Cursors.Hand;
            create_one.Font = new Font("Segoe UI Symbol", 11.25F);
            create_one.Location = new Point(291, 269);
            create_one.Name = "create_one";
            create_one.Size = new Size(83, 20);
            create_one.TabIndex = 10;
            create_one.Text = "Create One";
            create_one.Click += create_one_Click;
            // 
            // btn_SignIn
            // 
            btn_SignIn.BackColor = Color.Transparent;
            btn_SignIn.Cursor = Cursors.Hand;
            btn_SignIn.FlatStyle = FlatStyle.Flat;
            btn_SignIn.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SignIn.Location = new Point(149, 215);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new Size(237, 41);
            btn_SignIn.TabIndex = 9;
            btn_SignIn.Text = "SignIn";
            btn_SignIn.UseVisualStyleBackColor = false;
            btn_SignIn.Click += btn_SignIn_Click;
            // 
            // label_msg1
            // 
            label_msg1.AutoSize = true;
            label_msg1.BackColor = Color.Transparent;
            label_msg1.Font = new Font("Segoe UI Symbol", 11.25F);
            label_msg1.Location = new Point(159, 269);
            label_msg1.Name = "label_msg1";
            label_msg1.Size = new Size(136, 20);
            label_msg1.TabIndex = 5;
            label_msg1.Text = "Don't have account";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.BackColor = Color.Transparent;
            label_Password.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Password.Location = new Point(35, 176);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(100, 25);
            label_Password.TabIndex = 6;
            label_Password.Text = "Password";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.BackColor = Color.Transparent;
            label_Email.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Email.Location = new Point(35, 119);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(63, 26);
            label_Email.TabIndex = 7;
            label_Email.Text = "Email";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(149, 169);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(237, 35);
            txt_password.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(149, 113);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(237, 35);
            txt_email.TabIndex = 4;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(create_one);
            Controls.Add(btn_SignIn);
            Controls.Add(label_msg1);
            Controls.Add(label_Password);
            Controls.Add(label_Email);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Name = "loginForm";
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label create_one;
        private Button btn_SignIn;
        private Label label_msg1;
        private Label label_Password;
        private Label label_Email;
        private TextBox txt_password;
        private TextBox txt_email;
    }
}