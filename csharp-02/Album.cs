class Album{
    
    private List<Musica> musicas = new List<Musica>();
    public string nome { get; set; }
    public int duracaoTotal { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Listas de músicas do Album {nome}: \n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.nome}");
        }
    }

}