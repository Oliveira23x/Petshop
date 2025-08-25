using System;
using Petshop;

class Program

{

    // Declaramos um array estático de Animal inicialmente vazio (0 elementos).

    static Animal[] animais = new Animal[0]; // Começa sem nenhum animal cadastrado.

    //ponto de entrada do programa.

    static void Main(string[] args)

    {

        int opcao; // Variável que armazena a escolha do menu.

        // Estrutura de repetição para manter o menu rodando até o usuário escolher sair.

        do

        {

            Console.WriteLine("\nMenu:");

            Console.WriteLine("1 - Cadastrar Animal");

            Console.WriteLine("2 - Listar Animais");

            Console.WriteLine("3 - Atender Animal");

            Console.WriteLine("4 - Sair");



            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine()); // Converte a entrada para inteiro.



            if (opcao == 1)

            {

                CadastrarAnimal();

            }

            else if (opcao == 2)

            {

                ListarAnimais();

            }

        } while (opcao != 3);

    }



    // Método para cadastrar um novo animal.

    static void CadastrarAnimal()

    {

        Console.Write("\nDigite o nome do animal: ");

        string nome = Console.ReadLine();



        Console.Write("Digite a idade do animal: ");

        int idade = int.Parse(Console.ReadLine()); // Lê e converte para inteiro.

        // Cria um novo objeto Animal com as informações fornecidas.

        Animal novoAnimal = new Gato(nome, idade); // Aqui estamos criando um Gato, mas poderia ser outro tipo de Animal.

        // Cria um novo array com uma posição a mais que o atual.

        Animal[] novoArray = new Animal[animais.Length + 1];

        // Copia os elementos do array antigo para o novo.

        for (int i = 0; i < animais.Length; i++)

        {

            novoArray[i] = animais[i];

        }

        // Adiciona o novo animal na última posição do novo array.

        novoArray[novoArray.Length - 1] = novoAnimal;

        // Substitui o array antigo pelo novo (agora com o animal adicionado).

        animais = novoArray;



        Console.WriteLine("\n✅ Animal cadastrado com sucesso!");

    }



    static void ListarAnimais()

    {

        Console.WriteLine("\nLista de Animais:");

        // Se não houver nenhum animal no array, informa e retorna.

        if (animais.Length == 0)

        {

            Console.WriteLine("Nenhum animal cadastrado.");

            return;

        }

        // Percorre o array de animais e exibe nome e idade de cada um.

        for (int i = 0; i < animais.Length; i++)

        {

            Console.WriteLine($"Nome: {animais[i].nome}, Idade: {animais[i].novaIdade}");

        }
        static void Atender()
        {
            Console.Write("\nDigite o nome do animal a ser atendido: ");
            string nome = Console.ReadLine();
            // Procura o animal pelo nome no array.
            Animal animalParaAtender = null;
            for (int i = 0; i < animais.Length; i++)
            {
                if (animais[i].nome == nome)
                {
                    animalParaAtender = animais[i];
                    break;
                }
            }
            // Se o animal for encontrado, chama o método Atender.
            if (animais != null)
            {
                animalParaAtender.Atender();
            }
            else
            {
                Console.WriteLine("Animal não encontrado.");
            }
        }
    }

}

