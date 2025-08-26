using System;
using Petshop;

    class program
{

    static Animal[] animais = new Animal[10];

    static void (string[] args)
    {
        int opcao = 0;
        do
        {
            Console.WriteLine("1 - Cadastrar cachorro");
            Console.WriteLine("2 - Cadastrar gato");
            Console.WriteLine("3 - Listar animais");
            Console.WriteLine("4 - Atender animal");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    CadastrarCachorro();
                    break;
                case 2:
                    CadastrarGato();
                    break;
                case 3:
                    ListarAnimais();
                    break;
                case 4:
                    AtenderAnimal();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 5) ;
    }
}