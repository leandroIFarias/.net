﻿using System;

namespace _1_BankBR
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
