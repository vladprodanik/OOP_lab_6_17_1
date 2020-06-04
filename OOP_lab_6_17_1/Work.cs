using System.Collections.Generic;

namespace OOP_lab_6_17_1
{
    interface Work
    {
        public void SaleM();

        public Price Find(Sale Item, List<Price> Items);
    }
}
