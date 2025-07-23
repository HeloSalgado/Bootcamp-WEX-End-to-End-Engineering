using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Classe que representa uma calculadora com operações matemáticas básicas.
    /// </summary>
    public class Calculadora
    {
        /// <summary>
        /// Método que realiza a soma de dois números.
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        /// <summary>
        /// Método que realiza a subtração de dois números.
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Sutrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        /// <summary>
        /// Método que realiza a multiplicação de dois números.
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        /// <summary>
        /// Método que realiza a divisão de dois números.
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        /// <summary>
        /// Método que calcula a potência de um número.
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        /// <summary>
        /// Método que calcula o seno de um ângulo em graus.
        /// </summary>
        /// <param name="angulo">Valor do ângulo</param>
        public void Seno(double angulo)
        {
            double radiano = Math.PI / 180 * angulo;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        /// <summary>
        /// Método que calcula o cosseno de um ângulo em graus.
        /// </summary>
        /// <param name="angulo">Valor do ângulo</param>
        public void Coseno(double angulo)
        {
            double radiano = Math.PI / 180 * angulo;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }

        /// <summary>
        /// Método que calcula a tangente de um ângulo em graus.
        /// </summary>
        /// <param name="angulo">Valor do ângulo</param>
        public void Tangente(double angulo)
        {
            double radiano = Math.PI / 180 * angulo;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(tangente, 4)}");
        }

        /// <summary>
        /// Método que calcula a raiz quadrada de um número.
        /// </summary>
        /// <param name="x">O número para calcular a raiz quadrada</param>
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}