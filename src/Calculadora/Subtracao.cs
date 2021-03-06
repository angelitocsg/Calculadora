using System;

namespace Calculadora
{
    public class Subtracao : IOperacao
    {
        private double _primeiroValor;
        private double _segundoValor;

        public Subtracao(double primeiroValor, double segundoValor)
        {
            _primeiroValor = primeiroValor;
            _segundoValor = segundoValor;
        }

        public double Resultado()
        {
            return _primeiroValor - _segundoValor;
        }
    }
}
