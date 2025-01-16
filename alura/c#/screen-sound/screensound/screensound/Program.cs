using System.ComponentModel;
using System.Runtime.CompilerServices;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> bandasEmLista = new List<string> { "U2", "The Beatles", "Imagine Dragons" };
Dictionary <string, List<int>> bandasRegistradas = new Dictionary <string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 5});
bandasRegistradas.Add("Metallica", new List<int> ());

void BemVindo()
{
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
}

void OpcoesMenu()
{
    BemVindo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int escolhaNumerica = int.Parse(opcaoEscolhida);

    switch (escolhaNumerica)
    {
        case 1:
            Registrodebanda();
            break;
        case 2:
            ListagemDeBanda();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case 5:
            Console.WriteLine("Foi bom te ver por aqui!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void TituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void Registrodebanda()
{
    Console.Clear();
    BemVindo();
    TituloOpcao("Registro de bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Thread.Sleep(3000);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesMenu();
}

void ListagemDeBanda()
{
    Console.Clear();
    BemVindo();
    TituloOpcao("Essas são as bandas registradas em nossa aplicação: \n");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda:{banda}");
    }
    Thread.Sleep(3000);
    Console.WriteLine("\nDigite enter para voltar ao menu");
    Thread.Sleep(2000);
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    BemVindo();
    TituloOpcao("Avaliação das Bandas: \n");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual nota você deseja dar a {nomeDaBanda}? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        OpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada\n");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();
}

void MediaBanda()
{
    Console.Clear();
    BemVindo();
    TituloOpcao("Média das bandas");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) 
    {
        List<int> nota = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {nota.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();
    } else
    {
        Console.WriteLine("A banda não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();
    }
}

OpcoesMenu();