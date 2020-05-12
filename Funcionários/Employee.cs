using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Funcionários
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void increaseSalary(double percentage)
        {
            Salary = Salary + (Salary * (percentage/100));
        }
    }
}
