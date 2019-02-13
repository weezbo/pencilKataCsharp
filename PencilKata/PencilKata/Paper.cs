namespace PencilKata
{
    public class Paper
    {
        //Properties
        public string Text { get; set; }
        public int LastEditIndex { get; set; }

        public Paper()
        {
            LastEditIndex = -1;
        }
        
    }
}