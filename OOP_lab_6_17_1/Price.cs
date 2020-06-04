using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_6_17_1
{
    class Price
    {
        private string _name;
        private double _itemPrice;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }

        public Price()
        {
            _name = "Не вказано";
            _itemPrice = 0;
        }

        public Price(string Name, double ItemPrice)
        {
            _name = Name;
            _itemPrice = ItemPrice;
        }
    }
}
