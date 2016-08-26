using SimpleCompiler.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCompiler
{
    public partial class MainWindow : Form
    {
        #region Controller
        MainWindowController _controller;
        #endregion

        #region Constructor
        public MainWindow(MainWindowController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }
        #endregion

        #region Event handlers
        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._controller.CodeFileObject.Code = this.codeField.Text;
            this._controller.CompileCode();
        }

        private void configureReferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._controller.OpenReferenceConfiguration();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
