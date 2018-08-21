using MeuSindicoMS.Domain.Core.Models;
using MeuSindicoMS.Domain.Enums;
using prmToolkit.NotificationPattern;

namespace MeuSindicoMS.Domain.Entities.Playlist
{
    public class PlayList : Entity
    {
        protected PlayList() {   }
     
        public PlayList(string nome, UsuarioPlaylist usuarioPlaylist, EnumStatus status)
        {
            Nome = nome;
            UsuarioPlaylist = usuarioPlaylist;
            Status = status;

            new AddNotifications<PlayList>(this).IfNullOrInvalidLength(x => x.Nome, 2, 100);

            AddNotifications(usuarioPlaylist);
        }

        public string  Nome { get; private set; }
        public UsuarioPlaylist UsuarioPlaylist { get; private set; }
        public EnumStatus Status { get; private set; }
    }
}
