using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Conta
    {

        private string _cliente;
        private double _saldo;
        private double _taxa = 10;


        //Propriedade

        public string Cliente
        {

            get { return _cliente; }
            set
            {
                if (value != "Henrique" && value != "Alves")
                {
                    _cliente = "Visitante";
                    Saldo = 0;
                }
                else
                {
                    _cliente = value;
                    Saldo = 100;
                }
            }

        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            private set
            {
                _saldo = value;
            }
        }




        public void Saca(double valor)
        {
            valor += _taxa;
            _saldo -= valor;
        }


        public void Depositar(double valor)
        {
            _saldo += valor;
        }

    }
}
