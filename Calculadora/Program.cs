using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado, botao;

            do
            {
                Console.WriteLine("Escolha um número ");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a operação:\n(1-Adição 2-Subtração 3-Divisão 4-Multiplicação)");

                string operacao = Console.ReadLine();

                Console.WriteLine("Escolha o segundo número ");

                n2 = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case "1":

                        resultado = Somar(n1, n2);
                        Console.WriteLine("O resultado da operação é " + resultado);
                        break;
                    case "2":

                        resultado = Subtrair(n1, n2);
                        Console.WriteLine("O resultado da operação é " + resultado);
                        break;
                    case "3":
                        try
                        {
                            resultado = Dividir(n1, n2);
                            Console.WriteLine("O resultado da operação é " + resultado);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"ERRO: {e}");
                        }
                        break;
                    case "4":

                        resultado = Multiplicar(n1, n2);
                        Console.WriteLine("O resultado da operação é " + resultado);
                        break;
                    default:
                        Console.WriteLine("Operação invalida ");
                        break;
                }

                Console.WriteLine("O que deseja agora? 1-Continuar 0-Sair");
                botao = Convert.ToInt32(Console.ReadLine());

            } while (botao != 0);
        }

        static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        static int Dividir(int n1, int n2)
        {
            if (SeZero(n2)) throw new Exception("Divisor não pode ser 0 !");
            return n1 / n2;
            bool SeZero(int n2)
            {
                if (n2 == 0) return true;
                return false;
            }
        }
    }
}
