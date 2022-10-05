using System;
using System.Net;

    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee("Andrii", "Shuldyk");
            tom.firstName = "Andrii";
            tom.lastName = "Shuldyk";
            tom.Print();
            tom.Wage(args);
        }
    }
    class Employee
    {
        public string firstName;
        public string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {firstName}; Surname: {lastName}");
        }
        public void Wage(string[] args)
        {
            int salary = 0;  
            int post;        
            int experience;  
            int exp = 0;         
            double wage;     
            Console.WriteLine($"Enter your post (Choose number: Junior - 1, Middle - 2, Senior - 3): ");
            post = int.Parse(Console.ReadLine());
            if (post == 1)
            {
                salary = 700;
            }
            else if (post == 2)
            {
                salary = 1000;
            }
            else if (post == 3)
            {
                salary = 1500;
            }

            Console.WriteLine($"Enter your experience: ");
            experience = int.Parse(Console.ReadLine());
            if (experience <= 2)
            {
                exp = 1;
            }
            else if (experience > 2 && experience <= 5)
            {
                exp = 2;
            }
            else if (experience > 5)
            {
                exp = 3;
            }

            Console.WriteLine($"Your wage is: {wage = salary * exp}; Tax collection (22%) is: {wage/100*22}");
        }
    }
