using MeuSindicoMS.Domain.Core.Models;

namespace MeuSindicoMS.Domain.Entities.Playlist
{
    public class Favorito : Entity
    {
        protected Favorito()
        {

        }
        public Video Video { get; private set; }

        public UsuarioPlaylist UsuarioPlaylist { get; private set; }
    }
}
