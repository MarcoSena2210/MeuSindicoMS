using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using MeuSindico.Domain.Resources;

namespace MeuSindico.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        protected Nome()
        {

        }
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 1, 25, MSG.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Primeiro nome", 1, 25))
                .IfNullOrInvalidLength(x => x.UltimoNome, 1, 50, MSG.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Último nome", 1, 50));
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        /*
        public bool Valido(Nome nome)
        {
            if (nome.PrimeiroNome.Length < 3 || nome.PrimeiroNome.Length > 50)
            {
                return false; 
            }
            if (nome.PrimeiroNome.Length < 3 || nome.PrimeiroNome.Length > 50)
            {
                return false;
            }
            return true;  

        }
          */  

    }
}
