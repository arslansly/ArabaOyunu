using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;
            pictureBox3.Location = new Point(pictureBox3.Location.X -10, pictureBox3.Location.Y);

        }
    }
    
}
