using System;
namespace Orientacao.NotificationContext
{
        // Colando a modificador sealed, essa classe não pode ser extendida/ criado variações.      
    public sealed class Notification
    {
        // Criando um construtor caso eu queria passar SEM parametro
        public Notification()
        {

        }
        // Criando um construtor caso eu queria passar COM parametro
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;

        }

        public string Property { get; set; }

        public string Message { get; set; }
    }

}

