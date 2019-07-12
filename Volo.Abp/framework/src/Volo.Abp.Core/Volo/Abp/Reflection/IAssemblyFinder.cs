using System.Collections.Generic;
using System.Reflection;

namespace Volo.Abp.Reflection
{
    public interface IAssemblyFinder
    {
        IReadOnlyList<Assembly> Assemblies { get; }
    }
}
