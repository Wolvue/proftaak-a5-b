using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EV3MessengerLib;

namespace PONG
{
    public partial class MainMenu : Form
    {
        System.Media.SoundPlayer introsong = new System.Media.SoundPlayer(@"wavs\introsong.wav");

        public static int gamemode;

        private EV3Messenger ev3Messenger;



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
            //
            if ((bot2.Top + bot2.Bottom) / 2 <= (Bal.Top + Bal.Bottom) / 2)
            {
                bot2.Location = new Point(bot2.Location.X, bot2.Location.Y + 6);
            }

            if ((bot2.Top + bot2.Bottom) / 2 >= (Bal.Top + Bal.Bottom) / 2)
            {
                bot2.Location = new Point(bot2.Location.X, bot2.Location.Y - 6);
            }
            //
            if ((bot1.Top + bot1.Bottom) / 2 <= (Bal.Top + Bal.Bottom) / 2)
            {
                bot1.Location = new Point(bot1.Location.X, bot1.Location.Y + 4);
            }

            if ((bot1.Top + bot1.Bottom) / 2 >= (Bal.Top + Bal.Bottom) / 2)
            {
                bot1.Location = new Point(bot1.Location.X, bot1.Location.Y - 4);
            }

            Bal.Location = new Point(Bal.Location.X + balpos1, Bal.Location.Y + balpos2);

            if (Bal.Bottom >= Borderbottom.Top)
            {
                balpos2 = -5;
            }

            if (Bal.Top <= Bordertop.Bottom)
            {
                balpos2 = 5;
            }

            if (Bal.Left <= bot1.Right && Bal.Bottom >= bot1.Top && Bal.Top <= bot1.Bottom)
            {
                balpos1 = 5;
            }
            if (Bal.Right >= bot2.Left && Bal.Bottom >= bot2.Top && Bal.Top <= bot2.Bottom)
            {
                balpos1 = -5;
            }

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
    
}
