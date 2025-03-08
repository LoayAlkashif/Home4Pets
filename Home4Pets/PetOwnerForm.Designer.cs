namespace Home4Pets
{
    partial class PetOwnerForm
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
            dgv_Pets = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_petName = new TextBox();
            cb_petType = new ComboBox();
            txt_description = new RichTextBox();
            nud_age = new NumericUpDown();
            cb_gender = new ComboBox();
            cb_healthStatus = new ComboBox();
            cb_vaccinationStatus = new ComboBox();
            btn_addPet = new Button();
            btn_logout = new Button();
            btn_viewPetRequests = new Button();
            btn_updatePet = new Button();
            btn_deletePet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Pets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            SuspendLayout();
            // 
            // dgv_Pets
            // 
            dgv_Pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Pets.Location = new Point(12, 43);
            dgv_Pets.Name = "dgv_Pets";
            dgv_Pets.Size = new Size(816, 153);
            dgv_Pets.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 11.25F);
            label1.Location = new Point(23, 203);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Pet Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 11.25F);
            label2.Location = new Point(356, 203);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Pet Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 11.25F);
            label3.Location = new Point(23, 255);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 11.25F);
            label4.Location = new Point(356, 249);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 1;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 11.25F);
            label5.Location = new Point(23, 295);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 1;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 11.25F);
            label6.Location = new Point(356, 292);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 1;
            label6.Text = "Health Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 11.25F);
            label7.Location = new Point(23, 335);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 1;
            label7.Text = "Vaccination Status";
            // 
            // txt_petName
            // 
            txt_petName.Font = new Font("Segoe UI Symbol", 11.25F);
            txt_petName.Location = new Point(160, 202);
            txt_petName.Name = "txt_petName";
            txt_petName.Size = new Size(150, 27);
            txt_petName.TabIndex = 0;
            // 
            // cb_petType
            // 
            cb_petType.Font = new Font("Segoe UI Symbol", 11.25F);
            cb_petType.FormattingEnabled = true;
            cb_petType.Location = new Point(493, 203);
            cb_petType.Name = "cb_petType";
            cb_petType.Size = new Size(150, 28);
            cb_petType.TabIndex = 2;
            // 
            // txt_description
            // 
            txt_description.Font = new Font("Segoe UI Symbol", 11.25F);
            txt_description.Location = new Point(160, 251);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(150, 26);
            txt_description.TabIndex = 3;
            txt_description.Text = "";
            // 
            // nud_age
            // 
            nud_age.Font = new Font("Segoe UI Symbol", 11.25F);
            nud_age.Location = new Point(493, 249);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(150, 27);
            nud_age.TabIndex = 4;
            // 
            // cb_gender
            // 
            cb_gender.Font = new Font("Segoe UI Symbol", 11.25F);
            cb_gender.FormattingEnabled = true;
            cb_gender.Location = new Point(160, 294);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(150, 28);
            cb_gender.TabIndex = 5;
            // 
            // cb_healthStatus
            // 
            cb_healthStatus.Font = new Font("Segoe UI Symbol", 11.25F);
            cb_healthStatus.FormattingEnabled = true;
            cb_healthStatus.Location = new Point(493, 289);
            cb_healthStatus.Name = "cb_healthStatus";
            cb_healthStatus.Size = new Size(150, 28);
            cb_healthStatus.TabIndex = 6;
            // 
            // cb_vaccinationStatus
            // 
            cb_vaccinationStatus.Font = new Font("Segoe UI Symbol", 11.25F);
            cb_vaccinationStatus.FormattingEnabled = true;
            cb_vaccinationStatus.Location = new Point(160, 334);
            cb_vaccinationStatus.Name = "cb_vaccinationStatus";
            cb_vaccinationStatus.Size = new Size(150, 28);
            cb_vaccinationStatus.TabIndex = 7;
            // 
            // btn_addPet
            // 
            btn_addPet.BackColor = Color.Transparent;
            btn_addPet.Cursor = Cursors.Hand;
            btn_addPet.Font = new Font("Segoe UI Symbol", 11.25F);
            btn_addPet.Location = new Point(356, 337);
            btn_addPet.Name = "btn_addPet";
            btn_addPet.Size = new Size(117, 34);
            btn_addPet.TabIndex = 8;
            btn_addPet.Text = "Add Pet";
            btn_addPet.UseVisualStyleBackColor = false;
            btn_addPet.Click += btn_addPet_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(825, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(93, 34);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_viewPetRequests
            // 
            btn_viewPetRequests.BackColor = Color.Transparent;
            btn_viewPetRequests.Cursor = Cursors.Hand;
            btn_viewPetRequests.Font = new Font("Segoe UI Symbol", 11.25F);
            btn_viewPetRequests.Location = new Point(493, 334);
            btn_viewPetRequests.Name = "btn_viewPetRequests";
            btn_viewPetRequests.Size = new Size(116, 39);
            btn_viewPetRequests.TabIndex = 9;
            btn_viewPetRequests.Text = "View Requests";
            btn_viewPetRequests.UseVisualStyleBackColor = false;
            btn_viewPetRequests.Click += btn_viewPetRequests_Click;
            // 
            // btn_updatePet
            // 
            btn_updatePet.BackColor = Color.Transparent;
            btn_updatePet.Cursor = Cursors.Hand;
            btn_updatePet.Font = new Font("Segoe UI Symbol", 11.25F);
            btn_updatePet.Location = new Point(105, 400);
            btn_updatePet.Name = "btn_updatePet";
            btn_updatePet.Size = new Size(75, 31);
            btn_updatePet.TabIndex = 10;
            btn_updatePet.Text = "Update";
            btn_updatePet.UseVisualStyleBackColor = false;
            btn_updatePet.Click += btn_updatePet_Click;
            // 
            // btn_deletePet
            // 
            btn_deletePet.BackColor = Color.Transparent;
            btn_deletePet.Cursor = Cursors.Hand;
            btn_deletePet.Font = new Font("Segoe UI Symbol", 11.25F);
            btn_deletePet.Location = new Point(218, 400);
            btn_deletePet.Name = "btn_deletePet";
            btn_deletePet.Size = new Size(75, 31);
            btn_deletePet.TabIndex = 11;
            btn_deletePet.Text = "Delete";
            btn_deletePet.UseVisualStyleBackColor = false;
            btn_deletePet.Click += btn_deletePet_Click;
            // 
            // PetOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 491);
            Controls.Add(btn_deletePet);
            Controls.Add(btn_updatePet);
            Controls.Add(btn_viewPetRequests);
            Controls.Add(btn_logout);
            Controls.Add(btn_addPet);
            Controls.Add(cb_vaccinationStatus);
            Controls.Add(cb_healthStatus);
            Controls.Add(cb_gender);
            Controls.Add(nud_age);
            Controls.Add(txt_description);
            Controls.Add(cb_petType);
            Controls.Add(txt_petName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Pets);
            Name = "PetOwnerForm";
            Text = "PetOwnerForm";
            ((System.ComponentModel.ISupportInitialize)dgv_Pets).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Pets;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_petName;
        private ComboBox cb_petType;
        private RichTextBox txt_description;
        private NumericUpDown nud_age;
        private ComboBox cb_gender;
        private ComboBox cb_healthStatus;
        private ComboBox cb_vaccinationStatus;
        private Button btn_addPet;
        private Button btn_logout;
        private Button btn_viewPetRequests;
        private Button btn_updatePet;
        private Button btn_deletePet;
    }
}