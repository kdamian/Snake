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

        public Form1()
        {
            InitializeComponent();
            if_game_avtive = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (if_game_avtive)
            {

            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 15);
                Brush b = new SolidBrush(Color.Aqua);
                game_field.CreateGraphics().DrawString("Press the Start", f, b, 80, 135);
            }
        }
    }
}
