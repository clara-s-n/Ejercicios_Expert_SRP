/*No cumple con el principio de responsabilidad única porque tiene más de una 
razón para cambiar. La primera razón de cambio es que la clase puede cambiar si
cambia la forma en que se representa un libro. La segunda razón de cambio es que la
clase puede cambiar si cambia la forma en que se representa un estante de la
biblioteca. Por lo tanto, esta clase tiene dos responsabilidades y debe dividirse 
en dos clases diferentes: una para representar un libro y otra para representar un 
estante de la biblioteca. También se debería crear una clase que asigne el lugar
al libro correspondiente*/

using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {
        //La responsabilidad de esta clase es representar un libro de la biblioteca.
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}