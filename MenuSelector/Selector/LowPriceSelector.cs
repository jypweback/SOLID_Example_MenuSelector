using MenuSelector.Menu;
using System.Collections.Generic;
using System.Linq;

namespace MenuSelector.Selector
{
    public class LowPriceSelector : ISelectable
    {
        public AMenu Select(IEnumerable<AMenu> menus)
        {
            return menus.OrderBy(menu => menu.Price).FirstOrDefault();
        }
    }
}
