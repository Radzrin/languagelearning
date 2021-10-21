using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace educatiom
{
    public partial class LogInForm : Form
    {
        string line;
        public LogInForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams hangleParams = base.CreateParams;
                hangleParams.ExStyle |= 0x02000000;
                return hangleParams;
            }
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Opening op = new Opening();
            op.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            SignUpForm sf = new SignUpForm();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm sif = new SignUpForm();
            sif.Show();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"..\..\Resources\locale.txt");
            line = sr.ReadLine();

            string resxFile = $@"..\..\Resources\{line}.resx";

            switch (line)
            {
                case "fr":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_fr");
                        Info.Text = resxSet.GetString("Info_fr");
                        SignUp.Text = resxSet.GetString("SignUp_fr");
                        Password.Text = resxSet.GetString("Password_fr");
                        languageTab.Text = resxSet.GetString("Languages_fr");
                        Forgot.Text = resxSet.GetString("ForgotPassword_fr");
                        this.Text = resxSet.GetString("LogIn_fr");
                    }
                    break;
                case "es":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_es");
                        Info.Text = resxSet.GetString("Info_es");
                        SignUp.Text = resxSet.GetString("SignUp_es");
                        Password.Text = resxSet.GetString("Password_es");
                        languageTab.Text = resxSet.GetString("Languages_es");
                        Forgot.Text = resxSet.GetString("ForgotPassword_es");
                        this.Text = resxSet.GetString("LogIn_es");
                    }
                    break;
                case "jap":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_jp");
                        Info.Text = resxSet.GetString("Info_jp");
                        SignUp.Text = resxSet.GetString("SignUp_jp");
                        Password.Text = resxSet.GetString("Password_jp");
                        languageTab.Text = resxSet.GetString("Languages_jp");
                        Forgot.Text = resxSet.GetString("ForgotPassword_jp");
                        this.Text = resxSet.GetString("LogIn_jp");
                    }
                    break;

                case "ko":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_ko");
                        Info.Text = resxSet.GetString("Info_ko");
                        SignUp.Text = resxSet.GetString("SignUp_ko");
                        Password.Text = resxSet.GetString("Password_ko");
                        languageTab.Text = resxSet.GetString("Languages_ko");
                        Forgot.Text = resxSet.GetString("ForgotPassword_ko");
                        this.Text = resxSet.GetString("LogIn_ko");
                    }
                    break;

                case "rus":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_ru");
                        Info.Text = resxSet.GetString("Info_ru");
                        SignUp.Text = resxSet.GetString("SignUp_ru");
                        Password.Text = resxSet.GetString("Password_ru");
                        languageTab.Text = resxSet.GetString("Languages_ru");
                        Forgot.Text = resxSet.GetString("ForgotPassword_ru");
                        this.Text = resxSet.GetString("LogIn_ru");
                    }
                    break;
                case "chineseSimp":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_sim");
                        Info.Text = resxSet.GetString("Info_sim");
                        SignUp.Text = resxSet.GetString("SignUp_sim");
                        Password.Text = resxSet.GetString("Password_sim");
                        languageTab.Text = resxSet.GetString("Languages_sim");
                        Forgot.Text = resxSet.GetString("ForgotPassword_sim");
                        this.Text = resxSet.GetString("LogIn_sim");
                    }
                    break;
                case "chineseTrad":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_tra");
                        Info.Text = resxSet.GetString("Info_tra");
                        SignUp.Text = resxSet.GetString("SignUp_tra");
                        Password.Text = resxSet.GetString("Password_tra");
                        languageTab.Text = resxSet.GetString("Languages_tra");
                        Forgot.Text = resxSet.GetString("ForgotPassword_tra");
                        this.Text = resxSet.GetString("LogIn_tra");
                    }
                    break;
                default:
                    LogIn.Text = "Log in";
                    Info.Text = "Name / Username / email";
                    SignUp.Text = "Sign up";
                    Password.Text = "Password: ";
                    languageTab.Text = "Languages";
                    Forgot.Text = "I forgot my password";
                    this.Text = "Log in";
                    break;
            }


            sr.Close();
        }
        private void Change_Lang()
        {
            string docPath = @"..\..\Resources";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "locale.txt")))
            {
                outputFile.WriteLine(line);
            }
        }

        private void French_Click(object sender, EventArgs e)
        {
            line = "fr";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void English_Click(object sender, EventArgs e)
        {
            line = "en";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void Spanish_Click(object sender, EventArgs e)
        {
            line = "es";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void Russian_Click(object sender, EventArgs e)
        {
            line = "rus";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void Korean_Click(object sender, EventArgs e)
        {
            line = "ko";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void Japanese_Click(object sender, EventArgs e)
        {
            line = "jap";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void Simplified_Click(object sender, EventArgs e)
        {
            line = "chineseSimp";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void Traditional_Click(object sender, EventArgs e)
        {
            line = "chineseTrad";
            Change_Lang();
            Form_Load(sender, e);
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPageForm upf = new UserPageForm();
            upf.Show();
        }
    }
}
