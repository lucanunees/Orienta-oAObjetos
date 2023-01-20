using Orientacao.NotificationContext;
using Orientacao.SharedContext;

namespace Orientacao.SubscriptionContext{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }


        //Informações básicas do Aluno.
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Planos que o aluno tem.
        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        //Método para criar um subscription
        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já tem uma assinatura ativa."));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}