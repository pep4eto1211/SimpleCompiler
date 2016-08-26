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
    public partial class ReferencesConfigWindow : Form
    {
        #region Controller
        private MainWindowController _controller;
        #endregion

        #region Constructor
        public ReferencesConfigWindow(MainWindowController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }
        #endregion

        #region Event handlers
        private void ReferencesConfigWindow_Load(object sender, EventArgs e)
        {
            LoadReferenceList();
        }

        private void btnAddReference_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNewReference.Text.Trim()))
            {
                this._controller.CodeFileObject.ReferenceAssemblies.Add(this.txtNewReference.Text.Trim());
                LoadReferenceList();
                this.txtNewReference.Text = string.Empty;
            }
        }
        #endregion

        #region Helper methods
        private void LoadReferenceList()
        {
            this.referencesListBox.Items.Clear();
            foreach (var item in this._controller.CodeFileObject.ReferenceAssemblies)
            {
                this.referencesListBox.Items.Add(item);
            }
        }
        #endregion
    }
}
