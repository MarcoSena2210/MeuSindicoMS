using System;
using System.Collections.Generic;
using MeuSindicoMS.Domain.Entities;
using MeuSindicoMS.Domain.Entities.Playlist;

namespace MeuSindicoMS.Domain.Interfaces.Repositories
{
    public interface IRepositoryCanal
    {
        IEnumerable<Canal> Listar(Guid idUsuario);
        Canal Obter(Guid idCanal);
        Canal Adicionar(Canal canal);
        void Excluir(Canal canal);
    }
}
