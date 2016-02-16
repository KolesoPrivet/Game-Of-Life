using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class Form1 : Form
    {
        private Rules rules;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            rules = new Rules(this);
        }

        private void button_Create_World_Click(object sender, EventArgs e)
        {
            rules.CreateUniverse();
        }

        private void button_Next_Gen_Click(object sender, EventArgs e)
        {
            bool[,] nextGenUniverse = new bool[rules.X, rules.Y];

            for ( int i = 0; i < rules.X; i++ )
            {
                for ( int j = 0; j < rules.Y; j++ )
                {
                    if ( rules.LiveNeighborsCount(rules.universe, i, j) == 3 )
                    {
                        if ( !rules.universe[i, j] )
                            nextGenUniverse[i, j] = true;
                    }
                }
            }

            for ( int i = 0; i < rules.X; i++ )
            {
                for ( int j = 0; j < rules.Y; j++ )
                {
                    if ( rules.universe[i, j] )
                    {
                        if ( rules.LiveNeighborsCount(rules.universe, i, j) == 3 ||
                            rules.LiveNeighborsCount(rules.universe, i, j) == 2 )
                            nextGenUniverse[i, j] = true;
                        else
                            nextGenUniverse[i, j] = false;
                    }
                }
            }

            rules.universe = nextGenUniverse;

            rules.ShowLives();
        }

        private void pictureBox_Click(object sender, MouseEventArgs e)
        {
            rules.universe[e.X / rules.XStep, e.Y / rules.YStep] = true;
            rules.ShowLives();
        }

        private void button_Let_Them_Go_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button_Next_Gen_Click(this, null);
        }

        private void button_Exterminatus_Click(object sender, EventArgs e)
        {
            rules.CreateUniverse();
        }

        private void button_Create_Population_Click(object sender, EventArgs e)
        {
            rules.CreatePopulation();
        }
    }
}
