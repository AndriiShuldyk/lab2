using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

    public class Address
    {
        string index;
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
        string country;
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        string city;
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        string street;
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        string house;
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        string apartment;
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
        public static void Main()
        {
            Address address = new Address();
            address.index = "08400";
            address.country = "Ukraine";
            address.city = "Pereiaslav";
            address.street = "Soborna";
            address.house = "52";
            address.apartment = "7";       
            Console.WriteLine(address.index);
            Console.WriteLine(address.country);
            Console.WriteLine(address.city);
            Console.WriteLine(address.street);
            Console.WriteLine(address.house);
            Console.WriteLine(address.apartment);
        }
    }