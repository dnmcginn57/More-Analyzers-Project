```csharp
//David McGinn, Jamal Joseph
//10-22-18
//CMPS-4143
//Analyzer class Library: This is the base class for the other analyzers
//  An Analyzer, in general, consists of a grid of varying objects
//  An Analyzer can:
//      -Display its grid, either by returning a copy of its grid,
//          or a string if the grid consists of characters
//      -Evaluate a guess, updating the grid with the proper hint
//          or with a representation of a sample
//      -Tell wether a game is won or lost

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnalyzerLib
{
    public abstract class Analyzer
    {
        protected int _rows, _cols, _totGuesses, _curGuesses, _found;
        protected Point[] _samples; // [x,y] [column, row]
        public int CGuesses
        {
            get { return _curGuesses; }
        }

        //default constructor
        //accepts int rows, int cols, int guesses, int samples
        public Analyzer(int rows, int cols, int guesses, int samples)
        {
            _found = 0;
            _rows = rows;
            _cols = cols;
            _totGuesses = guesses;
            _curGuesses = 0;
            _samples = new Point[samples];
            PlaceSamples(samples);
        }

        //Evaluates user guesses much like ScanAnalyzer did
        //classes impliment these differently
        public abstract bool EvaluateGuess(int x, int y, bool UDLR);

        //display a grid of images
        public abstract Image[,] DisplayGrid();

        //display a grid of ascii art
        public abstract string PrintGrid();

        //private void PlaceSamples
        //populates _samples array with tuples representing
        //co-ordinates of samples on a grid of some sort
        private void PlaceSamples(int s)
        {
            Random rnd = new Random();
            Point p = new Point(1, 1);
            //populate the array with tuples representing
            //  sample co-ordinates
            for (int i = 0; i < s; i++)
            {
                do
                {
                    p.X = rnd.Next(_cols);
                    p.Y = rnd.Next(_rows);
                } while (Array.Exists(_samples, element => element.Equals(p)));
                _samples[i] = p;
            }


        }

        //returns true if all sample are found
        public bool GameWon()
        {
            if (_found == _samples.Length)
                return true;
            else
                return false;
        }

        //returns true if all guesses are used up
        public bool GameLost()
        {
            if (_curGuesses == _totGuesses)
                return true;
            else
                return false;
        }

        

    }
}

```
