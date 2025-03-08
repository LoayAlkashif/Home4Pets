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

namespace Home4Pets
{
    public partial class loginForm : Form
    {
        AppDbContext context;
        public loginForm()
        {
            InitializeComponent();
            context = new AppDbContext();

            txt_password.PasswordChar = '*';


            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            this.BackgroundImage = Image.FromFile("G:\\ITI .Net\\6 Linq & entity\\project\\Home4Pets\\Home4Pets\\Photos\\3.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void create_one_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.StartPosition = FormStartPosition.Manual;

            registerForm.Location = this.Location;
            registerForm.Show();

            this.Close();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please insert Data FIrst");
            }


            var userFound = context.Users.Where(u =>  u.Email == email &&  u.Password == password ).FirstOrDefault();

            if (userFound != null)
            {
                if(userFound.Role == "Adopter")
                {
                    MessageBox.Show("Logged in successfuly");
                    AdopterForm adopterForm = new AdopterForm(userFound);
                    adopterForm.StartPosition = FormStartPosition.Manual;

                    adopterForm.Location = this.Location;
                    adopterForm.Show();

                    this.Close();
                }
                else if (userFound.Role == "PetOwner")
                {
                    PetOwnerForm petOwnerForm = new PetOwnerForm(userFound);

                    petOwnerForm.StartPosition = FormStartPosition.Manual;
                    petOwnerForm.Location = this.Location;
                    petOwnerForm.Show();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }

        }
    }
}
