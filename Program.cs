using System.Reflection;

Dictionary<string, List<int>> artistasRegistrados = new Dictionary<string, List<int>>();
artistasRegistrados.Add("Chrono", new List<int> {10, 10, 10});
artistasRegistrados.Add("7Minutoz", new List<int> {10, 9, 10});
artistasRegistrados.Add("MHRAP", new List<int> {8, 7, 6});

void ExibeMensagem()
{
Console.WriteLine(@"

███╗░░░███╗███████╗██╗░░░██╗░██████╗  ░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░░██████╗
████╗░████║██╔════╝██║░░░██║██╔════╝  ██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗██╔════╝
██╔████╔██║█████╗░░██║░░░██║╚█████╗░  ███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║╚█████╗░
██║╚██╔╝██║██╔══╝░░██║░░░██║░╚═══██╗  ██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║░╚═══██╗
██║░╚═╝░██║███████╗╚██████╔╝██████╔╝  ██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║██████╔╝
╚═╝░░░░░╚═╝╚══════╝░╚═════╝░╚═════╝░  ╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░

");    
}

void ExibeMenu()
{
    //imprime a mensagem em texto
    ExibeMensagem();
    Console.WriteLine("Digite 1 para registrar um novo artista");
    Console.WriteLine("Digite 2 para mostrar os artistas registrados");
    Console.WriteLine("Digite 3 para avaliar um artista");
    Console.WriteLine("Digite 4 para exibir a média de um artista");
    Console.WriteLine("Digite 0 para sair");

    Console.WriteLine("Digite sua opção...");
    //lê oq a pessoa digitou
    //a exclamação no final armazena a variável
    string opcaoEscolhida = Console.ReadLine();
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoNumerica)
    {
        case 1: RegistrarArtista();
            break;
        case 2: MostraArtistas();
            break;
        case 3: AvaliaArtistas();
            break;
        case 4: MostraMedia();
            break;
        case 0: Console.WriteLine("Até mais!");
            break;
            default: 
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void ExibirTitulo(string titulo)
{
    int qntLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void RegistrarArtista()
{
    Console.Clear();
    ExibirTitulo("Registro de artistas");
    Console.Write("Digite o nome do artista que deseja registrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    artistasRegistrados.Add(nomeDoArtista, new List<int>());
    Console.WriteLine($"O artista {nomeDoArtista} foi adicionado com sucesso");
    Thread.Sleep(4000);
    Console.Clear();
    ExibeMenu();
}

void MostraArtistas()
{
    Console.Clear();
    ExibirTitulo("Artistas registrados");
    foreach(string artista in artistasRegistrados.Keys)
    {
        Console.WriteLine($"Artista: {artista}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibeMenu();
}

void AvaliaArtistas()
{
    Console.Clear();
    ExibirTitulo("Avaliando artistas");
    Console.WriteLine("Digite o artista que você deseja avaliar: ");
    string nomeArtista = Console.ReadLine()!;
    
    if(artistasRegistrados.ContainsKey(nomeArtista))
    {
        Console.Write($"Qual nota o artista {nomeArtista} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        artistasRegistrados[nomeArtista].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o artista {nomeArtista}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibeMenu();
    } else
    {
        Console.WriteLine($"O artista {nomeArtista} não foi encontrado!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
        ExibeMenu();
    }

    ExibeMenu();
}

void MostraMedia()
{
   Console.Clear();
   ExibirTitulo("Exibindo média de avaliações");
   Console.Write("Informe o artista que você deseja ver a média de avaliações: ");
   string nomeArtista = Console.ReadLine()!;

   if(artistasRegistrados.ContainsKey (nomeArtista))
    {
        List<int> notasArtista = artistasRegistrados[nomeArtista];
        Console.WriteLine($"A média do artista {nomeArtista} é {notasArtista.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
        ExibeMenu();
    } else
    {
        Console.WriteLine($"O artista {nomeArtista} não foi encontrado!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
        ExibeMenu();
    }
   ExibeMenu();
}

ExibeMenu();