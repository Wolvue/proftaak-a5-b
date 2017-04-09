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

        double movementX1 = -5;
        double movementX2 = 5;
        double movementY1 = -5;
        double movementY2 = 5;

        int balpos1 = 5;
        int balpos2 = -5;

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
            gamemode = 1;
            this.Hide();
            Form Pong = new Pong();
            Pong.ShowDialog();
            
        }

        private void Multiplayer_start_Click(object sender, EventArgs e)
        {
            gamemode = 2;
            this.Hide();
            Form Pong = new Pong();
            Pong.ShowDialog();
            
        }

        private void balmovement_Tick(object sender, EventArgs e)
        {
            if ((bot1.Top + bot1.Bottom) / 2 <= (Bal.Top + Bal.Bottom) / 2)
            {
                bot1.Location = new Point(bot1.Location.X, bot1.Location.Y + 6);
            }

            if ((bot1.Top + bot1.Bottom) / 2 >= (Bal.Top + Bal.Bottom) / 2)
            {
                bot1.Location = new Point(bot1.Location.X, bot1.Location.Y - 6);
            }
            //
            if ((bot2.Top + bot2.Bottom) / 2 <= (Bal.Top + Bal.Bottom) / 2)
            {
                bot2.Location = new Point(bot2.Location.X, bot2.Location.Y + 4);
            }

            if ((bot2.Top + bot2.Bottom) / 2 >= (Bal.Top + Bal.Bottom) / 2)
            {
                bot2.Location = new Point(bot2.Location.X, bot2.Location.Y - 4);
            }

            Bal.Location = new Point(Bal.Location.X + balpos1, Bal.Location.Y + balpos2);




        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
