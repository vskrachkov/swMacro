using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;

namespace SolidWorksMacro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SldWorks swApp;
        ModelDoc2 swDoc;
        object swProcess;

        Guid swGuid = new Guid("CF33D714-2C34-4608-8766-2536E6C41536");

        private void ClickButtonRunMacro(object sender, EventArgs e)
        {
            // start solidworks 
        }
    }

}
