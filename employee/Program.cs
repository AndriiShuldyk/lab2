using System;
using System.Net;

    class Employee
    {
        public string firstName;
        public string lastName;
        double wage; 
        int salary; 
        int experience; 
        int exp; 
        int post; 
        double tax; 

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public static void Main()
        {
            Employee an = new Employee("Andrii", "Shuldyk");
            an.firstName = "Andrii";
            an.lastName = "Shuldyk";
            Console.WriteLine($"Name: {an.firstName}; Surname: {an.lastName}");

            Console.WriteLine($"Enter your post (Choose number: Junior - 1, Middle - 2, Senior - 3): ");
            an.post = int.Parse(Console.ReadLine());
            if (an.post == 1)
            {
                an.salary = 1000;
            }
            else if (an.post == 2)
            {
                an.salary = 2000;
            }
            else if (an.post == 3)
            {
                an.salary = 3000;
            }

            Console.WriteLine($"Enter your experience: ");
            an.experience = int.Parse(Console.ReadLine());
            if (an.experience > 0 && an.experience <= 2)
            {
                an.exp = 1;
            }
            else if (an.experience > 2 && an.experience <= 5)
            {
                an.exp = 2;
            }
            else if (an.experience > 5)
            {
                an.exp = 3;
            }

            Console.WriteLine("Your wage is: " + an.salary * an.exp + "; Tax collection: " + (an.salary * an.exp) / 100 * 22);
        }
    }

