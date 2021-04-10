﻿using BankBR.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBR.Modelos
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
