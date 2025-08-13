﻿namespace CalculadoraApp
{
    public class Calculadora
    {
        public int Somar(int a, int b) => a + b;

        public int Subtrair(int a, int b) => a - b;

        public int Multiplicar(int a, int b) => a * b;

        public double Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return (double)a / b;
        }
    }
}
