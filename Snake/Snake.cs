using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public int segments;
        public int segment;
        public int[] x = new int[900];
        public int[] y = new int[900];
        public string move;

        public Snake(int width, int hight)
        {
            segment = width / 20;
            segments = 3;
            move = "right";
            int xh = 9 * segment; //xh - head of the snake (width), a started position, center of the screen
            int yh = 9 * segment; //yh - head of the snake (hight), a started position, center of the screen
            for (int i = 0; i < segments; i++)
            {
                x[i] = xh - (i * segment);
                y[i] = yh;
            }
        }

        public void Move()
        {
            //the loop starts counting from the end of a snake to remember a position of the next segment
            for (int i = segments; i > 0; i--)
            {
                x[i] = x[(i - 1)];
                y[i] = y[(i - 1)];
            }


            //snake's moves
            if (move == "left")
            {
                x[0] = x[0] - segment;
            }
            if (move == "right")
            {
                x[0] = x[0] + segment;
            }
            if (move == "up")
            {
                y[0] = y[0] - segment;
            }
            if (move == "down")
            {
                y[0] = y[0] + segment;
            }

            //snake's transport
            if (x[0] < 0) { x[0] = segment * 19; }
            if (x[0] > segment * 20) { x[0] = 0; }
            if (y[0] < 0) { y[0] = segment * 19; }
            if (y[0] > segment * 20) { y[0] = 0; }
        }

        public void draw(Graphics g, Brush b)
        {
            for (int i = 0; i < segments; i++)
            {

            }
        }
    }
}
