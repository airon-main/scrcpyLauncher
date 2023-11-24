namespace ScrcpyLauncher
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            ColorPalette.toggleDarkMode();
        }

        public void setColor(Control control)
        {
            switch (control.Tag)
            {
                case "primary":
                    control.BackColor = ColorPalette.primary;
                    break;
                case "secondary":
                    control.BackColor = ColorPalette.secondary;
                    break;
                case "disabled":
                    control.BackColor = ColorPalette.disabled;
                    break;
                case "background":
                    control.BackColor = ColorPalette.background;
                    break;
                case "carddark":
                    control.BackColor = ColorPalette.carddark;
                    break;
                case "card":
                    control.BackColor = ColorPalette.card;
                    break;
                case "text":
                    control.ForeColor = ColorPalette.text;
                    break;
            }
            foreach (Control child in control.Controls)
            {
                setColor(child);
            }
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
            if (textBoxUsername.Text != "" || textBoxPassword.Text != "")
            {
                if (textBoxPassword.Text == textBoxReenterPassword.Text)
                {
                    UserData.UserName = textBoxUsername.Text;
                    UserData.Password = textBoxPassword.Text;
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Confirm password berbeda", "Warning!", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Isi data yang dibutuhkan", "Warning!", MessageBoxButtons.OK);
            }
            //Login login = new Login();
            //login.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}