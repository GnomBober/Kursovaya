using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    internal class Session : Film
    {
        public Session(string name, int durMin, int hall, string showTime) : base(name, durMin)
        {
            _name = name;
            _durMin = durMin;
            _hall = hall;
            _showTime = showTime;     
        }
        public int _hall { get; set; }
        public string _showTime { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Фильм : {_name}, \n Продолжительность : {_durMin}, \n Зал : {_hall}, \n Дата и время показа : {_showTime}");
        }
    }
}
