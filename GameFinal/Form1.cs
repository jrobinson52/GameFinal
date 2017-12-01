using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int updatedX = 0; //default locations
        int updatedY = 416;

        private void pnlPlayer_Paint(object sender, PaintEventArgs e)
        {
            // positions are measured from the top left of the level panel

            //initial location of player
            pnlPlayer.Location = new Point(0, 416); //this is the top left corner of the player panel
            bool Won = false;



            //game loop
            while (!Won) //while we haven't won or died
            {


                updatePlayerPosition();


                //am I at the end of level
                if (updatedX <= 1000)
                    Won = true;

            }

        }

        public void updatePlayerPosition()
        {
            bool moved = false;
            Point updatedPoint = new Point(updatedX, updatedY);
            while (!moved)
            {
                pnlPlayer.Location = updatedPoint;
            }
                     

        }

        public void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Point x = new Point(5, 0);
                // updatedX = updatedX - 5;
                pnlPlayer.Location = pnlPlayer.Location.X + 5; 
            }

            if (e.KeyCode == Keys.Right)
            {
               // updatedX = updatedX + 5;
            }

        }
    }
}
