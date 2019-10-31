using System;
using System.Globalization;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();

            newPerson.Name = "Alice";
            newPerson.BirthDay = DateTime.Parse("1990/1/20");
            
            newPerson.Gender = "Female";
            
            Console.Write(newPerson.ToString());

            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
       
        public string Gender { get; set; }

        public string IsGender()
        {
            string message;
            if (Gender == "Female")
                message = "Female";

            else if (Gender == "Male")
                message = "Male";

            else
                message = "Gender must be Female or Male";

            return message;
        }

       

        public override string ToString()
        {
           return  "Person:\nName: " + Name + "\nBirth Day: " + BirthDay.ToString("d") + "\nGender: " + IsGender();
        }
    }
}