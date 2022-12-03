using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            if(res==5){
                System.Environment.Exit(0);
            }else{
                MathOperation(res);
            }
        }

        static void MathOperation(short chose)
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            switch (chose)
            {
                case 1:
                    Soma(v1, v2);
                    break;

                case 2:
                    Subtracao(v1, v2);
                    break;

                case 3:
                    Divisao(v1, v2);
                    break;

                case 4:
                    Multiplicacao(v1, v2);
                    break;

                default:
                    Menu();
                    break;
            }

            Console.ReadKey();
            Menu();
        }

        static float Soma(float v1, float v2)
        {

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            return resultado;
        }

        static float Subtracao(float v1, float v2)
        {
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtracao é: {resultado}");
            return resultado;
        }

        static float Divisao(float v1, float v2)
        {
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da Divisão é: {resultado}");
            return resultado;
        }

        static float Multiplicacao(float v1, float v2)
        {
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");
            return resultado;
        }
    }
}
