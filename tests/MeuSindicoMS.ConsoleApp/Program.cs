using System;

namespace MeuSindicoMS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var evento = new Evento(
              "Nome do evento",
              DateTime.Now,
              DateTime.Now,
              false,
              1500
              );
            Console.WriteLine(evento.ToString());
            Console.readKey();
        }
    }
}
