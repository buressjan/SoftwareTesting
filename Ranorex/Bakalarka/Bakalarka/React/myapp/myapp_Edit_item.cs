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

namespace Bakalarka.React.myapp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The myapp_Edit_item recording.
    /// </summary>
    [TestModule("2213d955-e0ed-4403-ace0-3671740f4da1", ModuleType.Recording, 1)]
    public partial class Myapp_Edit_item : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Bakalarka.BakalarkaRepository repository.
        /// </summary>
        public static global::Bakalarka.BakalarkaRepository repo = global::Bakalarka.BakalarkaRepository.Instance;

        static Myapp_Edit_item instance = new Myapp_Edit_item();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Myapp_Edit_item()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Myapp_Edit_item Instance
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

            // Go to edit mode
            Report.Log(ReportLevel.Info, "Section", "Go to edit mode", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ReactApp.Root.EditButton'.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(1));
            repo.ReactApp.Root.EditButton.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.EditButton' at Center.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(2));
            repo.ReactApp.Root.EditButton.Click();
            Delay.Milliseconds(0);
            
            // Edit item name and description
            Report.Log(ReportLevel.Info, "Section", "Edit item name and description", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ReactApp.Root.ItemName'.", repo.ReactApp.Root.ItemNameInfo, new RecordItemIndex(4));
            repo.ReactApp.Root.ItemName.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.ItemName' at Center.", repo.ReactApp.Root.ItemNameInfo, new RecordItemIndex(5));
            repo.ReactApp.Root.ItemName.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'AAA' on item 'ReactApp.Root.ItemName'.", repo.ReactApp.Root.ItemNameInfo, new RecordItemIndex(6));
            //repo.ReactApp.Root.ItemName.Element.SetAttributeValue("Value", "AAA");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AAA' with focus on 'ReactApp'.", repo.ReactApp.SelfInfo, new RecordItemIndex(7));
            repo.ReactApp.Self.EnsureVisible();
            Keyboard.Press("AAA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Item' at 74;18.", repo.ReactApp.Root.ItemInfo, new RecordItemIndex(8));
            repo.ReactApp.Root.Item.Click("74;18");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute InnerText to 'BBB' on item 'ReactApp.Root.ItemDescription'.", repo.ReactApp.Root.ItemDescriptionInfo, new RecordItemIndex(9));
            //repo.ReactApp.Root.ItemDescription.Element.SetAttributeValue("InnerText", "BBB");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'BBB' with focus on 'ReactApp'.", repo.ReactApp.SelfInfo, new RecordItemIndex(10));
            repo.ReactApp.Self.EnsureVisible();
            Keyboard.Press("BBB");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "TodoSetEditedItem", null, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}