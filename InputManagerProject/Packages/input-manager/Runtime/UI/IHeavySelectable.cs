using System.Collections.Generic;

namespace UI
{
    public interface IHeavySelectable
    {
        IEnumerable<IHeavySelectable> SelectableElements { get; }
    }
}