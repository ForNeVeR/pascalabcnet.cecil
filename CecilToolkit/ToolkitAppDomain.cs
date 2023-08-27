using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace CecilToolkit
{
    public class ToolkitAppDomain
    {
        public static ToolkitAppDomain FromCurrentThread()
        {
            return new ToolkitAppDomain(Thread.GetDomain());
        }

        private readonly AppDomain _realDomain;
        private ToolkitAppDomain(AppDomain realDomain)
        {
            _realDomain = realDomain;
        }

        // TODO: ToolkitAssemblyName
        // TODO: ToolkitAssemblyBuilderAccess
        public ToolkitAssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir) =>
            ToolkitAssemblyBuilder.From(_realDomain.DefineDynamicAssembly(name, access, dir));
    }
}
