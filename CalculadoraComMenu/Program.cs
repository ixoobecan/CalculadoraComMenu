using System;
using static System.Console;

namespace CalculadoraComMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calc = 0;
            while (calc == 0)
            {
                WriteLine("Digite 0 para utilizar a calculadora e qualquer outra tecla para sair");
                calc = int.Parse(ReadLine());
                if (calc != 0)
                {
                    WriteLine("Saindo");
                    break;
                }
                WriteLine("Insira a opção desejada: ");
                WriteLine("Para soma digite (+) no console");
                WriteLine("Para subtração digite (-) no console");
                WriteLine("Para multiplicação digite (x) no console");
                WriteLine("Para divisão digite (/) no console");

                string opcaoOperation = ReadLine();

                WriteLine("Insira o primeiro valor ");
                float a = float.Parse(ReadLine());
                WriteLine("Insira o segundo valor");
                float b = float.Parse(ReadLine());

                float soma = a + b;
                float subtracao = a - b;
                float multiplicacao = a * b;
                float divisao = a / b;

                if (b == 0 && opcaoOperation == "/")
                {
                    WriteLine("Zero não é um divisor, a operação será reiniciada." + "\n");
                    calc = 1;
                }
                else
                {
                    switch (opcaoOperation)
                    {
                        case "+":
                            WriteLine($"O valor da soma é: {soma}\n");
                            break;
                        case "-":
                            WriteLine($"O valor da subtração é: {subtracao}\n");
                            break;
                        case "x":
                            WriteLine($"O valor da multiplicação é: {multiplicacao}\n");
                            break;
                        case "/":
                            WriteLine($"O valor da divisão é: {divisao}\n");
                            break;
                    }

                }




            }


        }
    }
}