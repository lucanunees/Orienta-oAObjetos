using System;
using Orientacao.NotificationContext;

namespace Orientacao.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // Desta forma que cria um novo ID
        }

        public Guid Id { get; set; } // Guid é u global unique identifier (ID)
    }
}