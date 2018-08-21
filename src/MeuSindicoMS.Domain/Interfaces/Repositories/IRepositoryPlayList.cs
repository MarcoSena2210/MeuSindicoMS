using MeuSindicoMS.Domain.Entities.Playlist;
using System;
using System.Collections.Generic;

namespace MeuSindicoMS.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayList
    {
        IEnumerable<PlayList> Listar(Guid idUsuario);
        PlayList Obter(Guid idPlayList);
        PlayList Adicionar(PlayList playList);
        void Excluir(PlayList playList);
    }
}
