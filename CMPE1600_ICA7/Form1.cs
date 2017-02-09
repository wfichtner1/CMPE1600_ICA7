using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Windows.Forms;

namespace CMPE1600_ICA7
{
    public partial class Form1 : Form
    {
        CDrawer canvas = new CDrawer(600, 600);
        int xCoor = 15;
        int yCoor = 15;
        bool red = true;
        bool blue = false;
        bool green = false;
        int coorInc = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            canvas.Scale = 20;
            canvas.AddCenteredEllipse(15, 15, 1, 1, Color.Red);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    UpPress();
                    break;
                case Keys.Left:
                    LeftPress();
                    break;
                case Keys.Right:
                    RightPress();
                    break;
                case Keys.Down:
                    DownPress();
                    break;
                case Keys.B:
                    BlueBall();
                    break;
                case Keys.R:
                    RedBall();
                    break;
                case Keys.G:
                    GreenBall();
                    break;
                case Keys.X:
                    break;
                case Keys.Shift:
                    break;
                case Keys.Alt:
                    break;
                case Keys.Control:
                    break;
                default:
                    break;
            }
        }

        public void UpPress()
        {
            yCoor -= coorInc;
            yCoor = (yCoor < 0) ? 0 : yCoor;
            if (red == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
            }
            else if (blue == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Blue);
            }
            else if (green == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Green);
            }

        }
        public void DownPress()
        {
            yCoor += coorInc;
            yCoor = (yCoor > 29) ? 29 : yCoor;
            if (red == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
            }
            else if (blue == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Blue);
            }
            else if (green == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Green);
            }
        }
        public void LeftPress()
        {
            xCoor -= coorInc;
            xCoor = (xCoor < 0) ? 0 : xCoor;
            if (red == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
            }
            else if (blue == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Blue);
            }
            else if (green == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Green);
            }
        }
        public void RightPress()
        {
            xCoor += coorInc;
            xCoor = (xCoor > 29) ? 29 : xCoor;
            if (red == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
            }
            else if (blue == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Blue);
            }
            else if (green == true)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Green);
            }
        }
        public void BlueBall()
        {
            blue = true;
            red = false;
            green = false;
        }
        public void GreenBall()
        {
            green = true;
            red = false;
            blue = false;
        }
        public void RedBall()
        {
            red = true;
            blue = false;
            green = false;
        }
       
    }
}
