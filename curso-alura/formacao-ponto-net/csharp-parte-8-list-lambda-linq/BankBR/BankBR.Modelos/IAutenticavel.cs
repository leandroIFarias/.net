using System;
using System.Collections.Generic;
using System.Text;

namespace BankBR.Modelos
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
