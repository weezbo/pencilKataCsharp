using System.Text;

namespace PencilKata
{
    public class Pencil
    {
        //properties
        public int CurrentDurability { get; set; }
        public int OriginalDurability { get; set; }
        public int Length { get; set; }
        
        //constructor
        public Pencil(int durability, int length)
        {
            CurrentDurability = OriginalDurability = durability;
            Length = length;
        }
        public string Write(string sentence, Paper paper)
        {
            foreach (char letter in sentence)
            {
                char letterWritten = letter;
                if (Dull(letter))
                {
                    letterWritten = ' ';
                };
                paper.Text += letterWritten;
            }
            
            return sentence;
        }

        private bool Dull(char letter)
        {
            if (CurrentDurability <= 0)
            {
                return true;
            }
            if (letter != ' ')
            {
                if (letter >= 'A' && letter <= 'Z')
                {
                    CurrentDurability -= 2;
                }
                else
                {
                    CurrentDurability -= 1;
                }
            }

            return false;

        }

        public void Sharpen()
        {
            if (Length > 0)
            {
                CurrentDurability = OriginalDurability;
                ReduceLength(); 
            }

        }

        private void ReduceLength()
        {
            Length--;
        }

        public void Edit(string word, Paper paper)
        {
            StringBuilder paperText = new StringBuilder(paper.Text);
            StringBuilder replacement = new StringBuilder(word);
            for(int i = 0; i < word.Length; i++)
            {
                
                if (!Dull(replacement[i]))
                {
                    paperText[i + paper.LastEditIndex] = replacement[i];
                };
    
            }

            paper.Text = paperText.ToString();


        }
    }
}