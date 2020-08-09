using System;

namespace week4course
{
    class Program
    {
        static void Main(string[] args)
        {
            Author arghezi = new Author();
            Author creanga = new Author("Creanga", "creanga@gmail.com", 2);
            //arghezi.printAuthor();
            //creanga.printAuthor();
            Book b1 = new Book();
            b1.PrintBook();
            Console.WriteLine("========================================================================================================================================================");
            Book b2 = new Book("Dama cu Camelii", 1864, 19.99);
            b2.PrintBook();
            Console.WriteLine("========================================================================================================================================================");
            Book b3 = new Book("Amintiri din copilarie", creanga, 1834, 99.99);
            b3.PrintBook();
            Console.WriteLine("========================================================================================================================================================");
            Book b4 = new Book("Morometii", "Marin Preda", "marin.preda@gmail.com", 7, 1934, 29.99);
            b4.PrintBook();
            Console.WriteLine("========================================================================================================================================================");

           
            Library l = new Library();
            Library l2 = new Library("Iasi2", b2);
        }
    }
}
