using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //最初のBookはvarでもいい
            book1.title = "C#入門";
            book1.publishedDate = new DateTime(2000,11,11);
            book1.author = "七月太郎";
            book1.price = 1000;
            int taxIncludedPrice = book1.getTaxIncludedPrice();
            int tax = book1.getTax();

            Console.WriteLine(tax + " " + taxIncludedPrice);
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);

            Magazine mag1 = new Magazine();
            mag1.title = "ベーシックマガジン";
            mag1.price = 1000;
            mag1.month = 1;

            int taxInclujdedPrice = mag1.getTaxIncludedPrice();
            string monthStr = mag1.getMonth();

            Novel nov1 = new Novel();
            nov1.title = "のー";
            nov1.series = "赤";

            Console.WriteLine(tax + " " + taxIncludedPrice);
            Console.WriteLine(mag1.title);
            Console.WriteLine(mag1.author);

            Console.WriteLine(tax + " " + taxIncludedPrice);
            Console.WriteLine(nov1.title);
            Console.WriteLine(nov1.author);
        }
    }

    class Book
    {
        public string title;
        public string author;
        public DateTime publishedDate;
        public int price;

        public const double taxRatio = 0.08;

        public int getTax()
        {
            return (int)(price * taxRatio);
        }

        public int getTaxIncludedPrice()
        {
            return price + getTax();
        }
    }

    class Magazine : Book
    {
        public int month;
        public string getMonth() {
            return month + "月号";
        }
    }

    class Novel :Book
    {
        public string series;
    }
}
