
namespace Orientacao.NotificationContext
{
    //Como não precisa ser instanciada essa classe, colocamos o modificador abstract
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);

        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

         //Como essa propriedade só vai ter um get, podemos utilizar a forma expression body.
         // Se tiver alguma notificação/Erro, ele estar invalido.
        public bool IsInvalid => Notifications.Any();
    }


}