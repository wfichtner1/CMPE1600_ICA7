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
                    break;
                case Keys.G:
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
            yCoor -= 1;
            canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
        }
        public void DownPress()
        {
            yCoor += 1;
            canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
        }
        public void LeftPress()
        {
            xCoor -= 1;
            canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
        }
        public void RightPress()
        {
            xCoor += 1;
            canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, Color.Red);
        }
        public void BlueBall()
        {

        }
    }
}
