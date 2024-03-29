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
    ///The Recording_myApp recording.
    /// </summary>
    [TestModule("9d94841b-3d01-4c0a-856c-a0cdf9288db7", ModuleType.Recording, 1)]
    public partial class Recording_myApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Bakalarka.BakalarkaRepository repository.
        /// </summary>
        public static global::Bakalarka.BakalarkaRepository repo = global::Bakalarka.BakalarkaRepository.Instance;

        static Recording_myApp instance = new Recording_myApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording_myApp()
        {
            navbarHome = "Home";
            navbarDropdown = "Mini apps ";
            navbarAbout = "About";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording_myApp Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable navbarHome.
        /// </summary>
        [TestVariable("b806f73b-8211-41fe-87cb-0406a97b2d14")]
        public string navbarHome
        {
            get { return repo.navbarHome; }
            set { repo.navbarHome = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable navbarAbout.
        /// </summary>
        [TestVariable("3fec96a2-1d60-4423-b73e-0521875373d9")]
        public string navbarAbout
        {
            get { return repo.navbarAbout; }
            set { repo.navbarAbout = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable navbarDropdown.
        /// </summary>
        [TestVariable("4f2a6af9-4918-4347-a681-5b01db437e28")]
        public string navbarDropdown
        {
            get { return repo.navbarDropdown; }
            set { repo.navbarDropdown = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.H1TagNHL' at 62;14.", repo.ReactApp.Root.H1TagNHLInfo, new RecordItemIndex(0));
            repo.ReactApp.Root.H1TagNHL.Click("62;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.TheNationalHockeyLeagueNHLFrench' at 147;63.", repo.ReactApp.Root.TheNationalHockeyLeagueNHLFrenchInfo, new RecordItemIndex(1));
            repo.ReactApp.Root.TheNationalHockeyLeagueNHLFrench.Click("147;63");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.REACT' at 83;24.", repo.ReactApp.Root.REACTInfo, new RecordItemIndex(2));
            repo.ReactApp.Root.REACT.Click("83;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Home' at 84;35.", repo.ReactApp.Root.HomeInfo, new RecordItemIndex(3));
            repo.ReactApp.Root.Home.Click("84;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.EmojiPageDropdown' at 147;27.", repo.ReactApp.Root.EmojiPageDropdownInfo, new RecordItemIndex(4));
            repo.ReactApp.Root.EmojiPageDropdown.Click("147;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.EmojiFinder' at 395;37.", repo.ReactApp.Root.EmojiFinderInfo, new RecordItemIndex(5));
            repo.ReactApp.Root.EmojiFinder.Click("395;37");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'happy' with focus on 'ReactApp.Root.EmojiFinder'.", repo.ReactApp.Root.EmojiFinderInfo, new RecordItemIndex(6));
            repo.ReactApp.Root.EmojiFinder.PressKeys("happy");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(7));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(8));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(9));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp' at 1909;281.", repo.ReactApp.SelfInfo, new RecordItemIndex(10));
            repo.ReactApp.Self.MoveTo("1909;281");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp' at 1916;394.", repo.ReactApp.SelfInfo, new RecordItemIndex(11));
            repo.ReactApp.Self.MoveTo("1916;394");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp' at 1907;353.", repo.ReactApp.SelfInfo, new RecordItemIndex(13));
            repo.ReactApp.Self.MoveTo("1907;353");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp' at 1919;167.", repo.ReactApp.SelfInfo, new RecordItemIndex(14));
            repo.ReactApp.Self.MoveTo("1919;167");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Home' at 52;25.", repo.ReactApp.Root.HomeInfo, new RecordItemIndex(15));
            repo.ReactApp.Root.Home.Click("52;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Carousel' at 123;27.", repo.ReactApp.Root.CarouselInfo, new RecordItemIndex(16));
            repo.ReactApp.Root.Carousel.Click("123;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.CarouselNextItem' at 35;24.", repo.ReactApp.Root.CarouselNextItemInfo, new RecordItemIndex(17));
            repo.ReactApp.Root.CarouselNextItem.Click("35;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Carousel4thItem' at 12;8.", repo.ReactApp.Root.Carousel4thItemInfo, new RecordItemIndex(18));
            repo.ReactApp.Root.Carousel4thItem.Click("12;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.ToDo' at 76;24.", repo.ReactApp.Root.ToDoInfo, new RecordItemIndex(19));
            repo.ReactApp.Root.ToDo.Click("76;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Name' at 246;28.", repo.ReactApp.Root.NameInfo, new RecordItemIndex(20));
            repo.ReactApp.Root.Name.Click("246;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'TEst' with focus on 'ReactApp.Root.Name'.", repo.ReactApp.Root.NameInfo, new RecordItemIndex(21));
            repo.ReactApp.Root.Name.PressKeys("TEst");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Description' at 236;20.", repo.ReactApp.Root.DescriptionInfo, new RecordItemIndex(22));
            repo.ReactApp.Root.Description.Click("236;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'New item' with focus on 'ReactApp.Root.Description'.", repo.ReactApp.Root.DescriptionInfo, new RecordItemIndex(23));
            repo.ReactApp.Root.Description.PressKeys("New item");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.AddItem' at 129;17.", repo.ReactApp.Root.AddItemInfo, new RecordItemIndex(24));
            repo.ReactApp.Root.AddItem.Click("129;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.BackFrame' at 41;4.", repo.ReactApp.Root.BackFrameInfo, new RecordItemIndex(25));
            repo.ReactApp.Root.BackFrame.Click("41;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.REACT' at 75;16.", repo.ReactApp.Root.REACTInfo, new RecordItemIndex(26));
            repo.ReactApp.Root.REACT.Click("75;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu down}{Tab}{Tab}{Tab}{LMenu up}'.", new RecordItemIndex(27));
            Keyboard.Press("{LMenu down}{Tab}{Tab}{Tab}{LMenu up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactAppGoogleChrome.Element319895216' at 1899;16.", repo.ReactAppGoogleChrome.Element319895216Info, new RecordItemIndex(28));
            repo.ReactAppGoogleChrome.Element319895216.Click("1899;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactAppGoogleChrome.AdresniAVyhledavaciŘadek' at 224;17.", repo.ReactAppGoogleChrome.AdresniAVyhledavaciŘadekInfo, new RecordItemIndex(29));
            repo.ReactAppGoogleChrome.AdresniAVyhledavaciŘadek.Click("224;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.ComponentEmojiResultRowCopyToClipb' at 167;24.", repo.ReactApp.Root.ComponentEmojiResultRowCopyToClipbInfo, new RecordItemIndex(30));
            repo.ReactApp.Root.ComponentEmojiResultRowCopyToClipb.Click("167;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.ComponentEmojiResultRowCopyToClipb1' at 399;29.", repo.ReactApp.Root.ComponentEmojiResultRowCopyToClipb1Info, new RecordItemIndex(31));
            repo.ReactApp.Root.ComponentEmojiResultRowCopyToClipb1.Click("399;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Footer' at 842;23.", repo.ReactApp.Root.FooterInfo, new RecordItemIndex(32));
            repo.ReactApp.Root.Footer.Click("842;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.EditButton' at 523;9.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(34));
            repo.ReactApp.Root.EditButton.MoveTo("523;9");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp.Root.EditButton' at 523;9.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(35));
            repo.ReactApp.Root.EditButton.MoveTo("523;9");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.ItemName' at 167;15.", repo.ReactApp.Root.ItemNameInfo, new RecordItemIndex(36));
            repo.ReactApp.Root.ItemName.Click("167;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.ItemDescription' at 184;14.", repo.ReactApp.Root.ItemDescriptionInfo, new RecordItemIndex(37));
            repo.ReactApp.Root.ItemDescription.MoveTo("184;14");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.ItemDescription' at 111;61.", repo.ReactApp.Root.ItemDescriptionInfo, new RecordItemIndex(38));
            repo.ReactApp.Root.ItemDescription.Click("111;61");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.EditButton' at 511;16.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(39));
            repo.ReactApp.Root.EditButton.MoveTo("511;16");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.SomeSpanTag' at 710;561.", repo.ReactApp.Root.SomeSpanTagInfo, new RecordItemIndex(40));
            repo.ReactApp.Root.SomeSpanTag.Click("710;561");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.DeleteButton' at 47;16.", repo.ReactApp.Root.DeleteButtonInfo, new RecordItemIndex(41));
            repo.ReactApp.Root.DeleteButton.Click("47;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.EditButton' at 519;10.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(42));
            repo.ReactApp.Root.EditButton.MoveTo("519;10");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.SomeSpanTag' at 726;661.", repo.ReactApp.Root.SomeSpanTagInfo, new RecordItemIndex(43));
            repo.ReactApp.Root.SomeSpanTag.MoveTo("726;661");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp.Root.SomeSpanTag' at 726;661.", repo.ReactApp.Root.SomeSpanTagInfo, new RecordItemIndex(44));
            repo.ReactApp.Root.SomeSpanTag.MoveTo("726;661");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.EditButton' at 527;15.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(45));
            repo.ReactApp.Root.EditButton.Click("527;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Cancel' at 38;14.", repo.ReactApp.Root.CancelInfo, new RecordItemIndex(46));
            repo.ReactApp.Root.Cancel.Click("38;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.CarouselPreviousItem' at 29;42.", repo.ReactApp.Root.CarouselPreviousItemInfo, new RecordItemIndex(47));
            repo.ReactApp.Root.CarouselPreviousItem.Click("29;42");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.SaveChange' at 72;8.", repo.ReactApp.Root.SaveChangeInfo, new RecordItemIndex(48));
            repo.ReactApp.Root.SaveChange.Click("72;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.CheckboxFirst' at 17;19.", repo.ReactApp.Root.CheckboxFirstInfo, new RecordItemIndex(49));
            repo.ReactApp.Root.CheckboxFirst.MoveTo("17;19");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.EditButton' at 525;12.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(50));
            repo.ReactApp.Root.EditButton.MoveTo("525;12");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.SomeSpanTag' at 711;563.", repo.ReactApp.Root.SomeSpanTagInfo, new RecordItemIndex(51));
            repo.ReactApp.Root.SomeSpanTag.Click("711;563");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.EditButton' at 509;8.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(52));
            repo.ReactApp.Root.EditButton.Click("509;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Cancel' at 40;4.", repo.ReactApp.Root.CancelInfo, new RecordItemIndex(53));
            repo.ReactApp.Root.Cancel.Click("40;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.CheckboxFirst' at 18;29.", repo.ReactApp.Root.CheckboxFirstInfo, new RecordItemIndex(54));
            repo.ReactApp.Root.CheckboxFirst.MoveTo("18;29");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp.Root.CheckboxFirst' at 18;29.", repo.ReactApp.Root.CheckboxFirstInfo, new RecordItemIndex(55));
            repo.ReactApp.Root.CheckboxFirst.MoveTo("18;29");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.About' at 53;28.", repo.ReactApp.Root.AboutInfo, new RecordItemIndex(56));
            repo.ReactApp.Root.About.Click("53;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.AuthorJanBures' at 244;19.", repo.ReactApp.Root.AuthorJanBuresInfo, new RecordItemIndex(57));
            repo.ReactApp.Root.AuthorJanBures.Click("244;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Name' at 109;16.", repo.ReactApp.Root.NameInfo, new RecordItemIndex(58));
            repo.ReactApp.Root.Name.Click("109;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'New ' with focus on 'ReactApp.Root.Name'.", repo.ReactApp.Root.NameInfo, new RecordItemIndex(59));
            repo.ReactApp.Root.Name.PressKeys("New ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}{Back}{Back}{Back}{Back}Test' with focus on 'ReactApp.Root.Name'.", repo.ReactApp.Root.NameInfo, new RecordItemIndex(60));
            repo.ReactApp.Root.Name.PressKeys("{Back}{Back}{Back}{Back}{Back}Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Description' at 109;24.", repo.ReactApp.Root.DescriptionInfo, new RecordItemIndex(61));
            repo.ReactApp.Root.Description.Click("109;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'item' with focus on 'ReactApp.Root.Description'.", repo.ReactApp.Root.DescriptionInfo, new RecordItemIndex(62));
            repo.ReactApp.Root.Description.PressKeys("item");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.AddItem' at 97;23.", repo.ReactApp.Root.AddItemInfo, new RecordItemIndex(63));
            repo.ReactApp.Root.AddItem.Click("97;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(64));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.EditButton' at 526;8.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(65));
            repo.ReactApp.Root.EditButton.MoveTo("526;8");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.SomeSpanTag1' at 749;326.", repo.ReactApp.Root.SomeSpanTag1Info, new RecordItemIndex(66));
            repo.ReactApp.Root.SomeSpanTag1.MoveTo("749;326");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp.Root.SomeSpanTag1' at 583;341.", repo.ReactApp.Root.SomeSpanTag1Info, new RecordItemIndex(67));
            repo.ReactApp.Root.SomeSpanTag1.MoveTo("583;341");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AAA' with focus on 'ReactApp'.", repo.ReactApp.SelfInfo, new RecordItemIndex(68));
            repo.ReactApp.Self.EnsureVisible();
            Keyboard.Press("AAA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.Item' at 47;8.", repo.ReactApp.Root.ItemInfo, new RecordItemIndex(69));
            repo.ReactApp.Root.Item.MoveTo("47;8");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp.Root.Item' at -123;29.", repo.ReactApp.Root.ItemInfo, new RecordItemIndex(70));
            repo.ReactApp.Root.Item.MoveTo("-123;29");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'BBB' with focus on 'ReactApp'.", repo.ReactApp.SelfInfo, new RecordItemIndex(71));
            repo.ReactApp.Self.EnsureVisible();
            Keyboard.Press("BBB");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.SaveChange' at 50;11.", repo.ReactApp.Root.SaveChangeInfo, new RecordItemIndex(72));
            repo.ReactApp.Root.SaveChange.Click("50;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.EditButton' at 506;13.", repo.ReactApp.Root.EditButtonInfo, new RecordItemIndex(73));
            repo.ReactApp.Root.EditButton.Click("506;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.ItemName' at 63;19.", repo.ReactApp.Root.ItemNameInfo, new RecordItemIndex(74));
            repo.ReactApp.Root.ItemName.MoveTo("63;19");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp.Root.ItemName' at -109;20.", repo.ReactApp.Root.ItemNameInfo, new RecordItemIndex(75));
            repo.ReactApp.Root.ItemName.MoveTo("-109;20");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'XXX{LShiftKey up}' with focus on 'ReactApp'.", repo.ReactApp.SelfInfo, new RecordItemIndex(76));
            repo.ReactApp.Self.EnsureVisible();
            Keyboard.Press("XXX{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ReactApp.Root.TextAreaTagBBB' at 55;3.", repo.ReactApp.Root.TextAreaTagBBBInfo, new RecordItemIndex(77));
            repo.ReactApp.Root.TextAreaTagBBB.MoveTo("55;3");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ReactApp.Root.TextAreaTagBBB' at -31;17.", repo.ReactApp.Root.TextAreaTagBBBInfo, new RecordItemIndex(78));
            repo.ReactApp.Root.TextAreaTagBBB.MoveTo("-31;17");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'YYY' with focus on 'ReactApp'.", repo.ReactApp.SelfInfo, new RecordItemIndex(79));
            repo.ReactApp.Self.EnsureVisible();
            Keyboard.Press("YYY");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactApp.Root.Cancel' at 11;6.", repo.ReactApp.Root.CancelInfo, new RecordItemIndex(80));
            repo.ReactApp.Root.Cancel.Click("11;6");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
