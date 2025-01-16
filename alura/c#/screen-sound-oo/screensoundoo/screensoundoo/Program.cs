Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(queen, "Love Of My Life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};


albumDoQueen.AdcionarMusica(musica1);
albumDoQueen.AdcionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaMusica();
musica2.ExibirFichaMusica();
albumDoQueen.ExibirMusicasAlbum();
queen.ExibirDiscografia();