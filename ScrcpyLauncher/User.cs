using System.Diagnostics;

namespace ScrcpyLauncher
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            deviceLabel.Text = "No Device Connected";
            textBoxUsername.Text = UserData.UserName;
            textBoxPassword.Text = UserData.Password;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, sideBarPanel.ClientRectangle,
               ColorTranslator.FromHtml("#d3ded9"), 0, ButtonBorderStyle.Solid, // left
               ColorTranslator.FromHtml("#d3ded9"), 0, ButtonBorderStyle.Solid, // top
               ColorTranslator.FromHtml("#d3ded9"), 1, ButtonBorderStyle.Solid, // right
               ColorTranslator.FromHtml("#d3ded9"), 0, ButtonBorderStyle.Solid);// bottom
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

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void devicesBtn_Click(object sender, EventArgs e)
        {
            Devices devices = new Devices();
            devices.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin ingin Logout?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserData.UserName = "";
                UserData.Password = "";
                DevicesData.Devices.Clear();
                Signup signup = new Signup();
                signup.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void confirmEditBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin ingin mengubah data?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserData.UserName = textBoxUsername.Text;
                UserData.Password = textBoxPassword.Text;
                textBoxUsername.Text = UserData.UserName;
                textBoxPassword.Text = UserData.Password;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try { Process.Start(UserData.ScrcpyPath); }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("File Scrcpy tidak ditemukan", "Warning!", MessageBoxButtons.OK);
            }
        }
    }
}