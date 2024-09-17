// nome, artista, duração, dispnibilidade

//criando musicas
Album albumSkank = new Album();
albumSkank.Nome = "maquinarama";

Musica musica1 = new Musica();
musica1.Titulo = "Canção noturna";
musica1.Duracao = 3.58; //em minutos

Musica musica2 = new Musica();
musica2.Titulo = "Três lados";
musica2.Duracao = 3.53;

Musica musica3 = new Musica();
musica3.Titulo = "Ali";
musica3.Duracao = 5.6;

//add musicas ao album
albumSkank.addMusica(musica1);
albumSkank.addMusica(musica2);
albumSkank.addMusica(musica3);

albumSkank.ExibirMusicasDoAlbum();

