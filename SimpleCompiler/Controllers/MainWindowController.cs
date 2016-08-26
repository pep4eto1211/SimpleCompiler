using SimpleCompiler.Code;
using SimpleCompiler.Compiler;
using SimpleCompiler.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCompiler.Controllers
{
    public class MainWindowController
    {
        #region Private members
        private CodeFile _codeFile;
        #endregion

        #region Constructor
        public MainWindowController()
        {
            this._codeFile = new CodeFile();
        }
        #endregion

        #region Public properties
        public CodeFile CodeFileObject
        {
            get
            {
                return this._codeFile;
            }
            set
            {
                this._codeFile = value;
            }
        }
        #endregion

        #region Public methods
        public void CompileCode()
        {
            string fileLocation;
            if (AskForFileLocation(out fileLocation))
            {
                List<string> errors = new List<string>();
                CodeCompiler.CompileCode(this._codeFile.ReferenceAssemblies.ToArray(), fileLocation, this._codeFile.Code, true, out errors);
                if (errors.Count > 0)
                {
                    ErrorListWindow errorWindow = new ErrorListWindow(errors);
                    errorWindow.ShowDialog();
                } 
            }
        }

        public void OpenReferenceConfiguration()
        {
            ReferencesConfigWindow refConfigWindow = new ReferencesConfigWindow(this);
            refConfigWindow.ShowDialog();
        }
        #endregion

        #region Helper methods
        private bool AskForFileLocation(out string selectedLocation)
        {
            selectedLocation = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Executable file|*.exe";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedLocation = saveFileDialog.FileName;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
