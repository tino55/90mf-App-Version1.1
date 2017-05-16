using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _90mfApp
{
    public partial class formEditFA : Form
    {
        public formEditFA()
        {
            InitializeComponent();
        }

        private void fABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._90MFAppDataSet);

        }

        private void formEditFA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_90MFAppDataSet.FA' table. You can move, or remove it, as needed.
            this.fATableAdapter.Fill(this._90MFAppDataSet.FA);

        }
    }
}
