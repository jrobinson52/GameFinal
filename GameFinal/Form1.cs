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

        int updatedX = 1; //default locations
        int updatedY = 416;
        bool Won = false;
        

        private void pnlPlayer_Paint(object sender, PaintEventArgs e)
        {
            /*
            // positions are measured from the top left of the level panel

            //initial location of player
            pnlPlayer.Location = new Point(updatedX, updatedY); //this is the top left corner of the player panel
            bool Won = false;



            //game loop
            //while (!Won) //while we haven't won or died
            {


                updatePlayerPosition();


                //am I at the end of level
                if (updatedX >= 1000)
                    Won = true;

            }
            */
        }

        public void updatePlayerPosition()
        {
            bool moved = false;

            while (!moved)
            {
                lblX.Text = Convert.ToString(updatedX);
                lblY.Text = Convert.ToString(updatedY);
                pnlPlayer.Location = new Point(updatedX, updatedY);
                moved = true;
            }


        }

        public void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            bool atBegin = false;

            if (!Won || !atBegin) //while we haven't won or died
            {
                //am I at the end of level
                if (updatedX >= (1000 - 70)) // -70 for width of player
                    Won = true;

                if (updatedX <= 0) //at left boundary
                    updatedX = updatedX + 5;
                    

                if (e.KeyCode == Keys.Left)
                {
                    updatedX = updatedX - 5;
                }

                if (e.KeyCode == Keys.Right)
                {
                    updatedX = updatedX + 5;
                }
                updatePlayerPosition(); //update co-ordinates displayed and location of player
                
            }


        }
    }
}
