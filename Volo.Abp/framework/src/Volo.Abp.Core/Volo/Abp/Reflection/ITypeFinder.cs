using System;
using System.Collections.Generic;

namespace Volo.Abp.Reflection
{
    public interface ITypeFinder
    {
        IReadOnlyList<Type> Types { get; }
    }
}
