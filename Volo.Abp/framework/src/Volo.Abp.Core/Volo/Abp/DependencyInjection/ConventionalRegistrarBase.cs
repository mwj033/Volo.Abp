using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Volo.Abp.DependencyInjection
{
    public abstract class ConventionalRegistrarBase : IConventionalRegistrar
    {
        public void AddAssembly(IServiceCollection services, Assembly assembly)
        {
            var types = AssemblyHelper
            throw new NotImplementedException();
        }

        public void AddType(IServiceCollection services, Type type)
        {
            throw new NotImplementedException();
        }

        public void AddTypes(IServiceCollection services, params Type[] types)
        {
            throw new NotImplementedException();
        }
    }
}
