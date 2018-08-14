using MeuSindicoMS.Domain.Arguments.Usuario;
using MeuSindicoMS.Domain.Interfaces.Services.Base;

namespace MeuSindicoMS.Domain.Interfaces.Services
{
    public interface IServiceUsuario : IServiceBase
    {
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
    }
}
