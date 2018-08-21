using System;
using MeuSindicoMS.Domain.Entities;
using MeuSindicoMS.Domain.Entities.Playlist;

namespace MeuSindicoMS.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuarioPlaylist
    {
        UsuarioPlaylist Obter(Guid id);
        UsuarioPlaylist Obter(string email, string senha);
        void Salvar(UsuarioPlaylist usuarioPlaylist);
        bool Existe(string email);
    }
}
