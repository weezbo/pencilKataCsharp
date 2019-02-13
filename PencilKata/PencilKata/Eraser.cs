using System;
using System.Diagnostics.Tracing;
using System.Text;

namespace PencilKata
{
    public class Eraser
    {
        //properties
        public int CurrentDurability { get; set; }
        
        //constructor
        public Eraser(int durability)
        {
            CurrentDurability = durability;
        }
        
        public int Finder(string word, Paper paper)
        {
            return paper.Text.LastIndexOf(word);
        }

        public void Erase(string word, Paper paper)
        {
            int startPoint = Finder(word, paper);
            if (startPoint > -1)
            {
                string frontPart = paper.Text.Substring(0, startPoint);
                string backPart = paper.Text.Substring(startPoint);
                string updated = backPart.Replace(word, GenerateSpaces(word));
                paper.Text = frontPart + updated;
            }
        }

        public string GenerateSpaces(string word)
        {
            StringBuilder spaces = new StringBuilder(word);
            for (int i = word.Length - 1; i >= 0; i--)
            {
              
                if (DegradeEraser(word[i]))
                {
                    spaces[i] = ' ';   
                }

            }
            return spaces.ToString();
        }

        private bool DegradeEraser(char letter)
        {
            if (CurrentDurability == 0)
            {
                return false;
            }
            if (letter != ' ')
            {
               CurrentDurability--;
            }

            return true;
        }
    }
}