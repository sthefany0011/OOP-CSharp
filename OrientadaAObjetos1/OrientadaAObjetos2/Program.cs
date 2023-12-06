

using OrientadaAObjetos2;
using System.Globalization;

Funcionarios pessoa1, pessoa2;
pessoa1= new Funcionarios();
pessoa2= new Funcionarios();    

Console.WriteLine("Dados do primeiro funcionário:");
pessoa1.Nome = Console.ReadLine();
pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



Console.WriteLine("Dados do segundo funcionário:");
pessoa2.Nome = Console.ReadLine();
pessoa2.Salario =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double soma = (pessoa1.Salario + pessoa2.Salario) / 2.00;

Console.WriteLine("Salário médio = " + soma.ToString("F2", CultureInfo.InvariantCulture));