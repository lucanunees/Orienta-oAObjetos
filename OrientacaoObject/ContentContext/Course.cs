using Orientacao.ContentContext.Enums;

namespace Orientacao.ContentContext
{
    public class Course : Content
    {
        //Como estou pedindo no construtor do content um title e uma URL, eu preciso
        // Passar através do construtor o article também os parametros
        public Course(string title, string url, EContentLevel level)
        :base(title, url)
        {
            Modules = new List<Module>();
            Level = level;
        }
        public string Tag { get; set; } // Tag do curso;
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }

}