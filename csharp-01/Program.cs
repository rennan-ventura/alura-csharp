// See https://aka.ms/new-console-template for more information
string boasVindas = "Seja bem vindo ao Screen Sound";

Console.WriteLine(boasVindas);

Console.WriteLine("Digite sua média");

String linha = Console.ReadLine();

int notaMedia = int.Parse(linha);

if(notaMedia <= 5){
    Console.WriteLine("Você foi reprovado!!!");
} else{
    Console.WriteLine("Você foi aprovado!!!");
}

