using JetBrains.Annotations;
using System.Collections.Generic;

namespace Volo.Abp.Modularity
{
    public interface IModuleContainer
    {
        [NotNull]
        IReadOnlyList<IAbpModuleDescriptor> Modules { get; }
    }
}
