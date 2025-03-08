namespace Home4Pets
{
    partial class ViewPetAdoptionRequests
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
            dgv_petRequests = new DataGridView();
            btn_returnBack = new Button();
            btn_approveRequest = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_petRequests).BeginInit();
            SuspendLayout();
            // 
            // dgv_petRequests
            // 
            dgv_petRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_petRequests.Location = new Point(12, 73);
            dgv_petRequests.Name = "dgv_petRequests";
            dgv_petRequests.Size = new Size(715, 160);
            dgv_petRequests.TabIndex = 0;
            // 
            // btn_returnBack
            // 
            btn_returnBack.BackColor = Color.Transparent;
            btn_returnBack.Cursor = Cursors.Hand;
            btn_returnBack.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_returnBack.Location = new Point(12, 12);
            btn_returnBack.Name = "btn_returnBack";
            btn_returnBack.Size = new Size(110, 34);
            btn_returnBack.TabIndex = 1;
            btn_returnBack.Text = "Return Back";
            btn_returnBack.UseVisualStyleBackColor = false;
            btn_returnBack.Click += btn_returnBack_Click;
            // 
            // btn_approveRequest
            // 
            btn_approveRequest.Cursor = Cursors.Hand;
            btn_approveRequest.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_approveRequest.Location = new Point(272, 270);
            btn_approveRequest.Name = "btn_approveRequest";
            btn_approveRequest.Size = new Size(159, 36);
            btn_approveRequest.TabIndex = 2;
            btn_approveRequest.Text = "Approve Request";
            btn_approveRequest.UseVisualStyleBackColor = true;
            btn_approveRequest.Click += btn_approveRequest_Click;
            // 
            // ViewPetAdoptionRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 450);
            Controls.Add(btn_approveRequest);
            Controls.Add(btn_returnBack);
            Controls.Add(dgv_petRequests);
            Name = "ViewPetAdoptionRequests";
            Text = "ViewPetAdoptionRequests";
            ((System.ComponentModel.ISupportInitialize)dgv_petRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_petRequests;
        private Button btn_returnBack;
        private Button btn_approveRequest;
    }
}