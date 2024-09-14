// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Console.WriteLine(mensagemDeBoasVindas);

Console.WriteLine("Digite uma nota");
String? linha = Console.ReadLine();
int notaMedia = int.Parse(linha);

if (notaMedia <= 5){
    Console.WriteLine("Nota insuficiente!");
} else {
    Console.WriteLine("Você passou!!!");
}   
