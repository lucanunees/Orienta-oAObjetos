namespace Orientacao.ContentContext
{
    /* Como é uma classe abastrata ou seja é um conteudo.. 
       Deixando abstrata ela não pode ser instanciada, inicializada. 
   */
    public abstract class Content

    {
        public Content()
        {
            Id = Guid.NewGuid(); // Desta forma que cria um novo ID
        }
        public Guid Id { get; set; } // Guid é u global unique identifier (ID)
        public string Title { get; set; }
        public string Url { get; set; }
    }
}