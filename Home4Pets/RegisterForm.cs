using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home4Pets.Context;
using Home4Pets.Models;

namespace Home4Pets
{
    public partial class RegisterForm : Form
    {
        AppDbContext context;
        public RegisterForm()
        {
            InitializeComponent();
            context = new AppDbContext();

            txt_password.PasswordChar = '*';


            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            this.BackgroundImage = Image.FromFile("G:\\ITI .Net\\6 Linq & entity\\project\\Home4Pets\\Home4Pets\\Photos\\3.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label_log_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();

            loginForm.StartPosition = FormStartPosition.Manual;

            loginForm.Location = this.Location;
            loginForm.Show();

            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cb_role.Items.Add("Adopter");
            cb_role.Items.Add("PetOwner");

            cb_role.SelectedIndex = -1;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string userName = txt_username.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string phone = txt_Phone.Text;
            string role = cb_role.SelectedItem.ToString();

            User findOne = context.Users.Where(u => u.Email == email).FirstOrDefault();

            if (findOne != null)
            {
                MessageBox.Show("Email already exist");
                return;
            }

            User user = new User { Username = userName, Password = password, Email = email, Phone = phone, Role = role };


            context.Users.Add(user);

            context.SaveChanges();

            MessageBox.Show("Registered Completed");

            loginForm loginForm = new loginForm();

            loginForm.Show();

            this.Close();
        }
    }
}
