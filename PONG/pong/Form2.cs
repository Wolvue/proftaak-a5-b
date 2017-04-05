using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG
{
    public partial class MainMenu : Form
    {
        System.Media.SoundPlayer introsong = new System.Media.SoundPlayer(@"wavs\introsong.wav");

        public static int gamemode;
        public MainMenu()
        {
            InitializeComponent();
            introsong.Play();
        }



        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Singleplayer_start_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form Pong = new Pong();
            Pong.ShowDialog();
            gamemode = 1;
        }

        private void Multiplayer_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Pong = new Pong();
            Pong.ShowDialog();
            gamemode = 2;
        }
    }
}
