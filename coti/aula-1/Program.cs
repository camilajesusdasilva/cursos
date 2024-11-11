using Aula_1_COTI.Entities;
using System;

namespace Aula_1_COTI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cliente = new Cliente();

            cliente.IdCliente = Guid.NewGuid();

            Console.Write("Informe o nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Informe o email do cliente: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Informe o telefone do cliente: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine("\nDados do Cliente:\n");
            Console.WriteLine("\tID...:" + cliente.IdCliente);
            Console.WriteLine("\tNOME...:" + cliente.Nome);
            Console.WriteLine("\tEMAIL..: " + cliente.Email);
            Console.WriteLine("\tTELEFONE...: " + cliente.Telefone);

            Console.ReadKey();
        }
    }
}
