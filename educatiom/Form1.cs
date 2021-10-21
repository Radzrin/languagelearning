using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using educatiom.Properties;
using System.IO;

namespace educatiom
{
    public partial class Opening : Form
    {

        String line;

        public Opening()
        {
            InitializeComponent();
            
        }

        //double buffer to prevent it from flickering when it loads
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams hangleParams = base.CreateParams;
                hangleParams.ExStyle |= 0x02000000;
                return hangleParams;
            }
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm lf = new LogInForm();
            lf.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm suf = new SignUpForm();
            suf.Show();
        }

        private void Closing_Form(object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "LanguageChooseForm")
                {
                    e.Cancel = true;
                }
                else
                {
                    System.Environment.Exit(69);
                }
            }
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
                        SignUp.Text = resxSet.GetString("SignUp_fr");
                        Welcome.Text = resxSet.GetString("Welcome_fr");
                        Welcome.Location = new Point(Welcome.Location.X - 20, Welcome.Location.Y);
                        languageTab.Text = resxSet.GetString("Languages_fr");
                        this.Text = resxSet.GetString("MainPage_fr");
                    }
                    break;
                case "es":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_es");
                        SignUp.Text = resxSet.GetString("SignUp_es");
                        Welcome.Text = resxSet.GetString("Welcome_es");
                        Welcome.Location = new Point(Welcome.Location.X - 20, Welcome.Location.Y);
                        languageTab.Text = resxSet.GetString("Languages_es");
                        this.Text = resxSet.GetString("MainPage_es");
                    }
                    break;
                case "jap":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_jp");
                        SignUp.Text = resxSet.GetString("SignUp_jp");
                        Welcome.Text = resxSet.GetString("Welcome_jp");
                        Welcome.Location = new Point(Welcome.Location.X - 10, Welcome.Location.Y);
                        languageTab.Text = resxSet.GetString("Languages_jp");
                        this.Text = resxSet.GetString("MainPage_jp");
                    }
                    break;

                case "ko":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_ko");
                        SignUp.Text = resxSet.GetString("SignUp_ko");
                        Welcome.Text = resxSet.GetString("Welcome_ko");
                        languageTab.Text = resxSet.GetString("Languages_ko");
                        this.Text = resxSet.GetString("MainPage_ko");
                    }
                    break;

                case "rus":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_ru");
                        SignUp.Text = resxSet.GetString("SignUp_ru");
                        Welcome.Text = resxSet.GetString("Welcome_ru");                       
                        Welcome.Location = new Point(Welcome.Location.X - 80, Welcome.Location.Y);
                        languageTab.Text = resxSet.GetString("Languages_ru");
                        this.Text = resxSet.GetString("MainPage_ru");
                    }
                    break;
                case "chineseSimp":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_sim");
                        SignUp.Text = resxSet.GetString("SignUp_sim");
                        Welcome.Text = resxSet.GetString("Welcome_sim");
                        Welcome.Location = new Point(Welcome.Location.X + 25, Welcome.Location.Y);
                        languageTab.Text = resxSet.GetString("Languages_sim");
                        this.Text = resxSet.GetString("MainPage_sim");
                    }
                        break;
                case "chineseTrad":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        LogIn.Text = resxSet.GetString("LogIn_tra");
                        SignUp.Text = resxSet.GetString("SignUp_tra");
                        Welcome.Text = resxSet.GetString("Welcome_tra");
                        Welcome.Location = new Point(Welcome.Location.X + 25, Welcome.Location.Y);
                        languageTab.Text = resxSet.GetString("Languages_tra");
                        this.Text = resxSet.GetString("MainPage_tra");
                    }
                    break;
                default:
                    Welcome.Location = new Point(Welcome.Location.X - 10, Welcome.Location.Y);
                    break;
            }


            sr.Close();
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


        private void Change_Lang()
        {
            string docPath = @"..\..\Resources";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "locale.txt")))
            {
                outputFile.WriteLine(line);
            }

            Opening op = new Opening();
            op.Show();
            this.Hide();
        }
      
    }
}
