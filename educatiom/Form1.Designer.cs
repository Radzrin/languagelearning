
namespace educatiom
{
    partial class Opening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opening));
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
            this.Welcome = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageTab});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
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
            resources.ApplyResources(this.languageTab, "languageTab");
            // 
            // french
            // 
            this.french.Image = global::educatiom.Properties.Resources.fricon;
            this.french.Name = "french";
            resources.ApplyResources(this.french, "french");
            this.french.Click += new System.EventHandler(this.French_Click);
            // 
            // english
            // 
            this.english.Image = global::educatiom.Properties.Resources.engicon;
            this.english.Name = "english";
            resources.ApplyResources(this.english, "english");
            this.english.Click += new System.EventHandler(this.English_Click);
            // 
            // spanish
            // 
            this.spanish.Image = global::educatiom.Properties.Resources.spaicon;
            this.spanish.Name = "spanish";
            resources.ApplyResources(this.spanish, "spanish");
            this.spanish.Click += new System.EventHandler(this.Spanish_Click);
            // 
            // russian
            // 
            this.russian.Image = global::educatiom.Properties.Resources.ruicon;
            this.russian.Name = "russian";
            resources.ApplyResources(this.russian, "russian");
            this.russian.Click += new System.EventHandler(this.Russian_Click);
            // 
            // korean
            // 
            this.korean.Image = global::educatiom.Properties.Resources.koicon;
            this.korean.Name = "korean";
            resources.ApplyResources(this.korean, "korean");
            this.korean.Click += new System.EventHandler(this.Korean_Click);
            // 
            // japanese
            // 
            this.japanese.Image = global::educatiom.Properties.Resources.japicon;
            this.japanese.Name = "japanese";
            resources.ApplyResources(this.japanese, "japanese");
            this.japanese.Click += new System.EventHandler(this.Japanese_Click);
            // 
            // simpChinese
            // 
            this.simpChinese.Image = global::educatiom.Properties.Resources.chicon;
            this.simpChinese.Name = "simpChinese";
            resources.ApplyResources(this.simpChinese, "simpChinese");
            this.simpChinese.Click += new System.EventHandler(this.Simplified_Click);
            // 
            // tradChinese
            // 
            this.tradChinese.Image = global::educatiom.Properties.Resources.taicon;
            this.tradChinese.Name = "tradChinese";
            resources.ApplyResources(this.tradChinese, "tradChinese");
            this.tradChinese.Click += new System.EventHandler(this.Traditional_Click);
            // 
            // Welcome
            // 
            resources.ApplyResources(this.Welcome, "Welcome");
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcome.Name = "Welcome";
            // 
            // LogIn
            // 
            resources.ApplyResources(this.LogIn, "LogIn");
            this.LogIn.Name = "LogIn";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // SignUp
            // 
            resources.ApplyResources(this.SignUp, "SignUp");
            this.SignUp.Name = "SignUp";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Opening
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::educatiom.Properties.Resources.mountainTop;
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Opening";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing_Form);
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button SignUp;
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

