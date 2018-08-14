using FluentValidator;
using MeuSindicoMS.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace MeuSindicoMS.Domain.ValueObjects
{
    public class Email : prmToolkit.NotificationPattern.Notifiable
    {
        protected Email()
        {

        }
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this)
                .IfNotEmail(x => x.Endereco, MSG.X0_INVALIDO.ToFormat("E-mail"));
        }

        public string Endereco { get; private set; }
    }
}
