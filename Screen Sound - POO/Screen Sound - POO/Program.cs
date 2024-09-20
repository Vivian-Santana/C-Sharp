//instanciando uma banda
Banda Skank = new Banda();
Skank.NomeBanda = "Skank";

//instanciando album
Album albumSkank = new Album();
albumSkank.NomeAlbum = "maquinarama";

Musica musica1 = new Musica(Skank);
musica1.Titulo = "Canção noturna";
musica1.Duracao = 3.58; //em minutos


Musica musica2 = new Musica(Skank);
musica2.Titulo = "Três lados";
musica2.Duracao = 3.53;

Musica musica3 = new Musica(Skank);
musica3.Titulo = "Ali";
musica3.Duracao = 5.6;

//add musicas ao album
albumSkank.addMusica(musica1);
albumSkank.addMusica(musica2);
albumSkank.addMusica(musica3);

albumSkank.ExibirMusicasDoAlbum();

musica1.Genero = new Genero { GeneroMusical = "Rock nacional" }; //composição de classes
Console.WriteLine($"A música {musica1.Titulo} é do gênero {musica1.Genero.GeneroMusical}\n");

Skank.AdicionarAbum(albumSkank);
Skank.ExibirDiscografia();

