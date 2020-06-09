using MenuSelector.Menu;
using System.Collections.Generic;
using System.Linq;

namespace MenuSelector.Selector
{
    public class HighPriceSelector : ISelectable
    {
        public AMenu Select(IEnumerable<AMenu> menus)
        {
            return menus.OrderByDescending(menu => menu.Price).FirstOrDefault();
        }
    }
}
