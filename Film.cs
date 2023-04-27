using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    internal class Movie
    {
        public Movie(string name, int durMin)
        {
            _name = name;
            _durMin = durMin;
        }
        public string _name { get; set; }
        public int _durMin { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Название фильма : {_name}, продолжительность : {_durMin}");
        }
    }
}
