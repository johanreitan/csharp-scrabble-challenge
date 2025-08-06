using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{


    public class Scrabble
    {
        public MyDictionary myDictionary = new MyDictionary();

        private string _word;




        public Scrabble(string word)
        {
            _word = word;
        }

        public int score()
        {
            int _score = 0;
            int _multiplier = 1;
            //TODO: score calculation code goes here
            //throw new NotImplementedException(); //TODO: Remove this line when the code has been written
            foreach (var c in _word)
            {
                int tempScore = 0;

                if (c == '{')
                {
                    _multiplier = 2;
                }
                else if (c == '}')
                {
                    _multiplier = 1;
                }
                else if (c == '[')
                {
                    _multiplier = 3;
                }
                else if (c == ']')
                {
                    _multiplier = 1;
                }
                else if (myDictionary.KeyIsContained(char.ToLower(c)))
                {
                    tempScore = myDictionary.GetValue(char.ToLower(c)) * _multiplier;
                }
                else 
                {
                    return 0;
                }
                    _score += tempScore;
                }

                    

                
            
            return _score;
        }
    }
}

