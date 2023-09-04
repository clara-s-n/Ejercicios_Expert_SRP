using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            //Crear un libro
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            //Crear un estante
            Shelve shelve1 = new Shelve("A", "7");
            Shelve shelve2 = new Shelve("B", "3");

            //Crear un lugar
            Place place1 = new Place(shelve1, book1);
            Place place2 = new Place(shelve2, book2);

            //Mostrar el libro y el estante
            Console.WriteLine("Book 1: {0}, {1}, {2}", place1.Book.Title, place1.Book.Author, place1.Book.Code);
            Console.WriteLine("Se encuentra en la repisa: {0}, {1}", place1.Shelve.LibrarySector, place1.Shelve.LibraryShelve);

            Console.WriteLine("Book 2: {0}, {1}, {2}", place2.Book.Title, place2.Book.Author, place2.Book.Code);
            Console.WriteLine("Se encuentra en la repisa: {0}, {1}", place2.Shelve.LibrarySector, place2.Shelve.LibraryShelve);
        }
    }
}