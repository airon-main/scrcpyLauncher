namespace ScrcpyLauncher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
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
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            textBoxFilePath = new TextBox();
            clearBtn = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            confirmBtn = new Button();
            windowDecorationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topNavPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            settingsBtn.BackColor = Color.FromArgb(48, 221, 129);
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            settingsBtn.ForeColor = Color.White;
            settingsBtn.Location = new Point(0, 196);
            settingsBtn.Margin = new Padding(0);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(200, 40);
            settingsBtn.TabIndex = 4;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = false;
            // 
            // devicesBtn
            // 
            devicesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            devicesBtn.BackColor = Color.White;
            devicesBtn.FlatAppearance.BorderSize = 0;
            devicesBtn.FlatStyle = FlatStyle.Flat;
            devicesBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            devicesBtn.ForeColor = Color.FromArgb(136, 136, 136);
            devicesBtn.Location = new Point(0, 146);
            devicesBtn.Margin = new Padding(0);
            devicesBtn.Name = "devicesBtn";
            devicesBtn.Size = new Size(200, 40);
            devicesBtn.TabIndex = 3;
            devicesBtn.Text = "Devices";
            devicesBtn.UseVisualStyleBackColor = false;
            devicesBtn.Click += devicesBtn_Click;
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
            Connect.Click += Connect_Click;
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
            contentPanel.Controls.Add(panel1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(200, 93);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1080, 594);
            contentPanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(confirmBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(53, 60);
            panel1.Margin = new Padding(50);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 478);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 75);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 59;
            label3.Text = "File Path";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 242, 242);
            panel2.Controls.Add(textBoxFilePath);
            panel2.Location = new Point(94, 60);
            panel2.Margin = new Padding(20);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6, 15, 6, 15);
            panel2.Size = new Size(863, 46);
            panel2.TabIndex = 58;
            panel2.Tag = "card";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.BackColor = Color.FromArgb(242, 242, 242);
            textBoxFilePath.BorderStyle = BorderStyle.None;
            textBoxFilePath.Dock = DockStyle.Fill;
            textBoxFilePath.Location = new Point(6, 15);
            textBoxFilePath.Margin = new Padding(0);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(851, 16);
            textBoxFilePath.TabIndex = 27;
            textBoxFilePath.Tag = "card";
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearBtn.BackColor = Color.FromArgb(136, 136, 136);
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(1669, 16);
            clearBtn.Margin = new Padding(0);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(65, 33);
            clearBtn.TabIndex = 29;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
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
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Settings";
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
            // confirmBtn
            // 
            confirmBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            confirmBtn.BackColor = Color.FromArgb(48, 221, 129);
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(20, 126);
            confirmBtn.Margin = new Padding(0);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(937, 47);
            confirmBtn.TabIndex = 60;
            confirmBtn.Text = "Confirm Changes";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // Settings
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
            Name = "Settings";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Button clearBtn;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel2;
        private TextBox textBoxFilePath;
        private Button confirmBtn;
    }
}