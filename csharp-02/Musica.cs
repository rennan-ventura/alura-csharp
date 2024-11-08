using System.Diagnostics;

class Musica{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void exibirFichaTecnica(){
        Console.WriteLine($"Banda: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if(disponivel){
            Console.WriteLine($"A banda {nome} está disponivel");
        } else {
            Console.WriteLine("Necessário a assinatura do Plano plus");
        }
        
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
    }


}






/*
Musica musica1 = new Musica();
musica1.nome = "Roxanne";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true;
*/
