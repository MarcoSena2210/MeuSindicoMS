using MeuSindicoMS.Domain.Core.Models;
using MeuSindicoMS.Domain.Extensions;
using MeuSindicoMS.Domain.ValueObjects;
using prmToolkit.NotificationPattern;

namespace MeuSindicoMS.Domain.Entities.Playlist
{
    public class UsuarioPlaylist : Entity
    {
        protected UsuarioPlaylist()
        {

        }
        public UsuarioPlaylist(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            //Criptografo a senha
            Senha = Senha.ConvertToMD5();

            AddNotifications(Email);
        }

       

        public UsuarioPlaylist(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

            new AddNotifications<UsuarioPlaylist>(this).IfNullOrInvalidLength(x => x.Senha, 3, 32);

            //Criptografo a senha
            Senha = Senha.ConvertToMD5();

            AddNotifications(nome, email);
        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
    }
}
