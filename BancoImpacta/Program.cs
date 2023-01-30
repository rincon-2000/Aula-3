﻿using System;

namespace BancoImpacta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1001, "Romulo"); //Conta() é um construtor
            c1.Depositar(1000);
            c1.ExibirSaldo();
            c1.Sacar(700);
            c1.ExibirSaldo();

            Conta c2 = new Conta(1002, "Fernando");
            c2.ExibirSaldo();
            c1.Transferir(c2, 200);
            c2.ExibirSaldo();
            c2.Depositar(100);
            c1.ExibirSaldo();
            c1.Transferir(c2, 100);
            c2.ExibirSaldo();
        }
    }
}
