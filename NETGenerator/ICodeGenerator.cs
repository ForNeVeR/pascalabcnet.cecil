using PascalABCCompiler.NETGenerator;
using PascalABCCompiler.NetHelper;
using PascalABCCompiler.SemanticTree;

namespace NETGenerator
{
    public interface ICodeGenerator
    {
        void ConvertFromTree(IProgramNode p, string TargetFileName, string SourceFileName, CompilerOptions options,
            string[] ResourceFiles);

        void EmitAssemblyRedirects(AssemblyResolveScope resolveScope, string targetAssemblyPath);
    }
}