using System;
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

        int offset = 10;

        private EV3Messenger ev3Messenger;


        Random songselect = new Random();
        Random speedbalgen = new Random();

        System.Media.SoundPlayer backgroundsong1 = new System.Media.SoundPlayer(@"C:\Users\gebruiker\Documents\pong game stuff\whatislove.wav");
        System.Media.SoundPlayer backgroundsong2 = new System.Media.SoundPlayer(@"C:\Users\gebruiker\Documents\pong game stuff\imagine.wav");
        System.Media.SoundPlayer backgroundsong3 = new System.Media.SoundPlayer(@"C:\Users\gebruiker\Documents\pong game stuff\undertale.wav");
        System.Media.SoundPlayer geraakt1 = new System.Media.SoundPlayer(@"C:\Users\gebruiker\Documents\pong game stuff\hit.wav");
        System.Media.SoundPlayer powerupsound = new System.Media.SoundPlayer(@"C:\Users\gebruiker\Documents\pong game stuff\coin.wav");
        public Pong()
        {
            InitializeComponent();
            ev3Messenger = new EV3Messenger();
            jukebox();
            ev3Messenger.Connect("COM3");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 'w')
            {
                if (speler1.Top >= bordertop.Bottom )
                {speler1.Location = new Point(speler1.Location.X, speler1.Location.Y - offset);}
                goalgemaakt(0);
                
            }
            else if (e.KeyChar == 's')
            {
                if (speler1.Bottom <= borderdown.Top)
                {
                    speler1.Location = new Point(speler1.Location.X, speler1.Location.Y + offset);
                    goalgemaakt(0);
                }
                
            }

           // if (e.KeyChar == 'i')
           //  {
           //    if (speler2.Top >= bordertop.Bottom)
           //     {
           //         speler2.Location = new Point(speler2.Location.X, speler2.Location.Y - offset);
           //     }
                
           // }

            //else if (e.KeyChar == 'k')
           // {
            //    if (speler2.Bottom <= borderdown.Top)
             //   {
             //       speler2.Location = new Point(speler2.Location.X, speler2.Location.Y + offset);
             //   }
            // }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            


            
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                label1.Text = Convert.ToString(rspeed1);
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
                label1.Text = Convert.ToString(rspeed1);
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
                Bal.Location = new Point(speler1.Right + 5, (speler1.Top + speler1.Bottom) / 2 );
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
               // Snelheid.Interval = 20;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void punten2_Click(object sender, EventArgs e)
        {

        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            

            
        }

        private void goalgemaakt(int a)
        {
            if (a == 0)
            {

                Snelheid.Enabled = true;
                
            }
            else if (a == 1)
            {
                Snelheid.Enabled = false;
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
                { speler1.Location = new Point(speler1.Location.X, speler1.Location.Y - offset); }
                goalgemaakt(0);
            }

            else if (message != null && message.MailboxTitle == "down")
            {
                if (speler1.Bottom <= borderdown.Top)
                {
                    speler1.Location = new Point(speler1.Location.X, speler1.Location.Y + offset);
                    goalgemaakt(0);
                }
            }

            if (message != null && message.MailboxTitle == "up2")
            {
                if (speler2.Top >= bordertop.Bottom)
                { speler2.Location = new Point(speler2.Location.X, speler2.Location.Y - offset); }
                goalgemaakt(0);
            }

            else if (message != null && message.MailboxTitle == "down2")
            {
                if (speler2.Bottom <= borderdown.Top)
                {
                    speler2.Location = new Point(speler2.Location.X, speler2.Location.Y + offset);
                    goalgemaakt(0);
                }
            }
        }
    }
}
