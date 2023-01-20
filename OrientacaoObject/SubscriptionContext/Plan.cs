using Orientacao.SharedContext;

namespace Orientacao.SubscriptionContext{

    public class Plan : Base
    {
        //Planos ofertados.
        public string Title { get; set; }
        public decimal Price { get; set; }

    }
}