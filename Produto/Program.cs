/*
string nome1 = "Teclado";
string descricao1 = "Modelo compacto e silencioso, " +
                    "perfeito para produtividade diária.";
decimal preco1 = 80.00m;
int estoque1 = 15;
 
Console.WriteLine($@"Dados do item 1:
Nome: {nome1},
Descrição: {descricao1}
Preço: {preco1},
Estoque: {estoque1}
");
 
string nome2 = "Cadeira gamer";
string descricao2 = "Conforto ergonômico com design" +
                    " moderno para longas sessões de jogo.";
decimal preco2 = 600.00m;
int estoque2 = 5;
 
Console.WriteLine($@"Dados do item 2:
Nome: {nome2},
Descrição: {descricao2}
Preço: {preco2},
Estoque: {estoque2}
");
*/
Produto item1 = new Produto();
item1.nome = "Teclado";
item1.descricao = "Modelo compacto e silencioso, " +
                    "perfeito para produtividade diária.";
item1.preco = " 80.00m";
item1.estoque = "15";
 
                    Console.WriteLine($@"Dados do item 1:
Nome: {item1.nome};
Descrição: {item1.descricao};
Preço: {item1.preco};
Estoque: {item1.estoque}.
");
 
if (item1.EstaDisponivel())
{
    Console.WriteLine("Produto esta Disponivel");
}
 
item1.AlterarPrecoCoDesconto(0.2m);
 
 Console.WriteLine($@"Dados do item 1:
Nome: {item1.nome};
Descrição: {item1.descricao};
Preço: {item1.preco};
Estoque: {item1.estoque}.
");