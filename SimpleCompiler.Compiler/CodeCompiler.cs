using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler.Compiler
{
    public class CodeCompiler
    {
        #region Constants
        private const string _COMPILER_VERSION = "v3.5";
        #endregion

        #region Public methods
        public static void CompileCode(string[] referenceAssemblies, string resultBinaryLocation, string code, bool includeDebugInformation, out List<string> compileErrors)
        {
            compileErrors = new List<string>();

            var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", _COMPILER_VERSION } });
            var parameters = new CompilerParameters(referenceAssemblies, resultBinaryLocation, includeDebugInformation);
            parameters.GenerateExecutable = true;
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, code);

            compileErrors = results.Errors.Cast<CompilerError>().Select(e => e.ErrorText).ToList();
        } 
        #endregion
    }
}
