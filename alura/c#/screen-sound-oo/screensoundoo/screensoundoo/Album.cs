class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdcionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    
    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Músicas: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir o álbum você precisa de {DuracaoTotal}");
    }
}