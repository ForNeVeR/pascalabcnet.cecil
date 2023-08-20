// Copyright (c) Ivan Bondarev, Stanislav Mikhalkovich (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)
/***************************************************************************
 *   
 *   Интерфейс доступа к кодогенераторам для Compiler   
 *   Зависит от SemanticTree
 *
 ***************************************************************************/

using System;
using System.Collections;
using NETGenerator;
using PascalABCCompiler.NETGenerator;
using PascalABCCompiler.NetHelper;

namespace PascalABCCompiler.CodeGenerators
{
	/*public class CodeGeneratorOptions
	{
		public NETGenerator.TargetType TargetType;
	}*/

	public class Controller
	{
		private ICodeGenerator _ilCodeGenerator;//=new NETGenerator.ILConverter();

		public void Compile(SemanticTree.IProgramNode ProgramTree,string TargetFileName,string SourceFileName ,
            NETGenerator.CompilerOptions options, Hashtable StandartDirectories, string[] ResourceFiles, bool useNewCompiler)
		{
			_ilCodeGenerator = useNewCompiler
				? (ICodeGenerator)new CecilCodeGenerator(StandartDirectories)
				: new NETGenerator.IlCodeGenerator(StandartDirectories);
			_ilCodeGenerator.ConvertFromTree(ProgramTree, TargetFileName, SourceFileName, options, ResourceFiles);
		}

		public void EmitAssemblyRedirects(AssemblyResolveScope resolveScope, string outputFileName) =>
			_ilCodeGenerator.EmitAssemblyRedirects(resolveScope, outputFileName);

		public void Reset()
		{
            _ilCodeGenerator = null;
        }
	}
}
