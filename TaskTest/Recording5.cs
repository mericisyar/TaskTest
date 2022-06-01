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

namespace TaskTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording5 recording.
    /// </summary>
    [TestModule("68589d7b-4ce4-4fd2-916d-04f4290fb857", ModuleType.Recording, 1)]
    public partial class Recording5 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TaskTestRepository repository.
        /// </summary>
        public static TaskTestRepository repo = TaskTestRepository.Instance;

        static Recording5 instance = new Recording5();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording5()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording5 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.GirişYap' at 35;11.", repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.GirişYapInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.GirişYap.Click("35;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtUserName' at 87;35.", repo.ApplicationUnderTest.TxtUserNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtUserName.Click("87;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'testtuser' with focus on 'ApplicationUnderTest.TxtUserName'.", repo.ApplicationUnderTest.TxtUserNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtUserName.PressKeys("testtuser");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r15{LControlKey down}{RMenu down}{Qkey}{LControlKey up}{RMenu up}{LControlKey up}gmail.com' with focus on 'ApplicationUnderTest.TxtUserName'.", repo.ApplicationUnderTest.TxtUserNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.TxtUserName.PressKeys("r15{LControlKey down}{RMenu down}{Qkey}{LControlKey up}{RMenu up}{LControlKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnLogin' at 170;29.", repo.ApplicationUnderTest.BtnLoginInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.BtnLogin.Click("170;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtPassword' at 119;35.", repo.ApplicationUnderTest.TxtPasswordInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TxtPassword.Click("119;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Testtuserr15.' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("Testtuserr15.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnEmailSelect' at 149;25.", repo.ApplicationUnderTest.BtnEmailSelectInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.BtnEmailSelect.Click("149;25");
            Delay.Milliseconds(1460);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın' at 187;16.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(8));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.Click("187;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(9));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'https{RShiftKey down}:{RShiftKey up}{RShiftKey down}//{RShiftKey up}www.' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(10));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("https{RShiftKey down}:{RShiftKey up}{RShiftKey down}//{RShiftKey up}www.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hepsiburada.com' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(11));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("hepsiburada.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{RShiftKey down}/{RShiftKey up}darksent' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(12));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("{RShiftKey down}/{RShiftKey up}darksent");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-ahsap-kus-evi-yuvas' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(13));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("-ahsap-kus-evi-yuvas");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'i' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(14));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("i");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-14x13x17cm-p-HBCV{Capital}000028{Capital}C{Capital}5{Capital}N{Capital}9' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(15));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("-14x13x17cm-p-HBCV{Capital}000028{Capital}C{Capital}5{Capital}N{Capital}9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın'.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(16));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş1.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("{Return}");
            Delay.Milliseconds(1380);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1362;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(17));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1362;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1362;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(18));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1362;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1362;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(19));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1362;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1362;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(20));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1362;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1362;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(21));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1362;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.CustomerAccountLike2wPzH' at 16;13.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.CustomerAccountLike2wPzHInfo, new RecordItemIndex(22));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.CustomerAccountLike2wPzH.Click("16;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(23));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(24));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(25));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.ProductName' at 296;30.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.ProductNameInfo, new RecordItemIndex(26));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.ProductName.Click("296;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(27));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(28));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(29));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(30));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1359;5.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(31));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1359;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccount' at 132;23.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccountInfo, new RecordItemIndex(32));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccount.Click("132;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.Beğendiklerim' at 83;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.BeğendiklerimInfo, new RecordItemIndex(33));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.Beğendiklerim.Click("83;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.Beğendiklerim' at 60;7.", repo.ListemHepsiburada.MyListMain.BeğendiklerimInfo, new RecordItemIndex(34));
            repo.ListemHepsiburada.MyListMain.Beğendiklerim.Click("60;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.Duezenle' at 74;19.", repo.ListemHepsiburada.MyListMain.DuezenleInfo, new RecordItemIndex(35));
            repo.ListemHepsiburada.MyListMain.Duezenle.Click("74;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.Radio' at 8;9.", repo.ListemHepsiburada.MyListMain.RadioInfo, new RecordItemIndex(36));
            repo.ListemHepsiburada.MyListMain.Radio.Click("8;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.UEruenSecildi' at 53;11.", repo.ListemHepsiburada.MyListMain.UEruenSecildiInfo, new RecordItemIndex(37));
            repo.ListemHepsiburada.MyListMain.UEruenSecildi.Click("53;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.StickActionHeaderRemoveSelected' at 28;20.", repo.ListemHepsiburada.MyListMain.StickActionHeaderRemoveSelectedInfo, new RecordItemIndex(38));
            repo.ListemHepsiburada.MyListMain.StickActionHeaderRemoveSelected.Click("28;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.DeleteConfirmationModalTitle' at 152;22.", repo.ListemHepsiburada.DeleteConfirmationModalTitleInfo, new RecordItemIndex(39));
            repo.ListemHepsiburada.DeleteConfirmationModalTitle.Click("152;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.DeleteConfirmationModalActionButton' at 55;22.", repo.ListemHepsiburada.DeleteConfirmationModalActionButtonInfo, new RecordItemIndex(40));
            repo.ListemHepsiburada.DeleteConfirmationModalActionButton.Click("55;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.Beğendiklerim1' at 74;9.", repo.ListemHepsiburada.MyListMain.Beğendiklerim1Info, new RecordItemIndex(41));
            repo.ListemHepsiburada.MyListMain.Beğendiklerim1.Click("74;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.SpanTagTU' at 26;18.", repo.ListemHepsiburada.MyListMain.SpanTagTUInfo, new RecordItemIndex(42));
            repo.ListemHepsiburada.MyListMain.SpanTagTU.Click("26;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListemHepsiburada.MyListMain.CıkışYap' at 40;6.", repo.ListemHepsiburada.MyListMain.CıkışYapInfo, new RecordItemIndex(43));
            repo.ListemHepsiburada.MyListMain.CıkışYap.Click("40;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccount' at 32;27.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccountInfo, new RecordItemIndex(44));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccount.Click("32;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccount' at 32;27.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccountInfo, new RecordItemIndex(45));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.MyAccount.Click("32;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.Login' at 42;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.LoginInfo, new RecordItemIndex(46));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.Login.Click("42;3");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}