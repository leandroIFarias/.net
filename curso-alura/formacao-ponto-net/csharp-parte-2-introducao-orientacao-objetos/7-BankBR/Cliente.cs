﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _7_BankBR
{
    class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
