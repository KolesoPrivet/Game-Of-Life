using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class MainForm : Form
    {
        private readonly Rules rules;
        private readonly Stopwatch _stopwatch = new Stopwatch();
        public MainForm()
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
            //rules.NextGen();
        }

        private void pictureBox_Click(object sender, MouseEventArgs e)
        {
            rules.universe[e.X / rules.XStep, e.Y / rules.YStep] = true;
            rules.ShowLives();
        }

        private void button_Let_Them_Go_Click(object sender, EventArgs e)
        {
            _stopwatch.Reset();
            _stopwatch.Start();
            timer1.Enabled = !(timer1.Enabled);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Count_Time.Text = _stopwatch.Elapsed.Seconds.ToString();

            //button_Next_Gen_Click(this, null);
            rules.NextGen();
            rules.LabelCount();

            label_Count_Live.Text = rules.CountLive.ToString();
            label_Count_Dead.Text = rules.CountDead.ToString();
        }

        private void button_Exterminatus_Click(object sender, EventArgs e)
        {
            rules.CreateUniverse();
        }

        private void button_Create_Population_Click(object sender, EventArgs e)
        {
            label_Count_Live.Text = 0.ToString();
            label_Count_Dead.Text = 0.ToString();
            label_Count_Time.Text = 0.ToString();

            rules.CreatePopulation();
        }
    }
}
