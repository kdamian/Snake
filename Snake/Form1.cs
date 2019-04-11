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

        private bool if_game_active;
        private Snake snake;
        private Fruit fruit;

        public Form1()
        {
            InitializeComponent();
            if_game_active = false;
            timer1.Enabled = true;
            pauseToolStripMenuItem.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (if_game_active)
            {
                game_field.CreateGraphics().Clear(Color.Black);
                snake.Move();
                snake.draw(game_field.CreateGraphics(), new SolidBrush(Color.Aqua));
                fruit.draw_fruit(game_field.CreateGraphics(), new SolidBrush(Color.Red));
                if (fruit.if_new_fruit(snake.x[0], snake.y[0]))
                {
                    snake.add();
                }
                if (snake.if_snake_alive() == false)
                {
                    if_game_active = false;
                }
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
            if_game_active = true;
            snake = new Snake(game_field.Width, game_field.Height);
            fruit = new Fruit(snake.segment);
            pauseToolStripMenuItem.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) snake.move = "up";
            if (e.KeyCode == Keys.Down) snake.move = "down";
            if (e.KeyCode == Keys.Right) snake.move = "right";
            if (e.KeyCode == Keys.Left) snake.move = "left";
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (if_game_active)
            {
                if_game_active = false;
                pauseToolStripMenuItem.Text = "Return";
                game_field.CreateGraphics().Clear(Color.Black);
            }
            else
            {
                if_game_active = true;
                pauseToolStripMenuItem.Text = "Pause";
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (if_game_active)
            {
                snake = new Snake(game_field.Width, game_field.Height);
                fruit = new Fruit(snake.segment);
            }
        }

        private void fasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 10) { timer1.Interval -= 10; }
        }

        private void slowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }
    }
}
