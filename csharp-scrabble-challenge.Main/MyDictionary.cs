using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class MyDictionary
    {

        Dictionary<char, int> dictionary;

        public MyDictionary() { 
            dictionary = new Dictionary<char, int>();
            dictionary.Add('a', 1);
            dictionary.Add('b', 3);
            dictionary.Add('c', 3);
            dictionary.Add('d', 2);
            dictionary.Add('e', 1);
            dictionary.Add('f', 4);
            dictionary.Add('g', 2);
            dictionary.Add('h', 4);
            dictionary.Add('i', 1);
            dictionary.Add('j', 8);
            dictionary.Add('k', 5);
            dictionary.Add('l', 1);
            dictionary.Add('m', 3);
            dictionary.Add('n', 1);
            dictionary.Add('o', 1);
            dictionary.Add('p', 3);
            dictionary.Add('q', 10);
            dictionary.Add('r', 1);
            dictionary.Add('s', 1);
            dictionary.Add('t', 1);
            dictionary.Add('u', 1);
            dictionary.Add('v', 4);
            dictionary.Add('w', 4);
            dictionary.Add('x', 8);
            dictionary.Add('y', 4);
            dictionary.Add('z', 10);
            dictionary.Add(' ', 0);
        }

        public int GetValue(char c)
        {
            if (!dictionary.ContainsKey(c))
            {
                return 0;
            }
            return dictionary[char.ToLower(c)];
        }

        public bool KeyIsContained(char c)
        {
            return dictionary.ContainsKey(c);
        }
    }
}
