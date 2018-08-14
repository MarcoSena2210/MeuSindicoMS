using prmToolkit.NotificationPattern;
using MeuSindicoMS.Domain.Entities.Base;
using MeuSindicoMS.Domain.Enums;

namespace MeuSindicoMS.Domain.Entities
{
    public class PlayList : EntityBase
    {
        protected PlayList()
        {

        }
        public PlayList(string nome, Usuario usuario)
        {
            Nome = nome;
            Usuario = usuario;

            new AddNotifications<PlayList>(this).IfNullOrInvalidLength(x => x.Nome, 2, 100);

            AddNotifications(usuario);
        }

        public string  Nome { get; private set; }
        public Usuario Usuario { get; private set; }
        public EnumStatus Status { get; private set; }
    }
}
