using Orientacao.SharedContext;

namespace Orientacao.SubscriptionContext
{
    public class User : Base
    {
        // Login dos usuarios.
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
}