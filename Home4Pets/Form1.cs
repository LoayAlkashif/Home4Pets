namespace Home4Pets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            this.BackgroundImage = Image.FromFile("G:\\ITI .Net\\6 Linq & entity\\project\\Home4Pets\\Home4Pets\\Photos\\3.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.StartPosition = FormStartPosition.Manual;

            loginForm.Location = this.Location;

            loginForm.Show();

            this.Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.StartPosition = FormStartPosition.Manual;

            registerForm.Location = this.Location;
            registerForm.Show();

            this.Hide();
        }
    }
}
