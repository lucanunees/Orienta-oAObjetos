using Orientacao.SharedContext;

namespace Orientacao.SubscriptionContext{

    public class Subscription : Base
    {
        //Inscriçõs realizadas.
        public Plan Plan { get; set; }

        //Aqui define a regra de négocio, se o aluno tem acesso aos cursos ou não.
        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
        
    }
}