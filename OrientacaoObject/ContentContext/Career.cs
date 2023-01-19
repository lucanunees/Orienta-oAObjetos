namespace Orientacao.ContentContext
{
    public class Career : Content
    {
        //Como estou pedindo no construtor do content um title e uma URL, eu preciso
        // Passar através do construtor o article também os parametros
        public Career(string title, string url)
        :base(title,url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items {get; set;}
       
       // E pode ser feito da forma body express, quando tem apenas uma linha
       // de código, é possivel simplificar.
        public int TotalCourses => Items.Count;

        /* Pode ser feito desta forma:       
        public int TotalCourses 
        { 
            get
            {
                return Items.Count;
            } 
        }
        */
    }


}