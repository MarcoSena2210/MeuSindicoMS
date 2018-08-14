using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.Arguments.Condominio
{
    public class AdicionarCondominioResponse
    {
        public AdicionarCondominioResponse(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
