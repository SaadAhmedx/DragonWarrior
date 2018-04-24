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

namespace DragonWarrior
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(StartGame_KeyDown);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
           // player.SoundLocation = "../assests/fight.wav";
            player.SoundLocation = "../assests/fight.wav";
            player.Load();
            player.Play();
            timer1.Start();
        }

        public void log(string winner)
        {
            DateTime theDate = DateTime.UtcNow;
            DateTime now = DateTime.Now;
            string date = now.ToString("d");       
            string time = now.ToString("T");
            string logs = "Time : "+ time +" Date : "+ date +" Winner : "+ winner;
            StreamWriter write = new StreamWriter("logs.txt", true);
            write.WriteLine(logs);
            write.Close();

          //  MessageBox.Show(logs);
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void restart_Form() {
            Form1 st = new Form1();
            this.Hide();
            st.Show();
        }

        private void StartGame_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            timer4.Start();

            
        }

        private void StartGame_KeyDown(object sender, KeyEventArgs e)
        {

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Right && pictureBox1.Location.X < 500) { x += 3; }
            else if (e.KeyCode == Keys.Left && pictureBox1.Location.X > 0) x -= 3;
            else if (e.KeyCode == Keys.Up && pictureBox1.Location.Y > 31) { y -= 7; }
            else if (e.KeyCode == Keys.Down && pictureBox1.Location.Y < 350) { y += 7; }

            pictureBox1.Location = new Point(x, y);
        }

        private void StartGame_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private int RandGen() {
            Random rnd = new Random();
            return rnd.Next(2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            progressBar4.Increment(1);

            if (progressBar4.Value == 100)
            {
               pictureBox2.Visible = false;
               pictureBox4.Visible = true;
               Dpower.Start();

                int loc = RandGen();

                if (loc == 0)
                {
                    pictureBox4.Location = new Point(-43, 287);
                }
                else if (loc == 1)
                {
                    pictureBox4.Location = new Point(-43, 88);
                }
                else
                {
                    pictureBox4.Location = new Point(-43, 33);
                }

                
                
               // pictureBox2.Visible = false;

                
                progressBar4.Value = 0;
                if (pictureBox4.Bounds.IntersectsWith(pictureBox1.Bounds))
                {

                    try
                    {

                        progressBar1.Value -= 10;

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        reset();
                       MessageBox.Show("Dragon Wins");
                       log("Dragon");
                        restart_Form();
                    }
 
                }
                timer2.Start();
                timer1.Stop();
            }

            progressBar3.Increment(1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            int xX = pictureBox5.Location.X;
            int yY = pictureBox5.Location.Y;
            xX -= 3;
            pictureBox5.Location = new Point(xX, yY);
        }

        private void Dpower_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox2.Visible = true;
            
            timer1.Start();
            Dpower.Stop();
        }

        private void orchi_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            orchi.Stop();
           
        }

        private void dragon_ball_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Location.X <= -104)
            {
                pictureBox5.Visible = true;
                int fireX = pictureBox2.Location.X;
                int fireY = pictureBox2.Location.Y;
                pictureBox5.Location = new Point(fireX - 100, fireY + 167);
            }

            if (pictureBox5.Bounds.IntersectsWith(pictureBox6.Bounds) || pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds))
            {

                pictureBox5.Visible = false;
                

                pictureBox5.BackColor = Color.Transparent;
                try
                {            
                    progressBar1.Value -= 5;

                }
                catch (ArgumentOutOfRangeException)
                {
                  reset();
                  MessageBox.Show("Dragon Wins");
                  log("Dragon");
                    restart_Form();
                    dragon_ball.Stop();
                }
               

            }
        }

        void reset()
        {
            pictureBox1.Dispose();
            pictureBox2.Dispose();
            pictureBox4.Dispose();
            pictureBox5.Enabled = false;
            progressBar4.Enabled = false;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            dragon_ball.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void Dmove_Tick(object sender, EventArgs e)
        {
            int loc = RandGen();

            if (loc == 0)
            {
                pictureBox2.Location = new Point(600, 6);
            }
            else if (loc == 1)
            {
                pictureBox2.Location = new Point(600, 109);
            }
            else
            {
                pictureBox2.Location = new Point(600, 33);
            }
        }

        private void pow_Tick(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = true;
            pow.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void StartGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                pictureBox1.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox6.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                pictureBox7.Location = new Point(pictureBox2.Location.X + 80, pictureBox2.Location.Y + 130);
                pow.Start();

                if (pictureBox7.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    try
                    {

                        progressBar2.Value -= 2;

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        reset();
                       MessageBox.Show("Orchi Wins");
                       log("Orchi");
                        restart_Form();
                    }

                }
            }

            if (progressBar3.Value == 100)
            {
                if (e.KeyCode == Keys.A)
                {
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox3.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                    orchi.Start();
                    if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
                    {
                        try
                        {

                            progressBar2.Value -= 10;

                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            reset();
                            MessageBox.Show("Orchi Wins");
                            log("Orchi");
                            restart_Form();
                        }

                    }
                    progressBar3.Value = 0;

                    timer3.Start();


                }



            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
