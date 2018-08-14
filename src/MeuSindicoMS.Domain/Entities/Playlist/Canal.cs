using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using MeuSindicoMS.Domain.Entities.Base;
using MeuSindicoMS.Domain.Resources;

namespace MeuSindicoMS.Domain.Entities
{
    public class Canal : EntityBase
    {
        protected Canal()
        {

        }
        public Canal(string nome, string urlLogo, Usuario usuario)
        {
            Nome = nome;
            UrlLogo = urlLogo;
            Usuario = usuario;

            //new AddNotifications<Canal>(this)
            //    .IfNullOrInvalidLength(x => x.Nome, 2, 50, MSG.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("2", "50"))
            //    .IfNullOrInvalidLength(x => x.UrlLogo, 4, 200, MSG.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("4", "200"));

            new AddNotifications<Canal>(this).IfNullOrInvalidLength(x => x.Nome, 2, 50)
                                              .IfNullOrInvalidLength(x => x.UrlLogo, 4, 200);
            AddNotifications(usuario);
        }

        public string Nome { get; private set; }
        public string UrlLogo { get; private set; }
        public Usuario Usuario { get; private set; }

    }
}
