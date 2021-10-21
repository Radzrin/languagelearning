
namespace educatiom
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageTab = new System.Windows.Forms.ToolStripMenuItem();
            this.french = new System.Windows.Forms.ToolStripMenuItem();
            this.english = new System.Windows.Forms.ToolStripMenuItem();
            this.spanish = new System.Windows.Forms.ToolStripMenuItem();
            this.russian = new System.Windows.Forms.ToolStripMenuItem();
            this.korean = new System.Windows.Forms.ToolStripMenuItem();
            this.japanese = new System.Windows.Forms.ToolStripMenuItem();
            this.simpChinese = new System.Windows.Forms.ToolStripMenuItem();
            this.tradChinese = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Forgot = new System.Windows.Forms.LinkLabel();
            this.Info = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.newAcc = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.languageTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(612, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageTab
            // 
            this.languageTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.french,
            this.english,
            this.spanish,
            this.russian,
            this.korean,
            this.japanese,
            this.simpChinese,
            this.tradChinese});
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
            // russian
            // 
            this.russian.Image = global::educatiom.Properties.Resources.ruicon;
            this.russian.Name = "russian";
            this.russian.Size = new System.Drawing.Size(170, 26);
            this.russian.Text = "русский";
            this.russian.Click += new System.EventHandler(this.Russian_Click);
            // 
            // korean
            // 
            this.korean.Image = global::educatiom.Properties.Resources.koicon;
            this.korean.Name = "korean";
            this.korean.Size = new System.Drawing.Size(170, 26);
            this.korean.Text = "한글";
            this.korean.Click += new System.EventHandler(this.Korean_Click);
            // 
            // japanese
            // 
            this.japanese.Image = global::educatiom.Properties.Resources.japicon;
            this.japanese.Name = "japanese";
            this.japanese.Size = new System.Drawing.Size(170, 26);
            this.japanese.Text = "日本語";
            this.japanese.Click += new System.EventHandler(this.Japanese_Click);
            // 
            // simpChinese
            // 
            this.simpChinese.Image = global::educatiom.Properties.Resources.chicon;
            this.simpChinese.Name = "simpChinese";
            this.simpChinese.Size = new System.Drawing.Size(170, 26);
            this.simpChinese.Text = "中文 (简体)";
            this.simpChinese.Click += new System.EventHandler(this.Simplified_Click);
            // 
            // tradChinese
            // 
            this.tradChinese.Image = global::educatiom.Properties.Resources.taicon;
            this.tradChinese.Name = "tradChinese";
            this.tradChinese.Size = new System.Drawing.Size(170, 26);
            this.tradChinese.Text = "中文 (繁體)";
            this.tradChinese.Click += new System.EventHandler(this.Traditional_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 174);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // Forgot
            // 
            this.Forgot.AutoSize = true;
            this.Forgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Forgot.Location = new System.Drawing.Point(457, 341);
            this.Forgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Forgot.Name = "Forgot";
            this.Forgot.Size = new System.Drawing.Size(138, 17);
            this.Forgot.TabIndex = 3;
            this.Forgot.TabStop = true;
            this.Forgot.Text = "I forgot my password";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(-3, 81);
            this.Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(230, 24);
            this.Info.TabIndex = 4;
            this.Info.Text = "Name/ Username/ Email: ";
            // 
            // LogIn
            // 
            this.LogIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.Location = new System.Drawing.Point(13, 249);
            this.LogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(233, 65);
            this.LogIn.TabIndex = 5;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // newAcc
            // 
            this.newAcc.AutoSize = true;
            this.newAcc.BackColor = System.Drawing.Color.Transparent;
            this.newAcc.Location = new System.Drawing.Point(367, 42);
            this.newAcc.Name = "newAcc";
            this.newAcc.Size = new System.Drawing.Size(155, 17);
            this.newAcc.TabIndex = 6;
            this.newAcc.Text = "I don\'t have an account";
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(528, 34);
            this.SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(84, 31);
            this.SignUp.TabIndex = 7;
            this.SignUp.Text = "Sign up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(-3, 146);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(95, 24);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password:";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::educatiom.Properties.Resources.valley;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 368);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.newAcc);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Forgot);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel Forgot;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label newAcc;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.ToolStripMenuItem languageTab;
        private System.Windows.Forms.ToolStripMenuItem french;
        private System.Windows.Forms.ToolStripMenuItem english;
        private System.Windows.Forms.ToolStripMenuItem spanish;
        private System.Windows.Forms.ToolStripMenuItem russian;
        private System.Windows.Forms.ToolStripMenuItem korean;
        private System.Windows.Forms.ToolStripMenuItem japanese;
        private System.Windows.Forms.ToolStripMenuItem simpChinese;
        private System.Windows.Forms.ToolStripMenuItem tradChinese;
    }
}