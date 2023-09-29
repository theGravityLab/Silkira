using System.Collections.ObjectModel;

namespace Silkira.Abstractions.Elements;

public class PanelBase : ILayoutable
{
    public ICollection<ILayoutable> Children { get; } = new Collection<ILayoutable>();
}