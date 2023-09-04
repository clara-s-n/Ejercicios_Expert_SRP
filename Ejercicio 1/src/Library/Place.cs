using System;

namespace Ucu.Poo.Expert

{
    //La responsabilidad de esta clase es asignarle el lugar correspondiente creado en Shelve al libro creado en Book.
    public class Place
    {
        public Shelve Shelve { get; set; }
        public Book Book { get; set; }

        public Place(Shelve shelve, Book book)
        {
            this.Shelve = shelve;
            this.Book = book;
        }
    }
}