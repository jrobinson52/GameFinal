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

        private void pnlPlayer_Paint(object sender, PaintEventArgs e)
        {
            // positions are measured from the top left of the level panel
            //initial location of player
            pnlPlayer.Location = new Point(0, 416); //this is the top left corner of the player panel

            


            //game loop
            while(true) //while we haven't won or died
            {

            }



        }
    }
}
