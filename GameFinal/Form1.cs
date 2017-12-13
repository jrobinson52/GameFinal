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
        bool jumping = false;
        int i = 0;

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

        public void walkLeft()
        {
            updatedX = updatedX - 5;
            pboxPlayer.Image = Image.FromFile("../../sprites/walk_l.gif");
        }

        public void walkRight()
        {
            updatedX = updatedX + 5;
            pboxPlayer.Image = Image.FromFile("../../sprites/walk_r.gif");
        }

        public void jump()
        {
            if (updatedY == 416) //are we on the ground
            {
                if (pboxPlayer.Image == Image.FromFile("../../sprites/walk_r.gif")) //are we going right?
                {
                    pboxPlayer.Image = Image.FromFile("../../sprites/jump_r.gif");
                }

                if (pboxPlayer.Image == Image.FromFile("../../sprites/walk_l.gif")) //are we going left?
                {
                    pboxPlayer.Image = Image.FromFile("../../sprites/jump_l.gif");
                }

                jumping = true;


                if (i < 5)
                {
                    i++;
                    updatedY = updatedY - 15; //measurements are from top left

                    if (i == 5)
                        jumping = false;
                }

            }
        }

        public bool isJumping()
        {
            if (jumping)
            {
                jump();
                return true;
            }
            else
            {
                i = 0;
                return false;
            }
        }

        public void isOffGround()
        {
            if (!isJumping()) //if I'm not jumping
            {
                if (updatedY < 416)
                {
                    updatedY = updatedY + 15; //start decending
                }
            }
        }

        public void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {


            if (!Won) //while we haven't won
            {
                //am I at the end of level
                if (updatedX >= (610 - 70)) // -70 for width of player
                    Won = true;

                //at left boundary
                if (updatedX <= 0)
                    updatedX = updatedX + 5;

                isOffGround();


                if (e.KeyCode == Keys.Left)
                {
                    walkLeft();
                }

                if (e.KeyCode == Keys.Right)
                {
                    walkRight();
                }

                if (e.KeyCode == Keys.Up)
                {
                    jump();
                }

                updatePlayerPosition(); //update co-ordinates displayed and location of player    

            }

        }
    }
}
