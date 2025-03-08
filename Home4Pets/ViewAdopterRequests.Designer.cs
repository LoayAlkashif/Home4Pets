namespace Home4Pets
{
    partial class ViewAdopterRequests
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
            btn_returnBack = new Button();
            dgv_adopterRequests = new DataGridView();
            btn_remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_adopterRequests).BeginInit();
            SuspendLayout();
            // 
            // btn_returnBack
            // 
            btn_returnBack.BackColor = Color.Transparent;
            btn_returnBack.Cursor = Cursors.Hand;
            btn_returnBack.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_returnBack.Location = new Point(12, 12);
            btn_returnBack.Name = "btn_returnBack";
            btn_returnBack.Size = new Size(110, 35);
            btn_returnBack.TabIndex = 2;
            btn_returnBack.Text = "Return Back";
            btn_returnBack.UseVisualStyleBackColor = false;
            btn_returnBack.Click += btn_returnBack_Click;
            // 
            // dgv_adopterRequests
            // 
            dgv_adopterRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adopterRequests.Location = new Point(12, 62);
            dgv_adopterRequests.Name = "dgv_adopterRequests";
            dgv_adopterRequests.Size = new Size(557, 150);
            dgv_adopterRequests.TabIndex = 3;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Transparent;
            btn_remove.Cursor = Cursors.Hand;
            btn_remove.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_remove.Location = new Point(605, 121);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(96, 38);
            btn_remove.TabIndex = 4;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // ViewAdopterRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 357);
            Controls.Add(btn_remove);
            Controls.Add(dgv_adopterRequests);
            Controls.Add(btn_returnBack);
            Name = "ViewAdopterRequests";
            Text = "ViewAdopterRequests";
            ((System.ComponentModel.ISupportInitialize)dgv_adopterRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_returnBack;
        private DataGridView dgv_adopterRequests;
        private Button btn_remove;
    }
}