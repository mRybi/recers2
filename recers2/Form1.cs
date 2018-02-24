using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using recers2.Game;

namespace recers2
{
    public partial class Form1 : Form
    {
        private readonly Board Board;
        Stopwatch gameTime = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            Board = new Board(label1, button1, button2, textBox1, labelPoints);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameTime.Reset();
            label4.Text = "";
            timer1.Enabled = true;
            timer2.Enabled = true;
            gameTime.Start();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameTime.Stop();
            timer1.Enabled = false;
            timer2.Enabled = false;
            label4.Text = gameTime.Elapsed.Seconds.ToString() + " sec";
            Board.ResetPoints();
            label1.Text = "Click Start";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Board.Points < 1000)
            {
                Board.GetCharacter();
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            else
                button2_Click(sender, e);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Board.AreTheSame())
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                Board.AddScore();
            }

        }
    }
}
