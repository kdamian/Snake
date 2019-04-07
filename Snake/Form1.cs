using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {

        private bool if_game_avtive;
        private Snake snake;

        public Form1()
        {
            InitializeComponent();
            if_game_avtive = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (if_game_avtive)
            {
                game_field.CreateGraphics().Clear(Color.Black);
                snake.Move();
            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 15);
                Brush b = new SolidBrush(Color.Aqua);
                game_field.CreateGraphics().DrawString("Press the Start", f, b, 80, 135);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if_game_avtive = true;
            snake = new Snake(game_field.Width, game_field.Height);
        }
    }
}
