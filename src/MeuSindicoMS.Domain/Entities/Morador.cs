using MeuSindicoMS.Domain.Core.Models;
using System;

namespace MeuSindicoMS.Domain.Entities
{
    public class Morador :Entity
    {
         public Guid ImovelId { get; private set; }
         public Guid PessoaFisicaId { get; private set; }
        
    }
}