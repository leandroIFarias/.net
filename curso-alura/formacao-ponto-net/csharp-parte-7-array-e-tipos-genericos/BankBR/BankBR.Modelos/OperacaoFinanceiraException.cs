﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankBR.Modelos
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string mensagem)
            : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }
}
