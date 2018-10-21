```csharp
//McGinn_Joseph_Analyzers
//10-22-18
//CMPS-4143
//This portion of the project uses the AnalyzersLib
//  to play a game with the various types of Analyzers

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalyzerLib;
using System.IO;

namespace McGinn_Joseph_Analyzers
{
    public partial class GameForm : Form
    {
        private Analyzer _analyzer;
        private int _r, _c, _maxGuess, _numsamp, _collected;
        private bool _isText;
        private bool _UDLR = true;
        public GameForm()
        {
            InitializeComponent();
        }

        //player wants to make a guess
        private void GuessButton_Click(object sender, EventArgs e)
        {
            bool didWin, didLose, p, foundSample;
            int gRow, gCol;

            //check column(X value)
            p = int.TryParse(ColBox.Text, out gCol);
            if(p && gCol < _c)
            {
                p = int.TryParse(RowBox.Text, out gRow);
                if(p && gRow < _r)
                {
                    foundSample = _analyzer.EvaluateGuess(gCol, gRow, _UDLR);
                    _UDLR = !_UDLR;
                    UpdateScreen();
                    didWin = _analyzer.GameWon();
                    didLose = _analyzer.GameLost();
                    Guesses.Text = _analyzer.CGuesses.ToString();

                    if(foundSample)
                    {
                        //Shows the number of samples the user
                        //has collected across all analyzers
                        //since the app has been opened
                        _collected++;
                        CollectedLabel.Text = "collected " + _collected.ToString()
                            + " piece(s) of evidence";
                    }
                    if(didWin)
                    {
                        MessageBox.Show("You Win!");
                        GuessButton.Enabled = false;
                    }
                    else if (didLose)
                    {
                        MessageBox.Show("You Lost!");
                        GuessButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row guess");
                }

            }
            else
            {
                MessageBox.Show("Invalid column guess");
            }
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //se which radio button is checked
            RadioButton rad = ConfigBox.Controls.OfType<RadioButton>()
                .Where(x=>x.Checked).FirstOrDefault();
            //read file inputs 
            //catch the slew of possible resulting errors
            try
            {
                GetData();
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found");
                return;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Path to file is incorrect");
                return;
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Enter a file location");
                return;
            }

            //make sure a radio button is selected, load the proper analyzer
            if(rad!=null)
            {
                switch(rad.Name)
                {
                    case "RadioWeapons":
                        WeaponAnalyzer weapons = new WeaponAnalyzer(_r, _c, _maxGuess, _numsamp);
                        _analyzer = weapons;
                        _isText = false;
                        break;
                    case "RadioDNA":
                        DNAanalyzer dna = new DNAanalyzer(_r, _c, _maxGuess, _numsamp);
                        _analyzer = dna;
                        _isText = false;
                        break;
                    case "RadioFingerprints":
                        PrintAnalyzer print = new PrintAnalyzer(_r, _c, _maxGuess, _numsamp);
                        _analyzer = print;
                        _isText = true;
                        break;
                }
                UpdateScreen();
                Guesses.Text = _analyzer.CGuesses.ToString();
                GuessButton.Enabled = true;


            }
            else
            {
                MessageBox.Show("You must select an analyzer");
            }

        }

        //read data from file, place in appropriate variables
        private void GetData()
        {
            string fiLoc = FileLocation.Text;
            string filename;
            string[] lines;
            int r, c, g, s;

            bool p;

            try
            {
                lines = System.IO.File.ReadAllLines(@FileLocation.Text);
                filename = Path.GetFileName(FileLocation.Text);
            }
            catch (System.IO.FileNotFoundException)
            {
                throw;
            }

            FileNameLable.Text = filename;
            //make sure row is valid
            p = int.TryParse(lines[0], out r);
            if(p && r <= 10 && r > 0)
            {
                _r = r;
                //make sure column is valid
                p = int.TryParse(lines[1], out c);
                if (p && c <= 10 && c > 0)
                {
                    _c = c;
                    //make sure guess is a valid int
                    p = int.TryParse(lines[2], out g);
                    if (p && g > 0)
                    {
                        _maxGuess = g;
                        //make sure sample is valid
                        //make sure number of samples is valid
                        p = int.TryParse(lines[3], out s);
                        if (p && s > 0 && s <= c * r)
                        {
                            _numsamp = s;
                        }
                        else
                        {
                            MessageBox.Show("invalid number of guesses");
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalid number of guesses");
                    }
                }
                else
                {
                    MessageBox.Show("invalid number of columns");
                }

            }
            else
            {
                MessageBox.Show("invalid number of rows");
            }
        }

        private void UpdateScreen()
        {
            if(! _isText)
            {
                Image[,] images = _analyzer.DisplayGrid();
                PictureBox[,] evidence = new PictureBox[images.GetLength(0), images.GetLength(1)];
                PlayArea.Controls.Clear(); //clear old boxes

                for (int i = 0; i < evidence.GetLength(0); i++)
                {
                    for (int j = 0; j < evidence.GetLength(1); j++)
                    {
                        evidence[i, j] = new PictureBox();
                        evidence[i, j].Location = new Point(j * 50 + 1, i * 50 + 1);//setting x and y points
                        evidence[i, j].Size = new Size(50, 50);
                        evidence[i, j].BorderStyle = BorderStyle.FixedSingle;
                        evidence[i, j].Image = images[i, j];
                        PlayArea.Controls.Add(evidence[i, j]);
                    }
                }
            }
            else if(_isText)
            {
                PlayArea.Controls.Clear();//clear old boxes/text

                Label PlayLabel = new Label();
                PlayLabel.Text = _analyzer.PrintGrid();
                PlayLabel.Font = PlayText.Font;
                PlayLabel.Dock = DockStyle.Fill;
                PlayArea.Controls.Add(PlayLabel);
            }
        }

    }
}

```
