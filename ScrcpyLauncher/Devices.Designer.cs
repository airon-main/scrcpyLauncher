namespace ScrcpyLauncher
{
    partial class Devices
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devices));
            windowDecorationPanel = new Panel();
            minimize = new PictureBox();
            maximize = new PictureBox();
            close = new PictureBox();
            nameLabel = new Label();
            sideBarPanel = new Panel();
            userBtn = new Button();
            settingsBtn = new Button();
            devicesBtn = new Button();
            dashboardBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            topNavPanel = new Panel();
            button1 = new Button();
            Connect = new Button();
            footerPanel = new Panel();
            deviceLabel = new Label();
            copyrightLabel = new Label();
            contentPanel = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            textBox1 = new TextBox();
            label4 = new Label();
            signupBtn = new Button();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            windowDecorationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topNavPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // windowDecorationPanel
            // 
            windowDecorationPanel.BackColor = Color.FromArgb(242, 242, 242);
            windowDecorationPanel.Controls.Add(minimize);
            windowDecorationPanel.Controls.Add(maximize);
            windowDecorationPanel.Controls.Add(close);
            windowDecorationPanel.Controls.Add(nameLabel);
            windowDecorationPanel.Dock = DockStyle.Top;
            windowDecorationPanel.ForeColor = Color.FromArgb(136, 136, 136);
            windowDecorationPanel.Location = new Point(0, 0);
            windowDecorationPanel.Margin = new Padding(10, 6, 10, 6);
            windowDecorationPanel.Name = "windowDecorationPanel";
            windowDecorationPanel.Size = new Size(1280, 33);
            windowDecorationPanel.TabIndex = 0;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.Image = (Image)resources.GetObject("minimize.Image");
            minimize.Location = new Point(1160, 0);
            minimize.Margin = new Padding(0);
            minimize.Name = "minimize";
            minimize.Size = new Size(40, 33);
            minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            minimize.TabIndex = 6;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            minimize.MouseEnter += minimize_MouseEnter;
            minimize.MouseLeave += minimize_MouseLeave;
            // 
            // maximize
            // 
            maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximize.Image = (Image)resources.GetObject("maximize.Image");
            maximize.Location = new Point(1200, 0);
            maximize.Margin = new Padding(0);
            maximize.Name = "maximize";
            maximize.Size = new Size(40, 33);
            maximize.SizeMode = PictureBoxSizeMode.StretchImage;
            maximize.TabIndex = 5;
            maximize.TabStop = false;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(1240, 0);
            close.Margin = new Padding(0);
            close.Name = "close";
            close.Size = new Size(40, 33);
            close.SizeMode = PictureBoxSizeMode.StretchImage;
            close.TabIndex = 4;
            close.TabStop = false;
            close.Click += close_Click;
            close.MouseEnter += close_MouseEnter;
            close.MouseLeave += close_MouseLeave;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.FromArgb(136, 136, 136);
            nameLabel.Location = new Point(9, 9);
            nameLabel.Margin = new Padding(0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(82, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Launcher.exe";
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = Color.White;
            sideBarPanel.Controls.Add(userBtn);
            sideBarPanel.Controls.Add(settingsBtn);
            sideBarPanel.Controls.Add(devicesBtn);
            sideBarPanel.Controls.Add(dashboardBtn);
            sideBarPanel.Controls.Add(label1);
            sideBarPanel.Controls.Add(pictureBox1);
            sideBarPanel.Dock = DockStyle.Left;
            sideBarPanel.Location = new Point(0, 33);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(200, 687);
            sideBarPanel.TabIndex = 1;
            sideBarPanel.Paint += panel2_Paint;
            // 
            // userBtn
            // 
            userBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userBtn.BackColor = Color.White;
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userBtn.ForeColor = Color.FromArgb(136, 136, 136);
            userBtn.Location = new Point(0, 246);
            userBtn.Margin = new Padding(0);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(200, 40);
            userBtn.TabIndex = 5;
            userBtn.Text = "User";
            userBtn.UseVisualStyleBackColor = false;
            userBtn.Click += userBtn_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settingsBtn.BackColor = Color.White;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            settingsBtn.ForeColor = Color.FromArgb(136, 136, 136);
            settingsBtn.Location = new Point(0, 196);
            settingsBtn.Margin = new Padding(0);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(200, 40);
            settingsBtn.TabIndex = 4;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // devicesBtn
            // 
            devicesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            devicesBtn.BackColor = Color.FromArgb(48, 221, 129);
            devicesBtn.FlatAppearance.BorderSize = 0;
            devicesBtn.FlatStyle = FlatStyle.Flat;
            devicesBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            devicesBtn.ForeColor = Color.White;
            devicesBtn.Location = new Point(0, 146);
            devicesBtn.Margin = new Padding(0);
            devicesBtn.Name = "devicesBtn";
            devicesBtn.Size = new Size(200, 40);
            devicesBtn.TabIndex = 3;
            devicesBtn.Text = "Devices";
            devicesBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dashboardBtn.BackColor = Color.White;
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardBtn.ForeColor = Color.FromArgb(136, 136, 136);
            dashboardBtn.Location = new Point(0, 96);
            dashboardBtn.Margin = new Padding(0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(200, 40);
            dashboardBtn.TabIndex = 2;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(7, 112, 99);
            label1.Location = new Point(82, 36);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 1;
            label1.Text = "ScrCpy";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(46, 30);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // topNavPanel
            // 
            topNavPanel.BackColor = Color.White;
            topNavPanel.Controls.Add(button1);
            topNavPanel.Controls.Add(Connect);
            topNavPanel.Dock = DockStyle.Top;
            topNavPanel.Location = new Point(200, 33);
            topNavPanel.Margin = new Padding(10);
            topNavPanel.Name = "topNavPanel";
            topNavPanel.Size = new Size(1080, 60);
            topNavPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(48, 221, 129);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 10);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // Connect
            // 
            Connect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Connect.BackColor = Color.FromArgb(48, 221, 129);
            Connect.FlatAppearance.BorderSize = 0;
            Connect.FlatStyle = FlatStyle.Flat;
            Connect.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Connect.ForeColor = Color.White;
            Connect.Location = new Point(11, 10);
            Connect.Margin = new Padding(0);
            Connect.Name = "Connect";
            Connect.Size = new Size(67, 40);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.TextAlign = ContentAlignment.MiddleRight;
            Connect.UseVisualStyleBackColor = false;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(242, 242, 242);
            footerPanel.Controls.Add(deviceLabel);
            footerPanel.Controls.Add(copyrightLabel);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(200, 687);
            footerPanel.Margin = new Padding(10, 6, 10, 6);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1080, 33);
            footerPanel.TabIndex = 3;
            // 
            // deviceLabel
            // 
            deviceLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deviceLabel.ForeColor = Color.FromArgb(136, 136, 136);
            deviceLabel.Location = new Point(176, 9);
            deviceLabel.Margin = new Padding(0);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new Size(895, 15);
            deviceLabel.TabIndex = 2;
            deviceLabel.Text = "Device:";
            deviceLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // copyrightLabel
            // 
            copyrightLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            copyrightLabel.AutoSize = true;
            copyrightLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            copyrightLabel.ForeColor = Color.FromArgb(136, 136, 136);
            copyrightLabel.Location = new Point(10, 9);
            copyrightLabel.Margin = new Padding(0);
            copyrightLabel.Name = "copyrightLabel";
            copyrightLabel.Size = new Size(166, 15);
            copyrightLabel.TabIndex = 1;
            copyrightLabel.Text = "Copyright ScrCpy 2018-2023";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(235, 247, 241);
            contentPanel.Controls.Add(panel3);
            contentPanel.Controls.Add(panel1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(200, 93);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1080, 594);
            contentPanel.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(signupBtn);
            panel3.Location = new Point(53, 383);
            panel3.Margin = new Padding(50, 20, 20, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(977, 161);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(49, 25);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 30;
            label5.Text = "Add Device";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(20, 20);
            pictureBox5.Margin = new Padding(20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(827, 23);
            textBox1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 61);
            label4.Margin = new Padding(20);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 26;
            label4.Text = "Device Name";
            // 
            // signupBtn
            // 
            signupBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signupBtn.BackColor = Color.FromArgb(48, 221, 129);
            signupBtn.FlatAppearance.BorderSize = 0;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            signupBtn.ForeColor = Color.White;
            signupBtn.Location = new Point(20, 99);
            signupBtn.Margin = new Padding(0);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(937, 41);
            signupBtn.TabIndex = 28;
            signupBtn.Text = "Add";
            signupBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(53, 60);
            panel1.Margin = new Padding(50, 50, 20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 293);
            panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(20, 60);
            richTextBox1.Margin = new Padding(20);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(937, 213);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(49, 25);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Devices";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(20, 20);
            pictureBox2.Margin = new Padding(20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Devices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(contentPanel);
            Controls.Add(footerPanel);
            Controls.Add(topNavPanel);
            Controls.Add(sideBarPanel);
            Controls.Add(windowDecorationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Devices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Dashboard_Load;
            windowDecorationPanel.ResumeLayout(false);
            windowDecorationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            sideBarPanel.ResumeLayout(false);
            sideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topNavPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel windowDecorationPanel;
        private Panel sideBarPanel;
        private Panel topNavPanel;
        private Panel footerPanel;
        private Label nameLabel;
        private PictureBox minimize;
        private PictureBox maximize;
        private PictureBox close;
        private Label copyrightLabel;
        private Label deviceLabel;
        private Button Connect;
        private Panel contentPanel;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button dashboardBtn;
        private Button userBtn;
        private Button settingsBtn;
        private Button devicesBtn;
        private Panel panel3;
        private Label label5;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private Label label4;
        private Button signupBtn;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}