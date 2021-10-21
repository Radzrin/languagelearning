using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace educatiom
{
    public partial class SignUpForm : Form
    {

        private string line;
        private string loc;
        private byte[] validateBoxes = { 0, 0, 0, 0};
        private byte[] wanted = { 0, 0, 0, 0};
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            Opening op = new Opening();
            op.Show();
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
                        email.Text = resxSet.GetString("Email_fr");
                        login.Text = resxSet.GetString("LogIn_fr");
                        password.Text = resxSet.GetString("Password_fr");
                        languageTab.Text = resxSet.GetString("Languages_fr");
                        SignUpLabel.Text = resxSet.GetString("SignUp_fr");
                        username.Text = resxSet.GetString("Username_fr");
                        this.Text = resxSet.GetString("SignUp_fr");
                        loc = "_fr";
                    }
                    break;
                case "es":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        email.Text = resxSet.GetString("Email_es");
                        login.Text = resxSet.GetString("LogIn_es");
                        password.Text = resxSet.GetString("Password_es");
                        languageTab.Text = resxSet.GetString("Languages_es");
                        SignUpLabel.Text = resxSet.GetString("SignUp_es");
                        username.Text = resxSet.GetString("Username_es");
                        this.Text = resxSet.GetString("SignUp_es");
                        loc = "_es";
                    }
                    break;
                case "jap":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        email.Text = resxSet.GetString("Email_jp");
                        login.Text = resxSet.GetString("LogIn_jp");
                        password.Text = resxSet.GetString("Password_jp");
                        languageTab.Text = resxSet.GetString("Languages_jp");
                        SignUpLabel.Text = resxSet.GetString("SignUp_jp");
                        username.Text = resxSet.GetString("Username_jp");
                        this.Text = resxSet.GetString("SignUp_jp");
                        loc = "_jp";
                    }
                    break;

                case "ko":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        email.Text = resxSet.GetString("Email_ko");
                        login.Text = resxSet.GetString("LogIn_ko");
                        password.Text = resxSet.GetString("Password_ko");
                        languageTab.Text = resxSet.GetString("Languages_ko");
                        SignUpLabel.Text = resxSet.GetString("SignUp_ko");
                        username.Text = resxSet.GetString("Username_ko");
                        this.Text = resxSet.GetString("SignUp_ko");
                        loc = "_ko";
                    }
                    break;

                case "rus":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        email.Text = resxSet.GetString("Email_ru");
                        login.Text = resxSet.GetString("LogIn_ru");
                        password.Text = resxSet.GetString("Password_ru");
                        password2.Text = resxSet.GetString("Password2_ru");
                        languageTab.Text = resxSet.GetString("Languages_ru");
                        SignUpLabel.Text = resxSet.GetString("SignUp_ru");
                        username.Text = resxSet.GetString("Username_ru");
                        this.Text = resxSet.GetString("SignUp_ru");
                        loc = "_ru";
                    }
                    break;
                case "chineseSimp":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        email.Text = resxSet.GetString("Email_sim");
                        login.Text = resxSet.GetString("LogIn_sim");
                        password.Text = resxSet.GetString("Password_sim");
                        languageTab.Text = resxSet.GetString("Languages_sim");
                        SignUpLabel.Text = resxSet.GetString("SignUp_sim");
                        username.Text = resxSet.GetString("Username_sim");
                        this.Text = resxSet.GetString("SignUp_sim");
                        loc = "_sim";
                    }
                    break;
                case "chineseTrad":
                    using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    {
                        email.Text = resxSet.GetString("Email_tra");
                        login.Text = resxSet.GetString("LogIn_tra");
                        password.Text = resxSet.GetString("Password_tra");
                        languageTab.Text = resxSet.GetString("Languages_tra");
                        SignUpLabel.Text = resxSet.GetString("SignUp_tra");
                        username.Text = resxSet.GetString("Username_tra");
                        this.Text = resxSet.GetString("SignUp_tra");
                        loc = "_tra";
                    }
                    break;
                default:
                    loc = "_en";
                    break;
            }

            sr.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm lgf = new LogInForm();
            lgf.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if ((new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")).IsMatch(emailBox.Text))
            {
                emailInvalid.Text = "";
                validateBoxes[0] = 0;
            }
            else
            {
                emailInvalid.Text = "email invalid";
                validateBoxes[0] = 1;
            }

            if ((new Regex(@"^[a-zA-z\d\p{L}]{1,21}$")).IsMatch(userNameBox.Text))
            {
                invalidUser.Text = "";
                validateBoxes[1] = 0;
            }
            else
            {
                invalidUser.Text = "Username invalid";
                validateBoxes[1] = 1;
                if (userNameBox.Text.Length < 1)
                    invalidUser.Text += ": field cannot be empty";
            }

            if ((new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*+-]).{8,}$")).IsMatch(passwordBox.Text))
            {

                validateBoxes[2] = 0;
                invalidPassword.Text = "";
            }
            else
            {
                passwordBox.Clear();
                invalidPassword.Text = "Password invalid";
                validateBoxes[2] = 1;
            }



            if (passwordBox.Text.Equals(passwordBox2.Text))
            {
                validateBoxes[3] = 0;
                invalidPassword2.Text = "";
            }
            else
            {
                passwordBox2.Clear();
                invalidPassword2.Text = "Passwords do not match";
                validateBoxes[3] = 1;
            }


            if (validateBoxes.SequenceEqual(wanted))
            {
                StreamReader sr = new StreamReader(@"..\..\Resources\locale.txt");
                line = sr.ReadLine();
                string resxFile = $@"..\..\Resources\{line}.resx";
                using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                    System.Windows.Forms.MessageBox.Show(resxSet.GetString($"SignUp{loc}")); //account successfully created               
                sr.Close();
                this.Close();

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

        private void Change_Lang()
        {
            string docPath = @"..\..\Resources";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "locale.txt")))
            {
                outputFile.WriteLine(line);
            }
        }

    }
}
