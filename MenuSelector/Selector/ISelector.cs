using MenuSelector.Menu;
using System.Collections.Generic;

namespace MenuSelector
{
    public interface ISelectable
    {
        AMenu Select(IEnumerable<AMenu> menus);
    }
}
