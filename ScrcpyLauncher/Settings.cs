using System.Diagnostics;

namespace ScrcpyLauncher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            deviceLabel.Text = "No Device Connected";
            textBoxFilePath.Text = UserData.ScrcpyPath;
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

        private void devicesBtn_Click(object sender, EventArgs e)
        {
            Devices devices = new Devices();
            devices.Show();
            this.Hide();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try { Process.Start(UserData.ScrcpyPath); }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("File Scrcpy tidak ditemukan", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            UserData.ScrcpyPath = textBoxFilePath.Text;
            textBoxFilePath.Text = UserData.ScrcpyPath;
        }
    }
}