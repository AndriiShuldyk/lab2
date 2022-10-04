using System;
using System.Net;

    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        protected static readonly DateTime fillingDate;

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        static User()
        {
            fillingDate = DateTime.Now;
        }

        public static void Main()
        {
            User one = new User();
            one.login = "shuldyk_andrii";
            one.name = "Andrii";
            one.surname = "Shuldyk";
            one.Age = 18;
            Console.WriteLine($"Login: {one.login}; Name: {one.name}; Surname: {one.surname}; Age: {one.age}; date of filling out the questionnaire: {fillingDate}");
        }
    }

