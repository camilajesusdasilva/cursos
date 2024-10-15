using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1_COTI.Entities
{
    public class Cliente
    {
        public Guid IdCliente { get; set; } //global unique identifier, gera id único para que não haja probabilidade de gerar id igual
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
