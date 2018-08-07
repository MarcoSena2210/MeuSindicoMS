using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using MeuSindico.Domain.Resources;

namespace MeuSindico.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        protected Email()
        {

        }
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this) //Adciona as notificações desse objeto (email) 
                .IfNotEmail(x => x.Endereco, MSG.X0_INVALIDO.ToFormat("E-mail"));
        }

        public string Endereco { get; private set; }
    }
}
