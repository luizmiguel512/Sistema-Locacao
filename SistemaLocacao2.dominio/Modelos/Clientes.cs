    using System;
using System.Collections.Generic;

using System.Text;

namespace SistemaLocacao2.dominio.Modelos
{
    public class Cliente
    {
        public string Nome{ get; private set; }
        public string Cpf { get; private   set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Cnh { get; private set; }
        public DateTime DataNascm { get; private set; }

        public Cliente(string nome, string cpf, string telefone, string email, string cnh, DateTime dataNascm)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Cnh = cnh;
            DataNascm = dataNascm;






        }
    }
}

  

    


    
