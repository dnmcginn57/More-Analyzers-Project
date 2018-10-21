using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnalyzerLib
{
    public class DNAanalyzer : Analyzer
    {
        protected Image[,] _grid;

        public DNAanalyzer(int rows, int cols, int guesses, int samples) : base(rows, cols, guesses, samples)
        {

            _grid = new Image[rows, cols];
            Image leftArrow = Image.FromFile(@"leftarrow.jpg");
            Image rightArrow = Image.FromFile(@"rightarrow.jpg");
            Image upArrow = Image.FromFile(@"uparrow.jpg");
            Image downArrow = Image.FromFile(@"downarrow.jpg");
            Image blood = Image.FromFile(@"blood.jpg");
            Image hair = Image.FromFile(@"hair.jpg");
            Image dna = Image.FromFile(@"dna.jpg");
            Image horLine = Image.FromFile(@"horiline.png");
            Image vertLine = Image.FromFile(@"vertline.png");
            PopulateArray();

        }

        //TODO: public override bool EvaluateGuess()
        public override bool EvaluateGuess(int x, int y, bool UDLR)
        {

            Point p = new Point(x, y);
            int index;

            //make sure the guess is valid
            if (x > _grid.GetLength(1) - 1 || y > _grid.GetLength(0) - 1)
                throw new IndexOutOfRangeException("OB");
            else
            {
                //see if the guess is correct
                if (Array.Exists(_samples, e => e.Equals(p)))
                {
                    index = Array.IndexOf(_samples, p);
                    _grid[_samples[index].Y, _samples[index].X] = Image.FromFile("dna.jpg");
                    _found++;
                    _samples[index].X = -1;
                    _curGuesses++;
                    return true;
                }
                else
                {
                    //find the index of the next unfound sample
                    int i = 0;
                    foreach (Point pt in _samples)
                    {
                        if (pt.X == -1)
                            i++;
                    }//we are now guiding to the point in position i

                    //guide vertical if UDLR == true
                    if (UDLR)
                    {
                        if (y > _samples[i].Y)
                        {
                            _grid[y, x] = Image.FromFile("uparrow.jpg");
                        }
                        else if (y < _samples[i].Y)
                        {
                            _grid[y, x] = Image.FromFile("downarrow.jpg");
                        }
                        else if (y == _samples[i].Y)
                        {
                            _grid[y, x] = Image.FromFile("horiline.png"); // if guess is in same row
                        }
                    }
                    //guide horizontal if UDLR == false
                    else if (!UDLR)
                    {
                        if (x > _samples[i].X)
                        {
                            _grid[y, x] = Image.FromFile("rightarrow.jpg");
                        }
                        else if (x < _samples[i].X)
                        {
                            _grid[y, x] = Image.FromFile("leftarrow.jpg");
                        }
                        else if (x == _samples[i].X)
                        {
                            _grid[y, x] = Image.FromFile("vertline.png"); // if guess is in same column
                        }
                    }
                    _curGuesses++;
                    return false;
                }
            }
        }

        //public overide Image[,] DisplayGrid()
        public override Image[,] DisplayGrid()
        {
            Image[,] arr = _grid.Clone() as Image[,];

            return _grid;
        }

        //public override string PrintGrid()
        //  not used for image grid objects
        public override string PrintGrid()
        {
            return "this is a grid of images";
        }


        //private void PopulateArray
        private void PopulateArray()
        {
            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    _grid[r, c] = Image.FromFile("pwright.jpg");
                }
            }
        }

    }
}
