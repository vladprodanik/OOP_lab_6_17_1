using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_6_17_1
{
    class Sale
    {
        private DateTime _date;
        private string _name;
        private int _count;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public Sale()
        {
            _date = DateTime.Parse("01.01.0001");
            _name = "Не вказано";
            _count = 0;
        }

        public Sale(DateTime Date, string Name, int Count)
        {
            _date = Date;
            _name = Name;
            _count = Count;
        }
    }
}
