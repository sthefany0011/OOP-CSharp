using OrientadaAObjeto5;
using System.Globalization;

Funcionarios funcionarios = new Funcionarios();
Console.Write("Nome: ");
funcionarios.Name = Console.ReadLine();
Console.Write("Salário bruto: ");
funcionarios.SalarioBruto=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
funcionarios.Imposto=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


Console.WriteLine("Funcionário: " + funcionarios);
Console.WriteLine();

Console.Write("Digite a porcentagem para aumentar o salário: ");
double aumentoDeSalario= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
funcionarios.AumentarSalario(aumentoDeSalario);

Console.WriteLine("Dados atualizados: " + funcionarios);
