using BankBR.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBR
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
