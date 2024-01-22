// See https://aka.ms/new-console-template for more information

using Lista;


Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());


List<Funcionarios> list = new List<Funcionarios>();

for (int i = 1; i < n; i++)
{
    Console.WriteLine($"Emplyoee #{i}:");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    list.Add(new Funcionarios(id, name, salary));

    Console.WriteLine();
}



Console.Write("Enter the employee id that will have salary increase :");
int getId = int.Parse(Console.ReadLine());

Funcionarios emp = list.Find(x => x.Id == getId);

if (emp != null)
{
    Console.Write("Enter the percentage: ");
    double porcentage = double.Parse(Console.ReadLine());
    emp.IncreaseSalary(porcentage);
}
else { Console.WriteLine("This id does not exist!"); }

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Funcionarios obj in list)
{
    Console.WriteLine(obj);
}