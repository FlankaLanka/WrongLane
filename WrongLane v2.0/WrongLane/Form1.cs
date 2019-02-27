using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WrongLane
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZebraMover_Tick(object sender, EventArgs e)
        {//Movement of Street Lines
            zebra1.Left = zebra1.Left - 1;
            if(zebra1.Right<=0)
            {
                zebra1.Left = 400;
            }

            zebra2.Left = zebra2.Left - 1;
            if (zebra2.Right <= 0)
            {
                zebra2.Left = 400;
            }

            zebra3.Left = zebra3.Left - 1;
            if (zebra3.Right <= 0)
            {
                zebra3.Left = 400;
            }

            zebra4.Left = zebra4.Left - 1;
            if (zebra4.Right <= 0)
            {
                zebra4.Left = 400;
            }

            zebra5.Left = zebra5.Left - 1;
            if (zebra5.Right <= 0)
            {
                zebra5.Left = 400;
            }

            zebra6.Left = zebra6.Left - 1;
            if (zebra6.Right <= 0)
            {
                zebra6.Left = 400;
            }

            zebra7.Left = zebra7.Left - 1;
            if (zebra7.Right <= 0)
            {
                zebra7.Left = 400;
            }

            zebra8.Left = zebra8.Left - 1;
            if (zebra8.Right <= 0)
            {
                zebra8.Left = 400;
            }

            //Checks for car collision and ends game

            if (OrangeCar.Bounds.IntersectsWith(BlueCar.Bounds) || OrangeCar.Bounds.IntersectsWith(PurpleCar.Bounds) || OrangeCar.Bounds.IntersectsWith(GreenCar.Bounds))
            {
                GameOver();
            }

        }

        private void GameOver()
        {
            ZebraMover.Stop();
            BlueMove.Stop();
            PurpleMove.Stop();
            GreenMove.Stop();
            GameEnd.Visible = true;
            PlayAgainButton.Visible = true;

            //Stops orange car from moving
            MoveUp.Stop();
            MoveDown.Stop();
            MoveRight.Stop();
            MoveLeft.Stop();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//Start timer to move car
            if (e.KeyCode == Keys.Up)
            {
                MoveUp.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveDown.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight.Start();
            }

            if (e.KeyCode == Keys.Left)
            {
                MoveLeft.Start();
            }
        }
        //Next 4 functions are timers to move car
        private void MoveUp_Tick(object sender, EventArgs e)
        {
            if(OrangeCar.Top>0)
            {
                OrangeCar.Top = OrangeCar.Top - 2;
            }
        }

        private void MoveDown_Tick(object sender, EventArgs e)
        {
            if(OrangeCar.Top < 176)
            {
                OrangeCar.Top = OrangeCar.Top + 2;
            }
        }

        private void MoveRight_Tick(object sender, EventArgs e)
        {
            if (OrangeCar.Left < 450)
            {
                OrangeCar.Left = OrangeCar.Left + 2;
            }
      
        }

        private void MoveLeft_Tick(object sender, EventArgs e)
        {
            if (OrangeCar.Left > 0)
            {
                OrangeCar.Left = OrangeCar.Left - 2;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {//Stops movement when key is lifted
            MoveUp.Stop();
            MoveDown.Stop();
            MoveRight.Stop();
            MoveLeft.Stop();
        }


        //variables for score
        int points = 0;
        string score = "Score: ";

        //inital speed of enemy cars
        int Bspeed = 4;
        int Pspeed = 7;
        int Gspeed = 4;

        private void BlueMove_Tick(object sender, EventArgs e)
        {//Control blue car movement

            Random rng = new Random(Guid.NewGuid().GetHashCode());
            int randlength = rng.Next(700,801);
            int randheight = rng.Next(0, 59);         

            if (BlueCar.Right > 0)
            {
                BlueCar.Left = BlueCar.Left - Bspeed;
            }
            else
            {
                BlueCar.Left = randlength;
                BlueCar.Top = randheight;
                Bspeed = rng.Next(2, 8);
                points = points + 1;
                score = "Score: " + points.ToString();
                ScoreText.Text = score;
            }
        }

        private void PurpleMove_Tick(object sender, EventArgs e)
        {//Control purple car movement

            Random rng = new Random(Guid.NewGuid().GetHashCode());
            int randlength = rng.Next(700, 801);
            int randheight = rng.Next(59, 118);

            if (PurpleCar.Right > 0)
            {
                PurpleCar.Left = PurpleCar.Left - Pspeed;
            }
            else
            {
                PurpleCar.Left = randlength;
                PurpleCar.Top = randheight;
                Pspeed = rng.Next(2, 8);
                points = points + 1;
                score = "Score: " + points.ToString();
                ScoreText.Text = score;
            }
        }
        
        private void GreenMove_Tick(object sender, EventArgs e)
        {//Control green car movement

            Random rng = new Random(Guid.NewGuid().GetHashCode());
            int randlength = rng.Next(700, 801);
            int randheight = rng.Next(118,176);

            if (GreenCar.Right > 0)
            {
                GreenCar.Left = GreenCar.Left - Gspeed;
            }
            else
            {
                GreenCar.Left = randlength;
                GreenCar.Top = randheight;
                Gspeed = rng.Next(2, 8);
                points = points + 1;
                score = "Score: " + points.ToString();
                ScoreText.Text = score;
            }
            
        }

        //Reset Game on Play Again Button
        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            ScoreText.Text = "Score: 0";
            points = 0;
            Form1_Load(e, e);
        }
    }
}

