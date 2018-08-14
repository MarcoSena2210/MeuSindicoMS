using MeuSindicoMS.Domain.Arguments.Condominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.Interfaces.Services
{
    public interface IServiceCondominio
    {
        AdicionarCondominioResponse AdicionarCondominio(AdicionarCondominioRequest request);
    }
}
