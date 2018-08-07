using MeuSindico.Domain.ValueObjects;
using MeuSindicoMS.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.Models
{
    public class Edificio :Entity
    {
        public Edificio(
            string nome, 
            Endereco endereco,
            ICollection<Imovel> 
            imoveis, Condominio condominioId, Condominio condominio)
        {
            Nome = nome;
            Endereco = endereco;
            Imoveis = imoveis;
            CondominioId = condominioId;
            Condominio = condominio;
        }

        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public ICollection<Imovel> Imoveis { get; private set; }
        public Condominio CondominioId { get; private set; }
        public virtual Condominio Condominio { get; private set; }
    }
}
