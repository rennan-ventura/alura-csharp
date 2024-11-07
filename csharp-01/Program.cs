// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};  
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>{10, 6, 8});

void ExibirLogo()
{
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

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ExibindoListaDeBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibeMediaBanda();
            break;
        case -1: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda(){
    Console.Clear();
    ExibeTitulo("Registrando bandas");
    Console.Write("Digite a banda que deseja inserir: ");
    string nomeDaBanda = Console.ReadLine()!;    
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nA Banda {nomeDaBanda} foi incluida com sucesso!!!");
    Console.ResetColor();
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibindoListaDeBandas(){
    Console.Clear();
    ExibeTitulo("Exibindo a lista de bandas");
   foreach (string banda in bandasRegistradas.Keys){
    Console.WriteLine($"Banda: {banda}");
   }
   MensagemDeVolta();
}

void ExibeTitulo(string titulo) {
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda(){
    Console.Clear();
    ExibeTitulo("Avaliação de bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();
    if(bandasRegistradas.ContainsKey(nomeDaBanda)){
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso!!!");
        Console.ResetColor();
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else{
        MesagemErroCadastro(nomeDaBanda);
        MensagemDeVolta();
    }
}

void ExibeMediaBanda(){
    Console.Clear();
    ExibeTitulo("Exibindo a média das bandas");
   foreach (string banda in bandasRegistradas.Keys){
    Console.WriteLine($"Banda: {banda}");
   }
   Console.Write("\nDigite a banda que deseja consultar a média: ");
   string nomeDaBanda = Console.ReadLine();
    if(bandasRegistradas.ContainsKey(nomeDaBanda)){
        
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é: {notasDaBanda.Average()}");
        MensagemDeVolta();
    } else{
        MesagemErroCadastro(nomeDaBanda);
        MensagemDeVolta();
    }
}

void MensagemDeVolta(){
    Console.WriteLine("\nDigite um tecla qualquer para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void MesagemErroCadastro(string nomeDaBanda){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"A banda {nomeDaBanda} não está cadastrada!!!");
    Console.ResetColor();
}

ExibirOpcoesDoMenu();
