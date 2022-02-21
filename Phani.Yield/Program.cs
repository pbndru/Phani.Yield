using System;
using System.Collections.Generic;

namespace Phani.Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEmployeeDetails();
        }

        static void PrintEmployeeDetails()
        {
            var details = GetEmployeeDetails();

            foreach(var detail in details)
            {
                Console.WriteLine($"Employee id {detail.Id}");
            }
        }

        static IEnumerable<Employee> GetEmployeeDetails()
        {
            for (int i = 0; i < 50000; i++)
            {
                yield return new Employee() { Id = i, Name = $"Employee {i}" };
            }
        }
    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
