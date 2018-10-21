using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnalyzerLib
{
    public class PrintAnalyzer : Analyzer
    {
        private char[,] _grid;

        public PrintAnalyzer(int rows, int cols, int guesses, int samples) :
            base(rows, cols, guesses, samples)
        {
            _grid = new char[rows, cols];
            PopulateArray();
        }

        //public override bool EvaluateGuess()
        //  Accepts an x and y coordinate and a bool to 
        //      determine which direction to guide the user
        //  returns true if guess is correct; false otherwise 
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
                    _grid[_samples[index].Y, _samples[index].X] = '@';
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
                            _grid[y, x] = '^';
                        }
                        else if (y < _samples[i].Y)
                        {
                            _grid[y, x] = 'V';
                        }
                        else if (y == _samples[i].Y)
                        {
                            _grid[y, x] = '-'; // if guess is in same row
                        }
                    }
                    //guide horizontal if UDLR == false
                    else if (!UDLR)
                    {
                        if (x > _samples[i].X)
                        {
                            _grid[y, x] = '<';
                        }
                        else if (x < _samples[i].X)
                        {
                            _grid[y, x] = '>';
                        }
                        else if (x == _samples[i].X)
                        {
                            _grid[y, x] = '|'; // if guess is in same column
                        }
                    }
                    _curGuesses++;
                    return false;
                }
            }

        }

        //Tpublic overide string PrintGrid()
        public override string PrintGrid()
        {
            string gridString = "";
            

            for (int r = 0; r < _rows; r++)
            {
                gridString += "";
                for (int c = 0; c < _cols; c++)
                {
                    gridString += " ";
                    gridString += _grid[r, c].ToString();
                    gridString += " ";
                }
                gridString += Environment.NewLine;
                gridString += Environment.NewLine;
            }

            return gridString;
        }

        public override Image[,] DisplayGrid()
        {
            throw new NotImplementedException();
        }

        //private void PopulateArray
        private void PopulateArray()
        {
            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    _grid[r, c] = '~';
                }
            }
        }


    }

}
