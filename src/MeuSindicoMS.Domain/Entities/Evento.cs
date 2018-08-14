using MeuSindicoMS.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace MeuSindicoMS.Domain.Entities
{
    public class Evento : Entity
    {
        public Evento(
            string nomeEvento,
            DateTime dataInicio,
            DateTime dataFim,
            bool gratuito,
            decimal valorTotal)
        {
            Id = Guid.NewGuid();
            NomeEvento = nomeEvento;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            ValorTotal = valorTotal;
           
        }

        public string NomeEvento { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal ValorTotal { get; private set; }
        public ICollection<Equipamento> Equipamentos { get; private set; }
        public Organizador Organizador { get; private set; }
    }

    public class Teste
    {
        public Teste()
        {
            var evento = new Evento(
                "Nome do evento",
                DateTime.Now,
                DateTime.Now,
                false,
                1500            
                );
        }

    }
}

