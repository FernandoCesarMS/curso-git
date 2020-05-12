using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Globalization;

namespace Funcionários
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int amountEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountEmployees; i++)
            {
                Employee funcionario;
                Console.WriteLine("Employees#{0}",i+1);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine();
                funcionario = new Employee(id, name, salary);
                list.Add(funcionario);
            }

            Console.Write("Enter the Employee that will have the salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());
            foreach(Employee obj in list)
            {
                if (obj.Id == idEmployee)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine());
                    obj.increaseSalary(percentage);
                } else if (obj.Id == list[amountEmployees-1].Id)
                {
                    Console.WriteLine("This id does not exist!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of Employees");
            foreach(Employee obj in list)
            {
                Console.WriteLine("{0}, {1}, {2}", obj.Id, obj.Name, obj.Salary);
            }

        }
    }
}
