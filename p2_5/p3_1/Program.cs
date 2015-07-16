using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.lastName ="";
            p1.firstName ="";
            p1.phoneticLastName ="";
            p1.phoneticFirstName ="";
            p1.birthDate = new DateTime(2009, 01, 01);


        }

        class Person
        {
            public string lastName;
            public string firstName;
            public string phoneticFirstName;
            public string phoneticLastName;
            public DateTime birthDate;

            public int getAge()
            {
                int age = 0;
                DateTime now = DateTime.Now;
                TimeSpan ts = now - birthDate;
                age = (int)((double)ts.Days / 365.2425);

                return age;
            }


        }

    }

}
