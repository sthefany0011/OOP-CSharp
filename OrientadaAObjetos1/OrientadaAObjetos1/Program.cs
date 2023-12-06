

using OrientadaAObjetos1;

 Pessoas pessoa1, pessoa2;

pessoa1 = new Pessoas();
pessoa2 = new Pessoas();

Console.WriteLine("first person data: ");
pessoa1.Name = Console.ReadLine();
pessoa1.Age= int.Parse(Console.ReadLine());

Console.WriteLine("second person data: ");
pessoa2.Name = Console.ReadLine();
pessoa2.Age = int.Parse(Console.ReadLine());


if(pessoa1.Age > pessoa2.Age)
{
    Console.WriteLine("Pessoa mais velha: "+ pessoa1.Name);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + pessoa2.Name);
}