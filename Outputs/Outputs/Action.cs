﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.IO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Outputs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Action recording.
    /// </summary>
    [TestModule("9df6686f-c575-44a6-ab86-47374c0b21dd", ModuleType.Recording, 1)]
    public partial class Action : ITestModule
    {
        /// <summary>
        /// Holds an instance of the OutputsRepository repository.
        /// </summary>
        public static OutputsRepository repo = OutputsRepository.Instance;

        static Action instance = new Action();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Action()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Action Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 500;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();


            if (File.Exists("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\statistic.STA"))
                File.Delete("\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\statistic.STA");

            if (File.Exists("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\report.STA"))
                File.Delete("\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\report.STA");

            if (File.Exists("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\print.PRT"))
                File.Delete("\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\print.PRT");

            if (File.Exists("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\export.sta"))
                File.Delete("\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\export.sta");

            if (File.Exists("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\datastream.dat"))
                File.Delete("\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\datastream.dat");

            //if (File.Exists("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\excel.xls"))
            //    File.Delete("\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\excel.xls");


            // Click somewhere in the TitleBar to get a focus on all options in the Menu Bar
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 527;9.", repo.SnapXUntitled.Element94Info, new RecordItemIndex(0));
            repo.SnapXUntitled.Element94.Click("527;9");
            Delay.Milliseconds(200);

            // "Alt" Button
            Report.Log(ReportLevel.Info, "Keyboard", "\"Alt\" Button\r\nKey sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(100);

            // "F" Button
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(2));
            Keyboard.Press("f");
            Delay.Milliseconds(100);

            // "O" Button
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(3));
            Keyboard.Press("o");
            Delay.Milliseconds(3000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OpenSnapXRoutine.Text1148' at 203;5.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(4));
            repo.OpenSnapXRoutine.Text1148.DoubleClick("203;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'OpenSnapXRoutine.Text1148'.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(5));
            repo.OpenSnapXRoutine.Text1148.PressKeys("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Routine\\AllOutputTypes.mxy'.", new RecordItemIndex(6));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Routine\\AllOutputTypes.mxy");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'OpenSnapXRoutine.Text1148'.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(7));
            repo.OpenSnapXRoutine.Text1148.PressKeys("{Return}");
            Delay.Milliseconds(100);

            // Click somewhere in the TitleBar to get a focus on all options in the Menu Bar
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 527;9.", repo.SnapXUntitled.Element94Info, new RecordItemIndex(0));
            repo.SnapXUntitled.Element94.Click("527;9");
            Delay.Milliseconds(200);

            // "Alt" Button
            Report.Log(ReportLevel.Info, "Keyboard", "\"Alt\" Button\r\nKey sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(100);

            // "F" Button
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(2));
            Keyboard.Press("f");
            Delay.Milliseconds(100);

            // "R" Button
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(11));
            Keyboard.Press("r");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonOK' at Center.", repo.SnapXUntitled.ButtonOKInfo, new RecordItemIndex(12));
            repo.SnapXUntitled.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(13));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(14));
            repo.SnapXUntitled.Finish.Click();
            Delay.Milliseconds(200);

            // "Alt" Button
            Report.Log(ReportLevel.Info, "Keyboard", "\"Alt\" Button\r\nKey sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);

            // "F" Button
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(2));
            Keyboard.Press("f");
            Delay.Milliseconds(0);

            // "N" Button
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(11));
            Keyboard.Press("n");
            Delay.Milliseconds(0);
            
            

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(16));
            Delay.Duration(2000, false);

            string ActualStatisticValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\statistic.STA";
            string HardcodedStatisticValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\HardcodedStatistic.STA";
            ComparingValues.Results(ActualStatisticValuesPath, HardcodedStatisticValuesPath);

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);

            string ActualReportValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\report.STA";
            string HardcodedReportValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\HardcodedReport.STA";
            ComparingValues.Results(ActualReportValuesPath, HardcodedReportValuesPath);

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);

            string ActualPrinttValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\print.PRT";
            string HardcodedPrintValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\HardcodedPrint.PRT";
            ComparingValues.Results(ActualPrinttValuesPath, HardcodedPrintValuesPath);

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);

            string ActualExportValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\export.sta";
            string HardcodedExportValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\HardcodedExport.sta";
            ComparingValues.Results(ActualExportValuesPath, HardcodedExportValuesPath);

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);

            string ActualDatastreamValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\datastream.dat";
            string HardcodedDatastreamValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\HardcodedDatastream.dat";
            ComparingValues.Results(ActualDatastreamValuesPath, HardcodedDatastreamValuesPath);

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);

            string ActualExcelValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\excel.xls";
            string HardcodedExcelValuesPath = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationOutputs\\Reports\\HardcodedExcel.xls";
            ComparingValues.Results(ActualExcelValuesPath, HardcodedExcelValuesPath);

            Thread.Sleep(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonGo' at 54;150.", repo.SnapXUntitled.ButtonGoInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.ButtonGo.Click("54;150");
            Delay.Milliseconds(200);
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
