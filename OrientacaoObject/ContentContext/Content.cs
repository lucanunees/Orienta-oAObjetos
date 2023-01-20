namespace Orientacao.ContentContext
{
    /* Como é uma classe abastrata ou seja é um conteudo.. 
       Deixando abstrata ela não pode ser instanciada, inicializada. 
   */
    public abstract class Content : Base

    {
        public Content(string title, string url)
        {           
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }
    }
}