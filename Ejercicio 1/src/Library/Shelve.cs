using System;

namespace Ucu.Poo.Expert
{
    public class Shelve
    {
        //La responsabilidad de esta clase es representar un estante de la biblioteca del libro creado en Book.

        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }

        public Shelve(String librarySector, String libraryShelve)
        {
            this.LibrarySector = librarySector;
            this.LibraryShelve = libraryShelve;
        }

    }
}