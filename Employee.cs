using System;


namespace ex023
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

       
        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }


        public override string ToString(){
            return "ID: " + Id +
                    ", Name: " + Name + 
                    ", Salary: " + Salary;
                    
        }
        
    }
}