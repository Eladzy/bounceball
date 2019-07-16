using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ball
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer=new System.Windows.Forms.Timer();
        private enum Direction
        {
            positive,
            negative,
        }
       
        private Direction directionY = Direction.positive;
        private Direction directionX = Direction.positive;
        public Form1()
        {
            InitializeComponent();
            this.timer.Enabled = false;
            this.timer.Interval = 10;
            this.timer.Tick += Move;//every 10 ms move event will be called
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RandomizeLocation();
            this.timer.Enabled = true;
            
        }
        private void Move(object sender,EventArgs args)//will be called on tick
        {
            
            int xUpperLimit = this.ClientSize.Width- ballPic.Width;//window width minus picturebox width
            int LowerLimit = 0;//(0,0)
            int yUpperLimit = this.ClientSize.Height-ballPic.Height;//window width minus picturebox height
            Point current = ballPic.Location;//original location on tick
            Task.Run(() => 
            {
                if (ballPic.Location.X >= xUpperLimit)
                {
                    directionX = Direction.negative;
                }
                if (ballPic.Location.X <= LowerLimit)
                {
                    directionX = Direction.positive;
                }
                if (directionX == Direction.positive)
                {
                    current.X++;//location transform on the positive diretion of x axis
                }
                else if(directionX==Direction.negative)//location transform on the negative diretion of x axis
                {
                    current.X--;
                }
                if (ballPic.Location.Y >= yUpperLimit)//location transform on the positive diretion of y axis
                {
                    directionY = Direction.positive;
                }
                if (ballPic.Location.Y <= LowerLimit)
                {
                    directionY = Direction.negative;
                }
                if (directionY == Direction.positive)//location transform on the negative diretion of y axis
                {
                    current.Y--;
                }
                else 
                {
                    current.Y++;
                }
                Action action = () => ballPic.Location = current;
                ballPic.BeginInvoke(action);
            });
            
        }
        private void RandomizeLocation()
        {
            Random rnd = new Random();
            Point position = ballPic.Location;
            int maxHeight = (int)ClientSize.Height;
            int maxWidth = (int)ClientSize.Width;
            position.X = rnd.Next(maxWidth);
            position.Y = rnd.Next(maxHeight);
            ballPic.Location = position;
        }
    }
}
