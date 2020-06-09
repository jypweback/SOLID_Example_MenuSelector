using MenuSelector.Menu;
using System.Collections.Generic;

namespace MenuSelector
{
    class MenuSelector
    {
        private IEnumerable<AMenu> menus;

        private ISelectable selectable;

        public MenuSelector(IEnumerable<AMenu> _menus, ISelectable _selectable)
        {
            this.menus = _menus;
            this.selectable = _selectable;
        }

        public AMenu GetMenu()
        {
            return selectable.Select(menus);
        }
    }
}
