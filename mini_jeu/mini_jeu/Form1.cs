using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_jeu
{
    public partial class Form1 : Form
    {
        int gravity = 0;
        int speed = 0;
        int s=0;
        
        Random rnd = new Random();
        

        public Form1()
        {
            InitializeComponent();
        }
        private void timer()
        {
            int month = rnd.Next(10, 700);


            int cl = rnd.Next(10, 700);
            pictureBox5.Top += gravity;
            pictureBox5.Left += speed;

            if (pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds) || pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox5.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox5.Bounds.IntersectsWith(pictureBox4.Bounds))
            {

                endgame();


            }
            
            if (pictureBox5.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox6.Location = new Point(month, cl);
                s += 1;
                 pictureBox5.Width += 20;
            }
        }
        private void endgame()
        {
            timer1.Stop();
            panel1.Show();
            label1.Text = "you lose";
            label3.Text = label2.Text;
           //pictureBox5.Height = 20;
            //pictureBox5.Width = 20;
        }
        private void timergame(object sender, EventArgs e)
        {

            timer();
            label2.Text = "Score :" + s;

        }

        private void keydowngame(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.S)
                {
                    gravity = 10;
                    speed = 0;
                    if (pictureBox5.Height < pictureBox5.Width)
                    {
                        pictureBox5.Height = pictureBox5.Width;
                        pictureBox5.Width = 20;
                    }
                }

                if (e.KeyCode == Keys.Q)
                {
                    speed = -10;
                    gravity = 0;
                    if (pictureBox5.Height > pictureBox5.Width)
                    {
                        pictureBox5.Width = pictureBox5.Height;
                        pictureBox5.Height = 20;
                    }
                }
           


        }

        private void keydownup(object sender, KeyEventArgs e)
            
        {

           
            if (e.KeyCode == Keys.Z)
                {
                    gravity = -10;
                    speed = 0;

                if (pictureBox5.Height < pictureBox5.Width)
                {
                    pictureBox5.Height = pictureBox5.Width;
                    pictureBox5.Width = 20;
                }
                
            }

                if (e.KeyCode == Keys.D)
                {
                    speed = 10;
                    gravity = 0;
                    if (pictureBox5.Height > pictureBox5.Width)
                    {
                        pictureBox5.Width = pictureBox5.Height;
                        pictureBox5.Height = 20;
                    }
                   
                }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            label2.Text = "Score :" + s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox5.Location = new Point(500, 500);
           // panel1.Hide();
            Application.Restart();
            
            

        }
    }
}
