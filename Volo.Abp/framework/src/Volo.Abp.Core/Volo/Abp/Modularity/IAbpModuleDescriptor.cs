using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Volo.Abp.Modularity
{
    public interface IAbpModuleDescriptor
    {
        Type Type { get; }

        Assembly Assembly { get; }

        IAbpModule Instance { get; }

        bool IsLoadedAsPlugIn { get; }

        IReadOnlyList<IAbpModuleDescriptor> Dependencies { get; }
    }
}
