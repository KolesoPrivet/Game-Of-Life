using System;
using System.Drawing;

namespace Game_Of_Life
{
    class Rules
    {
        #region Fields
        private int x, y;
        private int _xStep = 10;
        private int _yStep = 10;
        private bool _createFlag;
        private int _countLive = 0;
        private int _countDead = 0;
        internal bool[,] universe;

        internal int CountLive { get { return _countLive; } set { _countLive = value; } }
        internal int CountDead { get { return _countDead; } set { _countDead = value; } }

        internal int X { get { return x; } set { x = value; } }
        internal int Y { get { return y; } set { y = value; } }

        internal bool CreateFlag { get { return _createFlag; } set { _createFlag = value; } }

        internal int YStep { get { return _yStep; } set { _yStep = value; } }
        internal int XStep { get { return _xStep; } set { _xStep = value; } }

        private MainForm form;
        #endregion

        public Rules(MainForm form)
        {
            this.form = form;
        }

        public void CreateUniverse()
        {
            _countLive = 0;
            _countDead = 0;

            X = 75;
            Y = 50;

            universe = new bool[X, Y];

            form.pictureBox.Width = X * 10 + 5;
            form.pictureBox.Height = Y * 10 + 5;

            //Рисуем вселенную
            Bitmap img = new Bitmap(form.pictureBox.Width, form.pictureBox.Height);
            using ( Graphics graphics = Graphics.FromImage(img) )
            {
                graphics.FillRectangle(Brushes.Black, 0, 0, form.pictureBox.Width, form.pictureBox.Height);

                for ( int i = 0; i <= X; i++ )
                {
                    graphics.DrawLine(Pens.CornflowerBlue, i * XStep, 0, i * XStep, form.pictureBox.Height);
                }

                for ( int i = 0; i <= Y; i++ )
                {
                    graphics.DrawLine(Pens.CornflowerBlue, 0, i * YStep, form.pictureBox.Width, i * YStep);
                }
            }

            form.pictureBox.Image = img;

        }

        public void ShowLives()
        {
            Image img = form.pictureBox.Image;
            using ( Graphics graph = Graphics.FromImage(img) )
            {
                for ( int i = 0; i < X; i++ )
                {
                    for ( int j = 0; j < Y; j++ )
                    {
                        if (universe[i, j] )
                            graph.FillRectangle(Brushes.CornflowerBlue, i * XStep + 2, j * YStep + 2, 7, 7);
                        else
                            graph.FillRectangle(Brushes.Black, i * XStep + 1, j * YStep + 1, 9, 9);
                    }
                }
            }
            form.pictureBox.Image = img;
        }

        public int LiveNeighborsCount(bool[,] curUniverse, int x, int y)
        {
            int tmp = 0;

            if ( x != 0 )
            {
                if ( y != 0 )
                    if ( curUniverse[x - 1, y - 1] )
                        tmp++;

                if ( curUniverse[x - 1, y] )
                    tmp++;

                if ( y != this.y - 1 )
                    if ( curUniverse[x - 1, y + 1] )
                        tmp++;
            }

            if ( x != this.x - 1 )
            {
                if ( y != 0 )
                    if ( curUniverse[x + 1, y - 1] )
                        tmp++;

                if ( curUniverse[x + 1, y] )
                    tmp++;

                if ( y != this.y - 1 )
                    if ( curUniverse[x + 1, y + 1] )
                        tmp++;
            }

            if ( y != 0 )
                if ( curUniverse[x, y - 1] )
                    tmp++;

            if ( y != this.y - 1 )
                if ( curUniverse[x, y + 1] )
                    tmp++;

            return tmp;
        }

        public void CreatePopulation()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            universe = new bool[x, y];
            for ( int i = 0; i < x; i++ )
            {
                for ( int j = 0; j < y; j++ )
                {
                    universe[i, j] = (r.NextDouble() > 0.5);
                }
            }
            ShowLives();

            _createFlag = true;
        }

        public void LabelCount()
        {
            _countLive = 0;

            for ( int i = 0; i < X; i++ )
            {
                for ( int j = 0; j < Y; j++ )
                {
                    if (universe[i, j] == true)
                        _countLive++;
                }
            }
        }

        public void NextGen()
        {
            bool[,] nextGenUniverse = new bool[X, Y];

            for ( int i = 0; i < X; i++ )
            {
                for ( int j = 0; j < Y; j++ )
                {
                    if ( LiveNeighborsCount(universe, i, j) == 3 )
                    {
                        if ( !universe[i, j] )
                            nextGenUniverse[i, j] = true;
                    }
                }
            }

            for ( int i = 0; i < X; i++ )
            {
                for ( int j = 0; j < Y; j++ )
                {
                    if ( universe[i, j] )
                    {
                        if (LiveNeighborsCount(universe, i, j) == 3 ||
                            LiveNeighborsCount(universe, i, j) == 2)
                            nextGenUniverse[i, j] = true;
                        else
                        {
                            nextGenUniverse[i, j] = false;
                            _countDead++;
                        }

                    }
                }
            }

            universe = nextGenUniverse;

            ShowLives();
        }
    }
}
