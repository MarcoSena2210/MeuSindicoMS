using prmToolkit.NotificationPattern;
using System;

namespace MeuSindicoMS.Domain.Core.Models
{
    /* Esta classe nunca poderá ser instanciada,apenas herdade */
    public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            InclusaoRegistro = DateTime.Now;
            
        }
       

        /* protected porque apenas a classe que Herda de Entity 
         * pode alterá-la  */
        public Guid Id { get; protected set; }
        public DateTime InclusaoRegistro { get; private set; }

        //public abstract bool EhValido();
        //public ValidationResult ValidationResult { get; protected set; }


        /* Como compara uma entidade com outra, se estamos falando da mesma entidade
         * para isso iremos fazer um reescrita do metodo equals.dessa forma conseguimos comprarar
         * duas instancias 
         * 
         */
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;
            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(this, compareTo)) return false;
            return Id.Equals(compareTo.Id);
        }

        /* Medias string  para garantir que o has cod é unico*/
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907 ) + Id.GetHashCode();
        }

        /*Compara se as duas comparaveis com null*/
        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        /* vai facilitar para saber qual onome  + o  id da entidade  */
        public override string ToString()
        {
            return GetType().Name + "[Id = " +Id + "]";
        }



    }
}
