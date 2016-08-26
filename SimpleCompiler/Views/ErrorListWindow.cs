using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCompiler.Views
{
    public partial class ErrorListWindow : Form
    {
        #region Constructor
        public ErrorListWindow(List<string> errors)
        {
            InitializeComponent();
            PopulateErrorsList(errors);
        }
        #endregion

        #region Helper methods
        private void PopulateErrorsList(List<string> errors)
        {
            foreach (var item in errors)
            {
                this.errorsListBox.Items.Add(item);
            }
        }
        #endregion
    }
}
