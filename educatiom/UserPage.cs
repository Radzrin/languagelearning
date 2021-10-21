using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace educatiom
{
    public partial class UserPageForm : Form
    {

        private MessageBoxIcon iconType { get; set; }
        private MessageBoxButtons buttonType { get; set; }

        string exitMessage;

        public UserPageForm()
        {
            InitializeComponent();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            iconType = MessageBoxIcon.Asterisk;
            buttonType = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you really want to leave?", "Exit Warning",
            buttonType, iconType);

            switch (result)
            {
                case DialogResult.Yes:
                    System.Environment.Exit(1);
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    e.Cancel = true;
                    break;

            }

        }

        private void OnCLick(object sender, EventArgs e)
        {
            iconType = MessageBoxIcon.Asterisk;
            buttonType = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you really want to leave?", "Exit Warning",
            buttonType, iconType);

            Opening op = new Opening();

            switch (result)
            {
                case DialogResult.Yes:
                    this.Hide();
                    op.Show();
                    break;
                default:
                    break;

            }
        }

        private void Home_Changed(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.TopLevel = false;
            hf.Dock = DockStyle.Fill;
            this.displayPannel.Controls.Add(hf);
            this.displayPannel.Tag = hf;
            hf.BringToFront();
            hf.Show();

        }

        private void Learn_Changed(object sender, EventArgs e)
        {
            LearnForm lf = new LearnForm();
            lf.TopLevel = false;
            lf.FormBorderStyle = FormBorderStyle.None;
            lf.Dock = DockStyle.Fill;
            this.displayPannel.Controls.Add(lf);
            this.displayPannel.Tag = lf;
            lf.BringToFront();
            lf.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.TopLevel = false;
            hf.FormBorderStyle = FormBorderStyle.None;
            hf.Dock = DockStyle.Fill;
            this.displayPannel.Controls.Add(hf);
            this.displayPannel.Tag = hf;
            hf.BringToFront();
            hf.Show();
        }

        private void Stat_Changed(object sender, EventArgs e)
        {
            StatsForm sf = new StatsForm();
            sf.TopLevel = false;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.displayPannel.Controls.Add(sf);
            this.displayPannel.Tag = sf;
            sf.BringToFront();
            sf.Show();
        }

        private void Settings_Changed(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.TopLevel = false;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.displayPannel.Controls.Add(sf);
            this.displayPannel.Tag = sf;
            sf.BringToFront();
            sf.Show();

        }
        private void Maximize_Click(object sender, EventArgs e)
        {
            var max = (this.WindowState == FormWindowState.Maximized) ? this.WindowState = FormWindowState.Normal : this.WindowState = FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      
    }
}
