using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    public class Conta
    {


        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }

        public double Saldo { get; private set; }





        public Conta(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;

        }

        public Conta(int numeroDaConta, string titular, double saldo) : this(numeroDaConta, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }


        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

