using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonWarrior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HighScore score = new HighScore();
            this.Hide();
            score.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instruction instruct = new Instruction();
            this.Hide();
            instruct.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame startGame = new StartGame();
            this.Hide();
            startGame.Show();
        }
    }
}
