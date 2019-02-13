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
                    Durability -= 1;
                }
            }
            paper.Text += sentence;
            
            return sentence;
        }
        
        
    }
}