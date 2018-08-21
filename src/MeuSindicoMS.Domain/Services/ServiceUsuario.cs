using MeuSindicoMS.Domain.Arguments.Usuario;
using MeuSindicoMS.Domain.Entities;
using MeuSindicoMS.Domain.Entities.Playlist;
using MeuSindicoMS.Domain.Interfaces.Repositories;
using MeuSindicoMS.Domain.Interfaces.Services;
using MeuSindicoMS.Domain.Resources;
using MeuSindicoMS.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace MeuSindicoMS.Domain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        //Dependencias
        private readonly IRepositoryUsuarioPlaylist _repositoryUsuario;

        //Construtor
        public ServiceUsuario(IRepositoryUsuarioPlaylist repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarUsuarioRequest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("AdicionarUsuarioRequest"));
                return null;
            }

            //Cria value objects
            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            Email email = new Email(request.Email);

            //cria entidade
            UsuarioPlaylist usuarioPlaylist = new UsuarioPlaylist(nome, email, request.Senha);

            AddNotifications(usuarioPlaylist);

            if (this.IsInvalid()) return null;

            //Persiste no banco de dados
            _repositoryUsuario.Salvar(usuarioPlaylist);

            return new AdicionarUsuarioResponse(usuarioPlaylist.Id);

        }
        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarUsuarioRequest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("AutenticarUsuarioRequest"));
                return null;
            }

            var email = new Email(request.Email);
            var usuarioPlaylist = new UsuarioPlaylist(email, request.Senha);

            AddNotifications(usuarioPlaylist);

            if (this.IsInvalid()) return null;

            usuarioPlaylist = _repositoryUsuario.Obter(usuarioPlaylist.Email.Endereco, usuarioPlaylist.Senha);

            if (usuarioPlaylist == null)
            {
                AddNotification("Usuario", MSG.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            var response = (AutenticarUsuarioResponse)usuarioPlaylist;

            return response;
        }
    }
}
