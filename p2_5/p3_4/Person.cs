using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_4
{
    class Person
    {
        public string lastName;
        public string firstName;
        public string furiganaLastName;
        public string furiganaFirstName;
        public DateTime birthday;


        private int height;
        private int weight;

        public Person()
        {
        }

        public Person(string lastName, string firstName, string furiganaLastName, string furiganaFirstName, DateTime birthday)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.furiganaLastName = furiganaLastName;
            this.furiganaFirstName = furiganaFirstName;
            this.birthday = birthday;

        }
        /*
        public int Height {
            set { return height; };
            get { }
        }

        public int Weight
        {
            set { }
            get { }
        }
        */
        public int getAge()
        {
            int age = 0;
            DateTime now = DateTime.Now;
            TimeSpan ts = now - birthday;
            age = (int)((double)ts.Days / 365.2425);
            return age;
        }
    }

}
