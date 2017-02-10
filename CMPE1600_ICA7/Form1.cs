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
        Color color = Color.Red;
        bool border = false;
        int coorInc = 1;
        
        public Form1()
        {
            InitializeComponent();
        }
        //Initializes gdi canvas and puts a first dot
        private void Form1_Load(object sender, EventArgs e)
        {
            
            canvas.Scale = 20;
            canvas.AddCenteredEllipse(15, 15, 1, 1, Color.Red);
        }
        //Checks what key was pressed, and sends for
        //methods based on that key
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
                    color = Color.Blue;
                    break;
                case Keys.R:
                    color = Color.Red;
                    break;
                case Keys.G:
                    color = Color.Green;
                    break;
                case Keys.F1:
                    border = true;
                    break;
                case Keys.X:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
        //Draws circle one coor up
        public void UpPress()
        {
            yCoor -= coorInc;
            yCoor = (yCoor < 0) ? 0 : yCoor;

            if (border == false)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color);
            }
            else
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color, 1, Color.White);

        }
        //Draws circle one coor down
        public void DownPress()
        {
            yCoor += coorInc;
            yCoor = (yCoor > 29) ? 29 : yCoor;
            if (border == false)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color);
            }
            else
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color, 1, Color.White);
        }
        //Draws circle one coor left
        public void LeftPress()
        {
            xCoor -= coorInc;
            xCoor = (xCoor < 0) ? 0 : xCoor;
            if (border == false)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color);
            }
            else
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color, 1, Color.White);
        }
        //Draws circle one coor right
        public void RightPress()
        {
            xCoor += coorInc;
            xCoor = (xCoor > 29) ? 29 : xCoor;
            if (border == false)
            {
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color);
            }
            else
                canvas.AddCenteredEllipse(xCoor, yCoor, 1, 1, color, 1, Color.White);
        }
        //Checks if ctrl, alt, or shift are held down
        //changes coor shift appropriately
        //Resets once key is lifted
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Shift)
            {
                coorInc = 2;
            }
            else if (e.Alt)
            {
                coorInc = 4;
            }
            else if (e.Control)
            {
                coorInc = 3;
            }
            else
                coorInc = 1;
        }
        //Checks that F1 is no longer pressed
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                border = false;
            }
        }
    }
}
