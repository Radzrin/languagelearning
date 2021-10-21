
namespace educatiom
{
    partial class UserPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.RadioButton();
            this.optionButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statButtons = new System.Windows.Forms.RadioButton();
            this.learnButton = new System.Windows.Forms.RadioButton();
            this.HomeButton = new System.Windows.Forms.RadioButton();
            this.namePanel = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayPannel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.optionButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.statButtons);
            this.panel1.Controls.Add(this.learnButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 455);
            this.panel1.TabIndex = 2;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logoutButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.Red;
            this.logoutButton.Location = new System.Drawing.Point(-1, 400);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(151, 57);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.OnCLick);
            // 
            // optionButton
            // 
            this.optionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionButton.FlatAppearance.BorderSize = 0;
            this.optionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton.ForeColor = System.Drawing.Color.White;
            this.optionButton.Location = new System.Drawing.Point(0, 273);
            this.optionButton.Name = "optionButton";
            this.optionButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.optionButton.Size = new System.Drawing.Size(150, 57);
            this.optionButton.TabIndex = 8;
            this.optionButton.Text = "Settings";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.CheckedChanged += new System.EventHandler(this.Settings_Changed);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 83);
            this.panel2.TabIndex = 3;
            // 
            // statButtons
            // 
            this.statButtons.Appearance = System.Windows.Forms.Appearance.Button;
            this.statButtons.FlatAppearance.BorderSize = 0;
            this.statButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statButtons.ForeColor = System.Drawing.Color.White;
            this.statButtons.Location = new System.Drawing.Point(-1, 210);
            this.statButtons.Name = "statButtons";
            this.statButtons.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.statButtons.Size = new System.Drawing.Size(151, 57);
            this.statButtons.TabIndex = 7;
            this.statButtons.Text = "Stats";
            this.statButtons.UseVisualStyleBackColor = true;
            this.statButtons.CheckedChanged += new System.EventHandler(this.Stat_Changed);
            // 
            // learnButton
            // 
            this.learnButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.learnButton.FlatAppearance.BorderSize = 0;
            this.learnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learnButton.ForeColor = System.Drawing.Color.White;
            this.learnButton.Location = new System.Drawing.Point(-1, 147);
            this.learnButton.Name = "learnButton";
            this.learnButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.learnButton.Size = new System.Drawing.Size(151, 57);
            this.learnButton.TabIndex = 6;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.CheckedChanged += new System.EventHandler(this.Learn_Changed);
            // 
            // HomeButton
            // 
            this.HomeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.HomeButton.Checked = true;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(3, 84);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(147, 57);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.TabStop = true;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.CheckedChanged += new System.EventHandler(this.Home_Changed);
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.namePanel.Controls.Add(this.maximizeButton);
            this.namePanel.Controls.Add(this.minimizeButton);
            this.namePanel.Controls.Add(this.exitButton);
            this.namePanel.Controls.Add(this.label1);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.namePanel.Location = new System.Drawing.Point(150, 0);
            this.namePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(578, 81);
            this.namePanel.TabIndex = 4;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maximizeButton.Location = new System.Drawing.Point(521, 0);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(28, 31);
            this.maximizeButton.TabIndex = 3;
            this.maximizeButton.Text = "ㅁ";
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.Location = new System.Drawing.Point(493, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 31);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = " -";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.exitButton.BackgroundImage = global::educatiom.Properties.Resources.Daco_41890251;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(550, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 31);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(67)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(155, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, [username]";
            // 
            // displayPannel
            // 
            this.displayPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPannel.Location = new System.Drawing.Point(150, 81);
            this.displayPannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayPannel.Name = "displayPannel";
            this.displayPannel.Size = new System.Drawing.Size(578, 374);
            this.displayPannel.TabIndex = 5;
            // 
            // UserPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(728, 455);
            this.Controls.Add(this.displayPannel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(346, 441);
            this.Name = "UserPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Username]\'s menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton logoutButton;
        private System.Windows.Forms.RadioButton optionButton;
        private System.Windows.Forms.RadioButton statButtons;
        private System.Windows.Forms.RadioButton learnButton;
        private System.Windows.Forms.RadioButton HomeButton;
        private System.Windows.Forms.Panel displayPannel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}