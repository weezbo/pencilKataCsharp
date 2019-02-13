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
            
        }
    }
}