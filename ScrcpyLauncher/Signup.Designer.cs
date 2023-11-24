namespace ScrcpyLauncher
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            windowDecorationPanel = new Panel();
            minimize = new PictureBox();
            maximize = new PictureBox();
            close = new PictureBox();
            nameLabel = new Label();
            footerPanel = new Panel();
            copyrightLabel = new Label();
            contentPanel = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            textBoxUsername = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBoxPassword = new TextBox();
            panel1 = new Panel();
            textBoxReenterPassword = new TextBox();
            signupBtn = new Button();
            button1 = new Button();
            label5 = new Label();
            windowDecorationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            footerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(242, 242, 242);
            footerPanel.Controls.Add(copyrightLabel);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 687);
            footerPanel.Margin = new Padding(10, 6, 10, 6);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1280, 33);
            footerPanel.TabIndex = 3;
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
            contentPanel.Controls.Add(label1);
            contentPanel.Controls.Add(pictureBox2);
            contentPanel.Controls.Add(label6);
            contentPanel.Controls.Add(label4);
            contentPanel.Controls.Add(panel3);
            contentPanel.Controls.Add(label3);
            contentPanel.Controls.Add(panel2);
            contentPanel.Controls.Add(panel1);
            contentPanel.Controls.Add(signupBtn);
            contentPanel.Controls.Add(button1);
            contentPanel.Controls.Add(label5);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 33);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1280, 654);
            contentPanel.TabIndex = 4;
            contentPanel.Tag = "background";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(136, 136, 136);
            label1.Location = new Point(561, 178);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 48;
            label1.Tag = "text";
            label1.Text = "Welcome to";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(639, 166);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(7, 112, 99);
            label6.Location = new Point(672, 172);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 46;
            label6.Tag = "";
            label6.Text = "ScrCpy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(228, 298);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 39;
            label4.Tag = "text";
            label4.Text = "Password";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBoxUsername);
            panel3.Location = new Point(356, 222);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(6, 15, 6, 15);
            panel3.Size = new Size(698, 46);
            panel3.TabIndex = 45;
            panel3.Tag = "card";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Dock = DockStyle.Fill;
            textBoxUsername.Location = new Point(6, 15);
            textBoxUsername.Margin = new Padding(0);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(686, 16);
            textBoxUsername.TabIndex = 25;
            textBoxUsername.Tag = "card";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(227, 238);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 38;
            label3.Tag = "text";
            label3.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxPassword);
            panel2.Location = new Point(356, 278);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6, 15, 6, 15);
            panel2.Size = new Size(698, 46);
            panel2.TabIndex = 44;
            panel2.Tag = "card";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Location = new Point(6, 15);
            textBoxPassword.Margin = new Padding(0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(686, 16);
            textBoxPassword.TabIndex = 27;
            textBoxPassword.Tag = "card";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxReenterPassword);
            panel1.Location = new Point(356, 335);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 15, 6, 15);
            panel1.Size = new Size(698, 46);
            panel1.TabIndex = 43;
            panel1.Tag = "card";
            // 
            // textBoxReenterPassword
            // 
            textBoxReenterPassword.BackColor = Color.White;
            textBoxReenterPassword.BorderStyle = BorderStyle.None;
            textBoxReenterPassword.Dock = DockStyle.Fill;
            textBoxReenterPassword.Location = new Point(6, 15);
            textBoxReenterPassword.Margin = new Padding(10, 10, 10, 0);
            textBoxReenterPassword.Name = "textBoxReenterPassword";
            textBoxReenterPassword.PasswordChar = '*';
            textBoxReenterPassword.Size = new Size(686, 16);
            textBoxReenterPassword.TabIndex = 30;
            textBoxReenterPassword.Tag = "card";
            // 
            // signupBtn
            // 
            signupBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signupBtn.BackColor = Color.FromArgb(48, 221, 129);
            signupBtn.FlatAppearance.BorderSize = 0;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            signupBtn.ForeColor = Color.White;
            signupBtn.Location = new Point(228, 391);
            signupBtn.Margin = new Padding(5);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(826, 47);
            signupBtn.TabIndex = 40;
            signupBtn.Text = "Signup";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(136, 136, 136);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(228, 448);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(826, 41);
            button1.TabIndex = 42;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(228, 355);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 41;
            label5.Tag = "text";
            label5.Text = "Reenter Password";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(contentPanel);
            Controls.Add(footerPanel);
            Controls.Add(windowDecorationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Dashboard_Load;
            windowDecorationPanel.ResumeLayout(false);
            windowDecorationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel windowDecorationPanel;
        private Panel footerPanel;
        private Label nameLabel;
        private PictureBox minimize;
        private PictureBox maximize;
        private PictureBox close;
        private Label copyrightLabel;
        private Panel contentPanel;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label4;
        private Panel panel3;
        private TextBox textBoxUsername;
        private Label label3;
        private Panel panel2;
        private TextBox textBoxPassword;
        private Panel panel1;
        private TextBox textBoxReenterPassword;
        private Button signupBtn;
        private Button button1;
        private Label label5;
    }
}