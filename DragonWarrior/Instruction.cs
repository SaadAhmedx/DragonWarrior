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
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Instruction_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1. Control the fighter with the arrow keys";
            textBox2.Text = "2. Attack the dragon by pressing the 'b' key";
            textBox3.Text = "3. Once the Power is full press 'a' for the powerfull attack";
            textBox4.Text = "4. For winning the you have to kill the dragon";
            
        }
    }
}
