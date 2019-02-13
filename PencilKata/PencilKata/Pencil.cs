namespace PencilKata
{
    public class Pencil
    {
        //properties
        public int Durability { get; set; }
        
        //constructor
        public Pencil(int durability)
        {
            Durability = durability;
        }
        public string Write(string sentence, Paper paper)
        {
            foreach (char letter in sentence)
            {
                if (letter != ' ')
                {
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        Durability -= 2;
                    }
                    else
                    {
                        Durability -= 1;
                    }
                }
                paper.Text += letter;
            }
            
            return sentence;
        }
        
        
    }
}