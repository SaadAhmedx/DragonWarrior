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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("logs.txt");
            string lines = "";
            while (lines != null)
            {
                lines = read.ReadLine();
                if (lines != null)
                {
                    listBox1.Items.Add(lines);
                }
            }
        }
    }
}
