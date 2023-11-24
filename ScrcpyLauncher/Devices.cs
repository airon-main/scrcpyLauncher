namespace ScrcpyLauncher
{
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
            deviceLabel.Text = "No Device Connected";
            string combinedDevices = string.Join("\n", DevicesData.Devices);
            richTextBoxDevicesList.Text = combinedDevices;
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
            Credits settings = new Credits();
            settings.Show();
            this.Hide();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin ingin menghapus semua data?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DevicesData.Devices.Clear();
                string combinedDevices = string.Join("\n", DevicesData.Devices);
                richTextBoxDevicesList.Text = combinedDevices;
            }
        }

        private void addDeviceBtn_Click(object sender, EventArgs e)
        {
            if (textBoxDeviceName.Text != "")
            {
                DevicesData.Devices.Add(textBoxDeviceName.Text);
                textBoxDeviceName.Text = string.Empty;
                string combinedDevices = string.Join("\n", DevicesData.Devices);
                richTextBoxDevicesList.Text = combinedDevices;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Isi data yang dibutuhkan", "Warning!", MessageBoxButtons.OK);
            }
        }
    }
}