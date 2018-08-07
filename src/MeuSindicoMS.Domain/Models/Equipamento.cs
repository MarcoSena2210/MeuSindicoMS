using MeuSindicoMS.Domain.Core.Models;
using System;

namespace MeuSindicoMS.Domain.Models
{
    public class Equipamento : Entity
    {
        public Guid CondominioId { get; private set; }
        public Guid? EdificioId { get; private set; }
        public string NomeEquipamento { get; private set; }
        public string Descricao { get; private set; }
        public decimal? Valor { get; private set; }
    }
}