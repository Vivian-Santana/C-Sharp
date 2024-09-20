//instanciando uma banda
Banda Skank = new Banda("Skank");

//instanciando album
Album albumSkank = new Album("maquinarama");

Musica musica1 = new Musica(Skank, "Canção noturna");
musica1.Duracao = 3.58; //em minutos
musica1.Disponivel = true;

Musica musica2 = new Musica(Skank, "Três lados")
{
    Duracao = 3.53,     //outra forma de incializar propriedades opcionais no obj.
    Disponivel = true
};

Musica musica3 = new Musica(Skank, "Ali");
musica3.Duracao = 5.6;
musica3.Disponivel = false;

//add musicas ao album
albumSkank.addMusica(musica1);
albumSkank.addMusica(musica2);
albumSkank.addMusica(musica3);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();

albumSkank.ExibirMusicasDoAlbum();

musica1.Genero = new Genero { GeneroMusical = "Rock nacional" }; //composição de classes
Console.WriteLine($"A música {musica1.Titulo} é do gênero {musica1.Genero.GeneroMusical}\n");

Skank.AdicionarAbum(albumSkank);
Skank.ExibirDiscografia();

