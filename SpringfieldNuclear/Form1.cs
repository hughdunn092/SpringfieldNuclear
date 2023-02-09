using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            outputLabel.Text = "MELTDOWN IMMINENT";
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play()

            Refresh();
            Thread.Sleep(1000);
        
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
        }
    }
}
