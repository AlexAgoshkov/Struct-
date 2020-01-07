using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct NoteBook
    {
        string _manufacturer;
        string _model;
        int _price;

        public NoteBook(string manufacturer, string model, int price)
        {
            _manufacturer = manufacturer;
            _model = model;
            _price = price;
        }

        public void Display()
        {
            Console.WriteLine($"{_manufacturer} {_model} {_price}");
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {
            NoteBook noteBook = new NoteBook("A", "B", 20);
            noteBook.Display();


            Console.ReadKey();
        }
    }
}
