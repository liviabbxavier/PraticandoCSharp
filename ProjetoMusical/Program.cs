Banda strayKids = new Banda("Stray Kids");

Album albumDoSkz = new Album("Hop");

Musica musica1 = new Musica(strayKids, "Railway")
{
    Duracao = 300,
    Disponivel = true,
};

Musica musica2 = new Musica(strayKids, "So good")
{
    Duracao = 300,
    Disponivel = false,
};

albumDoSkz.AdicionarMusica(musica1);
albumDoSkz.AdicionarMusica(musica2);

strayKids.AdicionarAlbum(albumDoSkz);

musica1.FichaTecnica();
musica2.FichaTecnica();

albumDoSkz.ExibirMusicas();

strayKids.ExibirDiscografia();

Episodio ep1 = new Episodio(1, "História", 45);
ep1.AdicionarConvidados("Chrono");
ep1.AdicionarConvidados("Blxck");
ep1.AdicionarConvidados("Felicia Rock");
ep1.AdicionarConvidados("Hiosaki");
ep1.AdicionarConvidados("K O D A");
ep1.AdicionarConvidados("Anirap");
ep1.AdicionarConvidados("Takeru");
ep1.AdicionarConvidados("Tark");
ep1.AdicionarConvidados("Henrique Mendonça");
ep1.AdicionarConvidados("7MZ");
ep1.AdicionarConvidados("M4rkim");
ep1.AdicionarConvidados("VMZ");
ep1.AdicionarConvidados("Mistery");
ep1.AdicionarConvidados("Arteek");
ep1.AdicionarConvidados("Anny");
ep1.AdicionarConvidados("Lil Chaiz");
ep1.AdicionarConvidados("WLO");
ep1.AdicionarConvidados("Enygma");
ep1.AdicionarConvidados("ÉoDan");
ep1.AdicionarConvidados("Basara");
ep1.AdicionarConvidados("Daarui");
ep1.AdicionarConvidados("Sydnei Scaccio");
ep1.AdicionarConvidados("Tk Raps");
ep1.AdicionarConvidados("Sting Raps");
ep1.AdicionarConvidados("Flash Beats");
ep1.AdicionarConvidados("Dya");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new Episodio(2, "Técnicas de vocal", 67);
ep2.AdicionarConvidados("Chrono");
ep2.AdicionarConvidados("Blxck");
ep2.AdicionarConvidados("Felicia Rock");
ep2.AdicionarConvidados("Hiosaki");
ep2.AdicionarConvidados("K O D A");
ep2.AdicionarConvidados("Anirap");
ep2.AdicionarConvidados("Takeru");
ep2.AdicionarConvidados("Tark");
ep2.AdicionarConvidados("Henrique Mendonça");
ep2.AdicionarConvidados("7MZ");
ep2.AdicionarConvidados("M4rkim");
ep2.AdicionarConvidados("VMZ");
ep2.AdicionarConvidados("Mistery");
ep2.AdicionarConvidados("Arteek");
ep2.AdicionarConvidados("Anny");
ep2.AdicionarConvidados("Lil Chaiz");
ep2.AdicionarConvidados("WLO");
ep2.AdicionarConvidados("Enygma");
ep2.AdicionarConvidados("ÉoDan");
ep2.AdicionarConvidados("Basara");
ep2.AdicionarConvidados("Daarui");
ep2.AdicionarConvidados("Sydnei Scaccio");
ep2.AdicionarConvidados("Tk Raps");
ep2.AdicionarConvidados("Sting Raps");
ep2.AdicionarConvidados("Flash Beats");
ep2.AdicionarConvidados("Dya");
Console.WriteLine(ep2.Resumo);

Podcast podcast = new("Podcast especial do mundo nerd", "Player Tauz");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
/*Musica musica1 = new Musica();
musica1.Nome = "Cemitério";
musica1.Artista = "Chrono";
musica1.Duracao = 199;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescicaoResumida);
musica1.FichaTecnica();
Console.WriteLine();

Console.WriteLine($"Nome: {musica1.Nome}");
Console.WriteLine($"Artista: {musica1.Artista}");

Musica musica2 = new Musica();
musica2.Nome = "Papoco de 40tão";
musica2.Artista - "Anirap";
musica2.Duracao = 221;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);
musica2.FichaTecnica();

Console.WriteLine($"Nome: {musica2.Nome}");
Console.WriteLine($"Artista: {musica2.Artista}");
*/