using System.Collections.Generic;
using Linq_Lambda.Models;

namespace Linq_Lambda.Repositories
{
    public class ComponentRepository
    {
        public List<Component> Components;
        public List<Stock> Stocks;

        public ComponentRepository()
        {
            Components = new List<Component>();
            Stocks = new List<Stock>();
            for (int i = 0; i < 20; i++)
            {
                Component c = new Component() { Id = i, Name = "Component " + i };
                Components.Add(c);
            }

            int stockSelected = 0;
            int[] sto = new int[] { 0, 500, 7000, 9000 };
            foreach (var item in Components)
            {

                Stock s = new Stock()
                {
                    ComponentId = item.Id,
                    Quantity = sto[stockSelected]
                };
                stockSelected++;
                if (stockSelected > 3)
                {
                    stockSelected = 0;
                }

                Stocks.Add(s);
            }
        }
    }
}