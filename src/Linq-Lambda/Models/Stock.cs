using System.Collections.Generic;
using System.Linq;
using Linq_Lambda.Repositories;

namespace Linq_Lambda.Models
{
    public class Stock
    {
        public int ComponentId { get; set; }
        public int Quantity { get; set; }


        // lista de components com estoque zerado
        public List<string> GetItemsOutOfStock()
        {
            var repository = new ComponentRepository();
            var componentsList = (from stock in repository.Stocks
                                  join component in repository.Components
                                  on stock.ComponentId equals component.Id
                                  where stock.Quantity == 0
                                  select component.Name).ToList();

            return componentsList;
        }

    }


}