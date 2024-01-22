using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Funcionarios
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionarios(int id, string nome, double salary)
        {
            Id = id;
            Name = nome;
            Salary = salary;
        }



        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
