namespace Orientacao.ContentContext
{
    public class Article : Content
    {
        //Como estou pedindo no construtor do content um title e uma URL, eu preciso
        // Passar através do construtor o article também os parametros
        public Article (string title, string url)
         :base(title,url)
         {

         }
    }
}