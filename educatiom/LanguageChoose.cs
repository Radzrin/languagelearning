using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace educatiom
{
    public partial class LanguageChooseForm : Form
    {
        private int[] langs = { 0, 0, 0, 0, 0, 0, 0, 0 };
        private string locale;

        public LanguageChooseForm()
        {
            InitializeComponent();
        }

        private void English_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(0) == 1)
            {
                locale = "en";
                WriteFile();
            }
            else
            {
                for(int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[0] = 1;
                
                englishButton.FlatStyle = FlatStyle.Flat;
                englishButton.FlatAppearance.BorderColor = Color.Blue;
            }      
        }

        private void French_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(1) == 1)
            {
                locale = "fr";
                WriteFile();
            }
            else
            {
                for (int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[1] = 1;

                frenchButton.FlatStyle = FlatStyle.Flat;
                frenchButton.FlatAppearance.BorderColor = Color.Blue;
            }
        }

        private void Spanish_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(2) == 1)
            {
                locale = "es";
                WriteFile();
            }
            else
            {
                for (int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[2] = 1;

                spanishButton.FlatStyle = FlatStyle.Flat;
                spanishButton.FlatAppearance.BorderColor = Color.Blue;
            }
        }

        private void Japanese_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(3) == 1)
            {
                locale = "jap";
                WriteFile();             
            }
            else
            {
                for (int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[3] = 1;

                japaneseButton.FlatStyle = FlatStyle.Flat;
                japaneseButton.FlatAppearance.BorderColor = Color.Blue;
            }
        }

        private void Korean_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(4) == 1)
            {
                locale = "ko";
                WriteFile();
            }
            else
            {
                for (int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[4] = 1;

                koreanButton.FlatStyle = FlatStyle.Flat;
                koreanButton.FlatAppearance.BorderColor = Color.Blue;
            }
        }

        private void Russian_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(5) == 1)
            {
                locale = "rus";
                WriteFile();
            }
            else
            {
                for (int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[5] = 1;

                russianButton.FlatStyle = FlatStyle.Flat;
                russianButton.FlatAppearance.BorderColor = Color.Blue;
            }
        }

        private void SimplifiedChineseButton_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(6) == 1)
            {
                locale = "chineseSimp";
                WriteFile();
            }
            else
            {
                for (int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[6] = 1;

                simplifiedChineseButton.FlatStyle = FlatStyle.Flat;
                simplifiedChineseButton.FlatAppearance.BorderColor = Color.Blue;
            }
        }
        private void TraditionalChineseButton_Click(object sender, EventArgs e)
        {
            if (langs.ElementAt(7) == 1)
            {
                locale = "chineseTrad";
                WriteFile();
            }
            else
            {
                for (int i = 0; i < langs.Length; i++)
                    langs[i] = 0;

                langs[7] = 1;

                traditionalChineseButton.FlatStyle = FlatStyle.Flat;
                traditionalChineseButton.FlatAppearance.BorderColor = Color.Blue;
            }
        }

        private void WriteFile()
        {
            string docPath = @"..\..\Resources";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "locale.txt")))
            {
                outputFile.WriteLine(locale);
            }

            Opening op = new Opening();
            op.Show();
            this.Hide();
        }
    }
}
