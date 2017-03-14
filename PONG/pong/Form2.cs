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
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer introsong = new System.Media.SoundPlayer(@"wavs\introsong.wav");
        public Form2()
        {
            InitializeComponent();
            introsong.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Form Pong = new Pong();
            Pong.Show();
            
            
        }
    }
}
