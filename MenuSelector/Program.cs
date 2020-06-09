using MenuSelector.Menu;
using MenuSelector.Selector;
using System;
using System.Collections.Generic;

namespace MenuSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<AMenu> menus = new List<AMenu>() {
                new 국밥(),
                new 돈까스(),
                new 라면(),
                new 스파게티()
            };

            ISelectable selectable = new HighPriceSelector();
            Console.WriteLine(new MenuSelector(menus, selectable).GetMenu().Explain());

            selectable = new LowPriceSelector();
            Console.WriteLine(new MenuSelector(menus, selectable).GetMenu().Explain());

            selectable = new RandomSelector();
            Console.WriteLine(new MenuSelector(menus, selectable).GetMenu().Explain());
        }
    }
}
