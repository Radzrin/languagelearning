using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace educatiom
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Goku_Click(object sender, EventArgs e)
        {

            double infinity = 1.0 / 0;


            var soundPlayer = new SoundPlayer(Properties.Resources.gokuWav);
            soundPlayer.PlayLooping(); 

            for (double i = 0; i < infinity; i++)
                System.Windows.Forms.MessageBox.Show("Hey its me goku");

        }

        private void Goku_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Goku_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
