```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnalyzerLib
{
    public class WeaponAnalyzer : DNAanalyzer
    {
        public WeaponAnalyzer(int rows, int cols, int guesses, int samples)
            : base(rows, cols, guesses, samples)
        {
        }

        //overrides DNA's evaluate guess by placing a gun image instead of
        //a dna image
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
                    _grid[_samples[index].Y, _samples[index].X] = Image.FromFile("gun.jpg");
                    _found++;
                    _samples[index].X = -1;
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

    }
}

```
