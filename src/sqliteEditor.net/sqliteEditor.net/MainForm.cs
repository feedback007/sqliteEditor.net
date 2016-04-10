using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqliteEditor.net.UI;

namespace sqliteEditor.net
{
    public partial class MainForm : Form
    {
        SQLEditorForm _SQLEditorForm = null;
        CatalogTreeForm _dbTreeForm = null;

        public MainForm()
        {
            InitializeComponent();

            _SQLEditorForm = new SQLEditorForm();
            _SQLEditorForm.DockPanel = this.dockPanel1;
            _SQLEditorForm.Show();

            _dbTreeForm = new CatalogTreeForm();
            _dbTreeForm.DockPanel = this.dockPanel1;
            _dbTreeForm.Show();
        }
    }
}
