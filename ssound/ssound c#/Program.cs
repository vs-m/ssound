﻿string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string>{ "Drain Gang", "Black Country, New Road", "Korn"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("black midi", new List<int>{10, 10, 8});
bandasRegistradas.Add("Nação Zumbi", new List<int>());

void ExibirLogo() {
Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
Console.WriteLine(mensagemDeBoasVindas);
}



void ExibirOpcoesMenu() 
{
ExibirLogo();
Console.WriteLine("\nDigite 1 para registrar uma banda");
Console.WriteLine("Digite 2 para listar todas as bandas");
Console.WriteLine("Digite 3 para avaliar uma banda");
Console.WriteLine("Digite 4 para exibir a média da banda");
Console.WriteLine("Digite -1 para sair");

Console.Write("\nDigite a sua opção: ");
string opcaoEscolhida = Console.ReadLine()!;
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
switch (opcaoEscolhidaNumerica) {
    case 1: RegistrarBanda();
        break;
    case 2: MostrarBandasRegistradas();
        break;
    case 3: AvaliarUmaBanda();
        break;
    case 4: ExibirMedia();
        break;
    case -1: Console.WriteLine("Até mais! :))))");
        break;
    default: Console.WriteLine("Opção Inválida");
        break;
}

void RegistrarBanda() 
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"{nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();

}
}

void MostrarBandasRegistradas()
{
Console.Clear();
ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
foreach (string bandas in bandasRegistradas.Keys) 
{
    Console.WriteLine($"Banda: {bandas}");
}
Console.WriteLine("\nPressione qualquer tecla para sair");
Console.ReadKey();
Console.Clear();
ExibirOpcoesMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota a banda {nomeDaBanda} merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\n a nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibr média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    } else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite ma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
} 


ExibirOpcoesMenu();
Console.Clear();