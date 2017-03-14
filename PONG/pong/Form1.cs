﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EV3MessengerLib;


namespace PONG
{
    public partial class Pong : Form
    {
        int balpos1 = 5;
        int balpos2 = 5;

        double speedup1 = -5;
        double speedup2 = 5;

        int puntenspeler1 = 0;
        int puntenspeler2 = 0;

        int offsetP1 = 10;
        int offsetP2 = 10;

        //Het aanmaken voor timers voor van de power ups (exclusief speedbal & fireball)
        int invis1timer = 0;
        int invis2timer = 0;
        int swap1timer = 0;
        int swap2timer = 0;


        private EV3Messenger ev3Messenger;


        Random songselect = new Random();
        Random speedbalgen = new Random();

        System.Media.SoundPlayer backgroundsong1 = new System.Media.SoundPlayer(@"wavs\whatislove.wav");
        System.Media.SoundPlayer backgroundsong2 = new System.Media.SoundPlayer(@"wavs\imagine.wav");
        System.Media.SoundPlayer backgroundsong3 = new System.Media.SoundPlayer(@"wavs\undertale.wav");
        System.Media.SoundPlayer geraakt1 = new System.Media.SoundPlayer(@"wavs\hit.wav");
        System.Media.SoundPlayer powerupsound = new System.Media.SoundPlayer(@"wavs\coin.wav");

        public Pong()
        {
            InitializeComponent();
            ev3Messenger = new EV3Messenger();
            jukebox();
            ev3Messenger.Connect("COM3");
        }

        //Het bewegen van speler 1
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                if (speler1.Top >= bordertop.Bottom )
                {speler1.Location = new Point(speler1.Location.X, speler1.Location.Y - offsetP1);}
                goalgemaakt(0);
            }
            else if (e.KeyChar == 's')
            {
                if (speler1.Bottom <= borderdown.Top)
                {
                    speler1.Location = new Point(speler1.Location.X, speler1.Location.Y + offsetP1);
                    goalgemaakt(0);
                }
            }

            //Invisibility
            //Het activeren van de invisibility power up voor speler 1
            if (e.KeyChar == '1')
            {
                speler1.BackColor = Color.Black;
                invis1timer = 1;
            }
            //Het activeren van de invisibility power up voor speler 2
            if (e.KeyChar == '2')
            {
                speler2.BackColor = Color.Black;
                invis2timer = 1;
            }

            //Swap Controls
            //Het activeren van de swap power up voor speler 1
            if (e.KeyChar == '3')
            {
                offsetP1 = -10;
                swap1timer = 1;
            }
            //Het activeren van de swap power uup voor speler 2
            /*if (e.KeyChar == '4')
            {
                offsetP2 = -10;
                swap2timer = 1;
            }*/
        



            /*Het bewegen van speler 2
            if (e.KeyChar == 'i')
            {
                if (speler2.Top >= bordertop.Bottom)
                {
                    speler2.Location = new Point(speler2.Location.X, speler2.Location.Y - offsetP2);
                }
               
            }

            else if (e.KeyChar == 'k')
            {
                if (speler2.Bottom <= borderdown.Top)
                {
                   speler2.Location = new Point(speler2.Location.X, speler2.Location.Y + offsetP2);
                }
            }*/
        }

        private void goalgemaakt(int a)
        {
            if (a == 0)
            {
                snelheid.Enabled = true;
            }
            else if (a == 1)
            {
                snelheid.Enabled = false;
            }
        }

        private void jukebox()
        {
            int song = songselect.Next(1, 4);
            if (song == 1)
            {
                backgroundsong1.Play();
            }
            else if ( song == 2)
            {
                backgroundsong2.Play();
            }
            else if ( song == 3)
            {
                backgroundsong3.Play();
            }
        }

        private void spelerev3_Tick(object sender, EventArgs e)
        {
            EV3Message message = ev3Messenger.ReadMessage();
            if (message != null && message.MailboxTitle == "up")
            {
                if (speler1.Top >= bordertop.Bottom)
                { speler1.Location = new Point(speler1.Location.X, speler1.Location.Y - offsetP1); }
                goalgemaakt(0);
            }

            else if (message != null && message.MailboxTitle == "down")
            {
                if (speler1.Bottom <= borderdown.Top)
                {
                    speler1.Location = new Point(speler1.Location.X, speler1.Location.Y + offsetP1);
                    goalgemaakt(0);
                }
            }

            if (message != null && message.MailboxTitle == "up2")
            {
                if (speler2.Top >= bordertop.Bottom)
                { speler2.Location = new Point(speler2.Location.X, speler2.Location.Y - offsetP2); }
                goalgemaakt(0);
            }

            else if (message != null && message.MailboxTitle == "down2")
            {
                if (speler2.Bottom <= borderdown.Top)
                {
                    speler2.Location = new Point(speler2.Location.X, speler2.Location.Y + offsetP2);
                    goalgemaakt(0);
                }
            }
        }

        private void snelheid_Tick_1(object sender, EventArgs e)
        {
            Bal.Location = new Point(Bal.Location.X + balpos1, Bal.Location.Y + balpos2);


            if (Bal.Bottom >= borderdown.Top)
            {
                balpos2 = Convert.ToInt32(speedup1);
            }

            if (Bal.Top <= bordertop.Bottom)
            {
                balpos2 = Convert.ToInt32(speedup2);
            }

            // bal raakt bot
            if (Bal.Right >= speler2.Left && Bal.Bottom >= speler2.Top && Bal.Top <= speler2.Bottom)
            {
                double rspeed1 = speedbalgen.NextDouble() * (0.5 - 0.15) + 0.1;
                double rspeed2 = speedbalgen.NextDouble() * (0.5 - 0.15) + 0.1;

                //  if (Snelheid.Interval >= 2)
                //  {
                //     Snelheid.Interval -= 1;
                //  spelerev3.Interval -= 1;
                //  }
                speedup1 -= rspeed1;
                speedup2 += rspeed2;
                balpos1 = Convert.ToInt32(speedup1);
                ev3Messenger.SendMessage("hit", "scream");
            }

            // bal raakt speler
            if (Bal.Left <= speler1.Right && Bal.Bottom >= speler1.Top && Bal.Top <= speler1.Bottom)
            {
                // if (Snelheid.Interval >= 2)
                //  {
                //      Snelheid.Interval -= 1;
                //  spelerev3.Interval -= 1;
                //  }


                double rspeed1 = speedbalgen.NextDouble() * (0.5 - 0.15) + 0.1;
                double rspeed2 = speedbalgen.NextDouble() * (0.5 - 0.15) + 0.1;

                speedup1 -= rspeed1;
                speedup2 += rspeed2;
                balpos1 = Convert.ToInt32(speedup2);
                ev3Messenger.SendMessage("hit", "scream");
            }

            // goal gemaakt door bot
            if (Bal.Left <= goal1.Right)
            {
                puntenspeler2 += 1;
                punten2.Text = Convert.ToString(puntenspeler2);
                Bal.Location = new Point(speler1.Right + 5, (speler1.Top + speler1.Bottom) / 2);
                speedup1 = -5;
                speedup2 = 5;

                //  Snelheid.Interval = 20;
                //spelerev3.Interval = 20;
                goalgemaakt(1);
                //    ev3Messenger.SendMessage("boo", "scream");
            }
            // goal gemaakt door 1
            if (Bal.Right >= goal2.Left)
            {
                puntenspeler1 += 1;
                punten1.Text = Convert.ToString(puntenspeler1);
                Bal.Location = new Point(speler2.Left - 18, (speler2.Top + speler2.Bottom) / 2);
                speedup1 = -5;
                speedup2 = 5;
                //spelerev3.Interval = 20;
                //Snelheid.Interval = 20;
                goalgemaakt(1);
                //    ev3Messenger.SendMessage("yay", "scream");
            }
            // bot
            if ((speler2.Top + speler2.Bottom) / 2 <= (Bal.Top + Bal.Bottom) / 2)
            {
                speler2.Location = new Point(speler2.Location.X, speler2.Location.Y + 6);
            }

            if ((speler2.Top + speler2.Bottom) / 2 >= (Bal.Top + Bal.Bottom) / 2)
            {
                speler2.Location = new Point(speler2.Location.X, speler2.Location.Y - 6);
            }
        }

        

        private void powerup_Tick(object sender, EventArgs e)
        {
            //De timer voor de invisibility power up van speler 1 en het deactiveren ervan.
            if (invis1timer >= 1)
            {
                invis1timer++;
                if (invis1timer == 4)
                {
                    speler1.BackColor = Color.White;
                    invis1timer = 0;
                }
            }

            //De timer voor de invisibility power up van speler 2 en het deactiveren ervan.
            if (invis2timer >= 1)
            {
                invis2timer++;
                if (invis2timer == 4)
                {
                    speler2.BackColor = Color.White;
                    invis2timer = 0;
                }
            }

            //De timer voor de swap controls power up van speler 1 en het deactiveren ervan.
            if (swap1timer >= 1)
            {
                swap1timer++;
                if (swap1timer == 4)
                {
                    offsetP1 = 10;
                    swap1timer = 0;
                }
            }

            //De timer voor de swap controls power up van speler 2 en het deactiveren ervan.
            if (swap2timer >= 1)
            {
                swap2timer++;
                if (swap2timer == 4)
                {
                    offsetP2 = 10;
                    swap2timer = 0;
                }
            }




        }
    }
}
