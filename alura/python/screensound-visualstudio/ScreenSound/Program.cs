string mensagemBemVindo = "Bem vindo(a) ao Screen Sound";
List<string> bandasEmLista = new List<string> { "U2", "The Beatles", "Imagine Dragons" };
void BemVindo()
{
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
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1:
            Registrodebanda();
            break;
        case 2:
            ListagemDeBanda();
            break;
        case 3:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 4:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 5:
            Console.WriteLine("Foi bom te ver por aqui!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void Registrodebanda()
{
    Console.Clear();
    BemVindo();
    layout("Registro de bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasEmLista.Add(nomeBanda);
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
    layout("Essas são as bandas registradas em nossa aplicação: \n");
    foreach (string banda in bandasEmLista)
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

void layout(string titulo)
{
    int quantidadeLetras = titulo.Lenght;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
}
