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
        private int multiplier = 1;




        public Scrabble(string word)
        {
            _word = word;
        }
        /*
        public int score()
        {
            int _score = 0;
            int _multiplier = 1;

            int open3x = 0;
            int open2x = 0;
            //TODO: score calculation code goes here
            //throw new NotImplementedException(); //TODO: Remove this line when the code has been written
            foreach (var c in _word)
            {
             
                int tempScore = 0;
                

                if (c == '{')
                {
                    open2x++;
                    _multiplier = 2;
                }
                else if (c == '}')
                {
                    if (open2x == 0)
                    {
                        return 0;
                    }
                    open2x--;
                    _multiplier = 1;
                }
                else if (c == '[')
                {
                    open3x++;
                    _multiplier = 3;
                }
                else if (c == ']')
                {
                    if (open3x == 0)
                    {
                        return 0;
                    }
                    open3x--;
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
        */
       
        
        public int score()
        {
            
            //TODO: score calculation code goes here
            //throw new NotImplementedException(); //TODO: Remove this line when the code has been written
            return ScoreRecursive(_word);        
        }
        public int ScoreRecursive(string subString)
        {
            if (subString == null) return 0;
            else if (subString.Length <= 1)
            {
                return myDictionary.GetValue(subString[0]);
            }
            else if (subString[0] == '{')
            {
                multiplier *= 2;
                return ScoreRecursive(subString.Substring(1));
            }
            else if (subString[0] == '[')
            {
                multiplier *= 3;
                return ScoreRecursive(subString.Substring(1));
            }
            else if (subString[0] == '}')
            {
                multiplier /= 2;
                return ScoreRecursive(subString.Substring(1));
            }
            else if (subString[0] == ']')
            {
                multiplier /= 3;
                return ScoreRecursive(subString.Substring(1));
            }
           
            else
            {
                return multiplier * myDictionary.GetValue(subString[0]) + ScoreRecursive(subString.Substring(1));
            }
        }
    }
}

