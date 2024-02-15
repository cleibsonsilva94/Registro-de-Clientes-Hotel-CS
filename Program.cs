using System;

namespace RegistrodeClientesHotelCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro de clientes do Hotel Cs");
            Console.WriteLine("Seja muito bem vindo! Escolha uma das opções abaixo digitando o número dela:");
            Console.WriteLine("1. Registrar novo cliente");
            Console.WriteLine("2. Remover cliente");
            Console.WriteLine("3. Pesquisar Cliente");
            int Opção = int.Parse(Console.ReadLine());

            if (Opção == 1)
            {
                Console.WriteLine("Nome do cliente:");
                string nameCliente = Console.ReadLine();
                Console.WriteLine("Idade:");
                int Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número de dias que ficará no hotel:");
                int dias = int.Parse(Console.ReadLine());
                Console.WriteLine("Quarto que o cliente ficará:");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine($"Cliente, {nameCliente}, registrado com sucesso! \nEle tem {Idade} anos e vai ficar {dias} dias no hotel.\nEle ficará no quarto {quarto}");
            }
        }
    }
}
