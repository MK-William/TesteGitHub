using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex023 {
    class Program {
        static void Main(string[] args) {
            
            List<Employee> list = new List<Employee>();

            
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine( ));

           
            for (int i = 0 ; i < n  ;i++) {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("NAME: ");
                string name = Console.ReadLine();
                Console.Write("SALARY: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Employee{Id = id ,Name = name ,Salary = salary});
                
            }


            System.Console.Write("Enter the employee id that will have salary increase: ");
            int id_confirm = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x=> x.Id == id_confirm);

            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);

            } else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
            




            
            
             

        }
    }                             
}    

