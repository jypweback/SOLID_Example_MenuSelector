using MenuSelector.Menu;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuSelector.Selector
{
    public class RandomSelector : ISelectable
    {
        public AMenu Select(IEnumerable<AMenu> menus)
        {
            var randomIndex = new Random().Next(0, menus.Count());
            return menus.ElementAt(randomIndex);
        }
    }
}
