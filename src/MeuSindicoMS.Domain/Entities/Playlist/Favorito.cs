using MeuSindicoMS.Domain.Entities.Base;

namespace MeuSindicoMS.Domain.Entities
{
    public class Favorito : EntityBase
    {
        protected Favorito()
        {

        }
        public Video Video { get; set; }

        public Usuario Usuario { get; set; }
    }
}
