using BankBR.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBR.Modelos
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
