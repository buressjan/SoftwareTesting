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
    ///The Prezman_hoverOver_mainImage recording.
    /// </summary>
    [TestModule("9583f4f7-daed-406e-a228-9372da30c405", ModuleType.Recording, 1)]
    public partial class Prezman_hoverOver_mainImage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Bakalarka.BakalarkaRepository repository.
        /// </summary>
        public static global::Bakalarka.BakalarkaRepository repo = global::Bakalarka.BakalarkaRepository.Instance;

        static Prezman_hoverOver_mainImage instance = new Prezman_hoverOver_mainImage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Prezman_hoverOver_mainImage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Prezman_hoverOver_mainImage Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'Prezman.Manual.mainImage' at Center.", repo.Prezman.Manual.mainImageInfo, new RecordItemIndex(0));
            repo.Prezman.Manual.mainImage.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "MainImage", null, false, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}