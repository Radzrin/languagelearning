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
    public partial class LearnForm : Form
    {
        public LearnForm()
        {
            InitializeComponent();
        }
        private void Alphabet_Click(object sender, EventArgs e)
        {
            AlphabetForm af = new AlphabetForm();
            af.Show();
        }
    }
}
