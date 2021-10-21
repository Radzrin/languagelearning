
namespace educatiom
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageTab = new System.Windows.Forms.ToolStripMenuItem();
            this.french = new System.Windows.Forms.ToolStripMenuItem();
            this.english = new System.Windows.Forms.ToolStripMenuItem();
            this.spanish = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.한글ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日本語ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简体中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.already = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.emailInvalid = new System.Windows.Forms.Label();
            this.invalidUser = new System.Windows.Forms.Label();
            this.invalidPassword = new System.Windows.Forms.Label();
            this.invalidPassword2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(496, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageTab
            // 
            this.languageTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.french,
            this.english,
            this.spanish,
            this.русскийToolStripMenuItem,
            this.한글ToolStripMenuItem,
            this.日本語ToolStripMenuItem,
            this.中文ToolStripMenuItem,
            this.简体中文ToolStripMenuItem});
            this.languageTab.Name = "languageTab";
            this.languageTab.Size = new System.Drawing.Size(91, 24);
            this.languageTab.Text = "languages";
            // 
            // french
            // 
            this.french.Image = global::educatiom.Properties.Resources.fricon;
            this.french.Name = "french";
            this.french.Size = new System.Drawing.Size(170, 26);
            this.french.Text = "Français";
            this.french.Click += new System.EventHandler(this.French_Click);
            // 
            // english
            // 
            this.english.Image = global::educatiom.Properties.Resources.engicon;
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(170, 26);
            this.english.Text = "English";
            this.english.Click += new System.EventHandler(this.English_Click);
            // 
            // spanish
            // 
            this.spanish.Image = global::educatiom.Properties.Resources.spaicon;
            this.spanish.Name = "spanish";
            this.spanish.Size = new System.Drawing.Size(170, 26);
            this.spanish.Text = "Español";
            this.spanish.Click += new System.EventHandler(this.Spanish_Click);
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Image = global::educatiom.Properties.Resources.ruicon;
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.русскийToolStripMenuItem.Text = "русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.Russian_Click);
            // 
            // 한글ToolStripMenuItem
            // 
            this.한글ToolStripMenuItem.Image = global::educatiom.Properties.Resources.koicon;
            this.한글ToolStripMenuItem.Name = "한글ToolStripMenuItem";
            this.한글ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.한글ToolStripMenuItem.Text = "한글";
            this.한글ToolStripMenuItem.Click += new System.EventHandler(this.Korean_Click);
            // 
            // 日本語ToolStripMenuItem
            // 
            this.日本語ToolStripMenuItem.Image = global::educatiom.Properties.Resources.japicon;
            this.日本語ToolStripMenuItem.Name = "日本語ToolStripMenuItem";
            this.日本語ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.日本語ToolStripMenuItem.Text = "日本語";
            this.日本語ToolStripMenuItem.Click += new System.EventHandler(this.Japanese_Click);
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Image = global::educatiom.Properties.Resources.chicon;
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.中文ToolStripMenuItem.Text = "中文 (简体)";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.Simplified_Click);
            // 
            // 简体中文ToolStripMenuItem
            // 
            this.简体中文ToolStripMenuItem.Image = global::educatiom.Properties.Resources.taicon;
            this.简体中文ToolStripMenuItem.Name = "简体中文ToolStripMenuItem";
            this.简体中文ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.简体中文ToolStripMenuItem.Text = "中文 (繁體)";
            this.简体中文ToolStripMenuItem.Click += new System.EventHandler(this.Traditional_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(195, 46);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(91, 27);
            this.SignUpLabel.TabIndex = 1;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(9, 89);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 19);
            this.email.TabIndex = 2;
            this.email.Text = "Email:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(9, 206);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(84, 19);
            this.username.TabIndex = 3;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(9, 320);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(80, 19);
            this.password.TabIndex = 4;
            this.password.Text = "Password:";
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2.Location = new System.Drawing.Point(9, 427);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(132, 19);
            this.password2.TabIndex = 5;
            this.password2.Text = "Password (again):";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(12, 128);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(439, 22);
            this.emailBox.TabIndex = 6;
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(12, 244);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNameBox.MaxLength = 21;
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(439, 22);
            this.userNameBox.TabIndex = 7;
            // 
            // passwordBox2
            // 
            this.passwordBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox2.Location = new System.Drawing.Point(12, 460);
            this.passwordBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.PasswordChar = '•';
            this.passwordBox2.Size = new System.Drawing.Size(439, 22);
            this.passwordBox2.TabIndex = 8;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(12, 361);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(439, 22);
            this.passwordBox.TabIndex = 9;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(232, 554);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(252, 89);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // already
            // 
            this.already.AutoSize = true;
            this.already.Location = new System.Drawing.Point(9, 569);
            this.already.Name = "already";
            this.already.Size = new System.Drawing.Size(171, 17);
            this.already.TabIndex = 11;
            this.already.Text = "I already have an account";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(0, 590);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(227, 53);
            this.login.TabIndex = 12;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.Login_Click);
            // 
            // emailInvalid
            // 
            this.emailInvalid.AutoSize = true;
            this.emailInvalid.ForeColor = System.Drawing.Color.Red;
            this.emailInvalid.Location = new System.Drawing.Point(11, 172);
            this.emailInvalid.Name = "emailInvalid";
            this.emailInvalid.Size = new System.Drawing.Size(0, 17);
            this.emailInvalid.TabIndex = 13;
            // 
            // invalidUser
            // 
            this.invalidUser.AutoSize = true;
            this.invalidUser.ForeColor = System.Drawing.Color.Red;
            this.invalidUser.Location = new System.Drawing.Point(12, 282);
            this.invalidUser.MaximumSize = new System.Drawing.Size(267, 0);
            this.invalidUser.Name = "invalidUser";
            this.invalidUser.Size = new System.Drawing.Size(0, 17);
            this.invalidUser.TabIndex = 14;
            // 
            // invalidPassword
            // 
            this.invalidPassword.AutoSize = true;
            this.invalidPassword.ForeColor = System.Drawing.Color.Red;
            this.invalidPassword.Location = new System.Drawing.Point(12, 395);
            this.invalidPassword.Name = "invalidPassword";
            this.invalidPassword.Size = new System.Drawing.Size(0, 17);
            this.invalidPassword.TabIndex = 15;
            // 
            // invalidPassword2
            // 
            this.invalidPassword2.AutoSize = true;
            this.invalidPassword2.ForeColor = System.Drawing.Color.Red;
            this.invalidPassword2.Location = new System.Drawing.Point(12, 498);
            this.invalidPassword2.Name = "invalidPassword2";
            this.invalidPassword2.Size = new System.Drawing.Size(0, 17);
            this.invalidPassword2.TabIndex = 16;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 655);
            this.Controls.Add(this.invalidPassword2);
            this.Controls.Add(this.invalidPassword);
            this.Controls.Add(this.invalidUser);
            this.Controls.Add(this.emailInvalid);
            this.Controls.Add(this.login);
            this.Controls.Add(this.already);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordBox2);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Close);
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageTab;
        private System.Windows.Forms.ToolStripMenuItem french;
        private System.Windows.Forms.ToolStripMenuItem english;
        private System.Windows.Forms.ToolStripMenuItem spanish;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 한글ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日本語ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简体中文ToolStripMenuItem;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label already;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label emailInvalid;
        private System.Windows.Forms.Label invalidUser;
        private System.Windows.Forms.Label invalidPassword;
        private System.Windows.Forms.Label invalidPassword2;
    }
}