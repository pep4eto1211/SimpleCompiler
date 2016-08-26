using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler.Code
{
    public class CodeFile
    {
        #region Private members
        private List<string> _referenceAssemblies;
        private string _code;
        #endregion

        #region Constructor
        public CodeFile()
        {
            this._referenceAssemblies = new List<string>();
            this._referenceAssemblies.Add("mscorlib.dll");
            this._referenceAssemblies.Add("System.Core.dll");
            this._referenceAssemblies.Add("System.dll");
            this._code = string.Empty;
        }
        #endregion

        #region Public properties
        public List<string> ReferenceAssemblies
        {
            get
            {
                return this._referenceAssemblies;
            }
            set
            {
                this._referenceAssemblies = value;
            }
        }

        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        #endregion
    }
}
