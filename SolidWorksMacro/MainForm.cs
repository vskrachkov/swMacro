using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SolidWorksMacro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private SldWorks swApp;
        private ModelDoc2 swDoc;
        private AssemblyDoc swAsm;
        private Feature feature, subFeature;
        private DisplayDimension displayDimension;
        private Dimension dimension;

        Guid swGuid = new Guid("CF33D714-2C34-4608-8766-2536E6C41536");

        private ModelDoc2 OpenAssembly(string fileName)
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
                Title = "Select a SolidWorks Assembly File"
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
                    Visible = this.swVisible.Checked
                };

                // open assembly file
                swDoc = OpenAssembly(fileName);

                // activate opened document
                swApp.ActivateDoc2("sborka", false, 0);

                // get active document
                swDoc = (ModelDoc2)swApp.ActiveDoc;

                // get assembly object
                swAsm = (AssemblyDoc)swDoc;

                // get first feature in the doc
                feature = swDoc.FirstFeature();

                List<string> featureNames = new List<string>();

                while (feature != null)
                {
                    featureNames.Add("Feature: " + feature.GetTypeName2());
                    if (feature.GetTypeName2() == "MateGroup")
                    {
                        // get first sub feature in the mate group
                        subFeature = feature.GetFirstSubFeature();

                        // for all sub features get all dimesions
                        while (subFeature != null)
                        {
                            featureNames.Add("-> SubFeature: " + subFeature.GetTypeName2());

                            displayDimension = subFeature.GetFirstDisplayDimension();

                            // for all display dimensions show their dimension
                            while (displayDimension != null)
                            {
                                dimension = displayDimension.GetDimension2(0);
                                displayDimension = subFeature.GetNextDisplayDimension(displayDimension);
                            }

                            subFeature = subFeature.GetNextSubFeature();
                        }
                    } else
                    {
                        subFeature = feature.GetFirstSubFeature();

                        while (subFeature != null)
                        {
                            featureNames.Add("-> SubFeature: " + subFeature.GetTypeName2());

                            subFeature = subFeature.GetNextSubFeature();
                        }
                    }
                    feature = feature.GetNextFeature();
                }
                this.textBox.AppendText("\n====== Start ======\n");
                this.textBox.AppendText("File path: " + fileName + "\n");
                this.textBox.AppendText(String.Join("\n", featureNames));
                this.textBox.AppendText("\n====== End ======\n");
            }

            swApp.ExitApp();
        }
    }
     
}
