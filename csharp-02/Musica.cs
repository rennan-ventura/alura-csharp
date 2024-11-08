using System.Diagnostics;

class Musica{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel  { get; set; }
    public string DescricaoResumida 
    {
         get{
            return $"A musica {Nome} pertence a banda {Artista}";
         }
    }



    public void ExibirFichaTecnica(){
        Console.WriteLine($"Banda: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel){
            Console.WriteLine($"A banda {Nome} está disponivel");
        } else {
            Console.WriteLine("Necessário a assinatura do Plano plus");
        }
        
    }


    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }


}






/*
Musica musica1 = new Musica();
musica1.nome = "Roxanne";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true;
*/
