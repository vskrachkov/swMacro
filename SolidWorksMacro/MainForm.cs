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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SldWorks swApp;
        ModelDoc2 swDoc;
        AssemblyDoc swAssembly;

        Guid swGuid = new Guid("CF33D714-2C34-4608-8766-2536E6C41536");

        private void ClickButtonRunMacro(object sender, EventArgs e)
        {
            // start solidworks 
            // swApp = (SldWorks) System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(swGuid));
            swApp = new SldWorks
            {
                Visible = true
            };

            // creaate new assembly document 
            swDoc = (ModelDoc2)swApp.NewDocument("C:\\ProgramData\\SolidWorks\\SolidWorks 2014\\templates\\gost-assy.asmdot", 0, 0, 0);
            swApp.ActivateDoc2("—борка1", false, 0);
            swAssembly = (AssemblyDoc)swDoc;

            ModelView myModelView = null;
            myModelView = (ModelView)swDoc.ActiveView;
            myModelView.FrameState = (int)swWindowState_e.swWindowMaximized;
        }
    }
     
}
