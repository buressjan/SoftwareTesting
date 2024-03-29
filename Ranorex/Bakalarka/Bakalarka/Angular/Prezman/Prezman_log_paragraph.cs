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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Bakalarka.Angular.Prezman
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Prezman_log_paragraph recording.
    /// </summary>
    [TestModule("db4cd42b-a651-4d41-a192-0be436e2740b", ModuleType.Recording, 1)]
    public partial class Prezman_log_paragraph : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Bakalarka.BakalarkaRepository repository.
        /// </summary>
        public static global::Bakalarka.BakalarkaRepository repo = global::Bakalarka.BakalarkaRepository.Instance;

        static Prezman_log_paragraph instance = new Prezman_log_paragraph();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Prezman_log_paragraph()
        {
            Paragraph = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Prezman_log_paragraph Instance
        {
            get { return instance; }
        }

#region Variables

        string _Paragraph;

        /// <summary>
        /// Gets or sets the value of variable Paragraph.
        /// </summary>
        [TestVariable("688abf6e-5f6d-40f6-b649-7ed63b813747")]
        public string Paragraph
        {
            get { return _Paragraph; }
            set { _Paragraph = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'Prezman.ParagraphToLog'.", repo.Prezman.ParagraphToLogInfo, new RecordItemIndex(0));
            repo.Prezman.ParagraphToLog.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'Prezman.ParagraphToLog' and assigning its value to variable 'Paragraph'.", repo.Prezman.ParagraphToLogInfo, new RecordItemIndex(1));
            Paragraph = repo.Prezman.ParagraphToLog.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Paragraph, new RecordItemIndex(2));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
