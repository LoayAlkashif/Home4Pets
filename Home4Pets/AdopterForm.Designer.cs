namespace Home4Pets
{
    partial class AdopterForm
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
            dgv_AvailablePets = new DataGridView();
            lab_userName = new Label();
            label1 = new Label();
            btn_logout = new Button();
            btn_requestAdoption = new Button();
            viewRequests = new Button();
            txt_remarks = new RichTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_AvailablePets).BeginInit();
            SuspendLayout();
            // 
            // dgv_AvailablePets
            // 
            dgv_AvailablePets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AvailablePets.Location = new Point(12, 50);
            dgv_AvailablePets.Name = "dgv_AvailablePets";
            dgv_AvailablePets.Size = new Size(736, 189);
            dgv_AvailablePets.TabIndex = 0;
            // 
            // lab_userName
            // 
            lab_userName.AutoSize = true;
            lab_userName.BackColor = Color.Transparent;
            lab_userName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            lab_userName.Location = new Point(404, 17);
            lab_userName.Name = "lab_userName";
            lab_userName.Size = new Size(87, 21);
            lab_userName.TabIndex = 1;
            lab_userName.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            label1.Location = new Point(324, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(713, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(86, 32);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_requestAdoption
            // 
            btn_requestAdoption.BackColor = Color.Transparent;
            btn_requestAdoption.Cursor = Cursors.Hand;
            btn_requestAdoption.FlatStyle = FlatStyle.Flat;
            btn_requestAdoption.Font = new Font("Segoe UI Symbol", 11.25F);
            btn_requestAdoption.Location = new Point(180, 352);
            btn_requestAdoption.Name = "btn_requestAdoption";
            btn_requestAdoption.Size = new Size(143, 34);
            btn_requestAdoption.TabIndex = 4;
            btn_requestAdoption.Text = "Request Adoption";
            btn_requestAdoption.UseVisualStyleBackColor = false;
            btn_requestAdoption.Click += btn_requestAdoption_Click;
            // 
            // viewRequests
            // 
            viewRequests.BackColor = Color.Transparent;
            viewRequests.Cursor = Cursors.Hand;
            viewRequests.FlatStyle = FlatStyle.Flat;
            viewRequests.Font = new Font("Segoe UI Symbol", 11.25F);
            viewRequests.Location = new Point(425, 352);
            viewRequests.Name = "viewRequests";
            viewRequests.Size = new Size(143, 34);
            viewRequests.TabIndex = 4;
            viewRequests.Text = "View Requests";
            viewRequests.UseVisualStyleBackColor = false;
            viewRequests.Click += viewRequests_Click;
            // 
            // txt_remarks
            // 
            txt_remarks.Location = new Point(257, 264);
            txt_remarks.Name = "txt_remarks";
            txt_remarks.Size = new Size(249, 64);
            txt_remarks.TabIndex = 5;
            txt_remarks.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(180, 282);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Remarks";
            // 
            // AdopterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 487);
            Controls.Add(label4);
            Controls.Add(txt_remarks);
            Controls.Add(viewRequests);
            Controls.Add(btn_requestAdoption);
            Controls.Add(btn_logout);
            Controls.Add(label1);
            Controls.Add(lab_userName);
            Controls.Add(dgv_AvailablePets);
            Name = "AdopterForm";
            Text = "AdopterForm";
            ((System.ComponentModel.ISupportInitialize)dgv_AvailablePets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_AvailablePets;
        private Label lab_userName;
        private Label label1;
        private Button btn_logout;
        private Button btn_requestAdoption;
        private Button viewRequests;
        private RichTextBox txt_remarks;
        private Label label4;
    }
}