```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAnalyzers
{
    public abstract class Analyzer
    {
        private int _rows, _cols;

        //default constructor
        public Analyzer(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
        }
        
        //Evaluates user guesses much like ScanAnalyzer did
        public abstract bool EvaluateGuess();

        public abstract override string ToString();
    }
}
```
