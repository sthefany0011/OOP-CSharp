using OrientadaAObjetos4;
using System.Globalization;

Retangulo r = new Retangulo();
Console.WriteLine("Entre a largura e altura do retângulo:");
r.Largura=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
r.Altura=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(r);