namespace ScrcpyLauncher
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxFilePath.Text = "C:\\Users\\Aaron\\Downloads\\Compressed\\scrcpy-win64-v2.1.1\\scrcpy.exe";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.Transparent;
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.BackColor = ColorTranslator.FromHtml("#dadada");
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.Transparent;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" || textBoxPassword.Text != "")
            {
                if (textBoxUsername.Text == UserData.UserName && textBoxPassword.Text == UserData.Password)
                {
                    UserData.ScrcpyPath = textBoxFilePath.Text;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Username atau Password Salah, maukah anda menghapus yang sudah anda masukkan?", "Warning!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                        textBoxFilePath.Text = "";
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Isi data yang dibutuhkan", "Warning!", MessageBoxButtons.OK);
            }
        }
    }
}