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

        private ModelDoc2 OpenDocument(string fileName)
        {
            int fileerror = 0;
            int filewarning = 0;
            return swApp.OpenDoc6(fileName, (int)swDocumentTypes_e.swDocASSEMBLY, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref fileerror, ref filewarning);
        }

              private void OpenAssemblyButtonClick(object sender, EventArgs e)
        {
            // display an open file dialog where user can select an assembly file  
            OpenFileDialog openAssemblyFileDialog = new OpenFileDialog
            {
                InitialDirectory = "E:\\Files\\KPI\\macro",
                Filter = "SolidWorks2014 assembly files|*.sldasm",
                Title = "Select a Cursor File"
            };

            // show the dialog 
            // if the user clicked OK in the dialog and  
            // a file was selected, get name of the file
            if (openAssemblyFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // get name of the assembly file
                string fileName = openAssemblyFileDialog.FileName;

                // start solidworks 
                swApp = new SldWorks
                {
                    Visible = true
                };

                // open assembly file
                swDoc = OpenDocument(fileName);

                // activate opened document
                swApp.ActivateDoc2("sborka", false, 0);

                // get active document
                swDoc = (ModelDoc2)swApp.ActiveDoc;
            }
        }
    }
     
}
