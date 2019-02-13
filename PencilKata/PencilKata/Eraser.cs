using System;
using System.Diagnostics.Tracing;

namespace PencilKata
{
    public class Eraser
    {
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
                string updated = backPart.Replace(word, generateSpaces(word));
                paper.Text = frontPart + updated;
            }
        }

        public string generateSpaces(string word)
        {
            string spaces = null;
            for (int i = 0; i < word.Length; i++)
            {
                spaces += " ";
            }

            return spaces;
        }
    }
}