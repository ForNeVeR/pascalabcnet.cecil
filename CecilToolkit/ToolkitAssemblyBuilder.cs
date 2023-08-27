using System.Reflection;
using System.Reflection.Emit;

namespace CecilToolkit
{
    public class ToolkitAssemblyBuilder
    {
        public static ToolkitAssemblyBuilder From(AssemblyBuilder realBuilder) =>
            new ToolkitAssemblyBuilder(realBuilder);

        private readonly AssemblyBuilder _realBuilder;

        private ToolkitAssemblyBuilder(AssemblyBuilder realBuilder)
        {
            _realBuilder = realBuilder;
        }

        public void DefineVersionInfoResource(
            string product,
            string productVersion,
            string company,
            string copyright,
            string trademark) =>
            _realBuilder.DefineVersionInfoResource(
                product,
                productVersion,
                company,
                copyright,
                trademark);

        public void DefineUnmanagedResource(string resourceFileName) =>
            _realBuilder.DefineUnmanagedResource(resourceFileName);

        public void DefineUnmanagedResource(byte[] resource) =>
            _realBuilder.DefineUnmanagedResource(resource);

        // TODO: ToolkitConstructorInfo
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute) =>
            _realBuilder.SetCustomAttribute(con, binaryAttribute);

        // TODO: ToolkitCustomAttributeBuilder
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder) =>
            _realBuilder.SetCustomAttribute(customBuilder);

        // TODO: ToolkitModuleBuilder
        public ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo) =>
            _realBuilder.DefineDynamicModule(name, emitSymbolInfo);

        // TODO: ToolkitModuleBuilder
        public ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo) =>
            _realBuilder.DefineDynamicModule(name, fileName, emitSymbolInfo);

        // TODO: ToolkitMethodBuilder
        // TODO: PEFileKinds
        public void SetEntryPoint(MethodBuilder entryMethod, PEFileKinds fileKind) =>
            _realBuilder.SetEntryPoint(entryMethod, fileKind);

        public object CreateInstance(string typeName) =>
            // TODO: Get rid of this API
            _realBuilder.CreateInstance(typeName);

        public void Save(string assemblyFileName) =>
            _realBuilder.Save(assemblyFileName);

        // TODO: ToolkitPortableExecutableKinds
        // TODO: ToolkitImageFileMachine
        public void Save(
            string assemblyFileName,
            PortableExecutableKinds portableExecutableKind,
            ImageFileMachine imageFileMachine) =>
            _realBuilder.Save(assemblyFileName, portableExecutableKind, imageFileMachine);
    }
}