

using OrientadaAObjetos3;
using System.Globalization;

Produto p= new Produto();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
p.Quantidade =int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
int qte= int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
int RemoverQte = int.Parse(Console.ReadLine());
p.RemoverProdutos(RemoverQte);
Console.WriteLine("Dados atualizados:" + p);

