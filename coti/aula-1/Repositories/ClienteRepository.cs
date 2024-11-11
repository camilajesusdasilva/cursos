using Aula_1_COTI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1_COTI.Repositories
{
    public class ClienteRepository
    {
        public void ExportarDados(Cliente cliente)
        {
            var streamWriter = new StreamWriter("c:\\temp\\clientes.txt");

            streamWriter.WriteLine("ID DO CLIENTE.......: " + cliente.IdCliente);
            streamWriter.WriteLine("NOME.......: " + cliente.Nome);
            streamWriter.WriteLine("EMAIL.......: " + cliente.Email);
            streamWriter.WriteLine("TELEFONE.......: " + cliente.Telefone);
            streamWriter.WriteLine("---");

            streamWriter.Flush(); //salvar
            streamWriter.Close(); //fechar
        }
    }
}
