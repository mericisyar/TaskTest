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
    ///The Recording6 recording.
    /// </summary>
    [TestModule("e349d139-2d28-4221-adf4-2f0eb7faf872", ModuleType.Recording, 1)]
    public partial class Recording6 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TaskTestRepository repository.
        /// </summary>
        public static TaskTestRepository repo = TaskTestRepository.Instance;

        static Recording6 instance = new Recording6();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording6()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording6 Instance
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
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş' at 1359;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SelfInfo, new RecordItemIndex(17));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.Self.Click("1359;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş' at 1359;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SelfInfo, new RecordItemIndex(18));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.Self.Click("1359;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş' at 1359;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SelfInfo, new RecordItemIndex(19));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.Self.Click("1359;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.AddToCart' at 73;29.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.AddToCartInfo, new RecordItemIndex(20));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.AddToCart.Click("73;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1358;6.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(21));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1358;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1358;6.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(22));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1358;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1358;6.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(23));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1358;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1360;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(24));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1360;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1360;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(25));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1360;3");
            Delay.Milliseconds(6700);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın' at 597;14.", repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(26));
            repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın.Click("597;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'https{RShiftKey down}://{RShiftKey up}www.hepsiburada.com{RShiftKey down}/{RShiftKey up}deger' with focus on 'DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın'.", repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(27));
            repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("https{RShiftKey down}://{RShiftKey up}www.hepsiburada.com{RShiftKey down}/{RShiftKey up}deger");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'li-hobi-ahsap-kus-yuvasi' with focus on 'DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın'.", repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(28));
            repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("li-hobi-ahsap-kus-yuvasi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-dis-mekan-suya-dayanikli-p-hbcv00001xth1m' with focus on 'DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın'.", repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(29));
            repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("-dis-mekan-suya-dayanikli-p-hbcv00001xth1m");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın'.", repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazınInfo, new RecordItemIndex(30));
            repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GoogleIleAramaYapınVeyaAdresYazın.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.ProductName' at 320;33.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.ProductNameInfo, new RecordItemIndex(31));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.ProductName.Click("320;33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1360;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(32));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1360;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1360;627.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(33));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1360;627");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.AddToCart' at 80;26.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.AddToCartInfo, new RecordItemIndex(34));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.AddToCart.Click("80;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1361;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(35));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1361;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1361;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(36));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1361;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1361;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(37));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1361;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag' at 1361;3.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTagInfo, new RecordItemIndex(38));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.SomeIFrameTag.Click("1361;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TuerkiyeninEnBueyuekOnlineAlışveriş.ShoppingCart' at 26;14.", repo.TuerkiyeninEnBueyuekOnlineAlışveriş.ShoppingCartInfo, new RecordItemIndex(39));
            repo.TuerkiyeninEnBueyuekOnlineAlışveriş.ShoppingCart.Click("26;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SidebarContent1fiE.SECİLENUERUENLER2' at 85;5.", repo.Sepetim.SidebarContent1fiE.SECİLENUERUENLER2Info, new RecordItemIndex(40));
            repo.Sepetim.SidebarContent1fiE.SECİLENUERUENLER2.Click("85;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SidebarContent1fiE.Kargo' at 21;9.", repo.Sepetim.SidebarContent1fiE.KargoInfo, new RecordItemIndex(41));
            repo.Sepetim.SidebarContent1fiE.Kargo.Click("21;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.ContinueStepBtn' at 57;22.", repo.Sepetim.ContinueStepBtnInfo, new RecordItemIndex(42));
            repo.Sepetim.ContinueStepBtn.Click("57;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.BreadCrumb1ugPj.Teslimat' at 57;13.", repo.Sepetim.BreadCrumb1ugPj.TeslimatInfo, new RecordItemIndex(43));
            repo.Sepetim.BreadCrumb1ugPj.Teslimat.Click("57;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.BreadCrumb1ugPj.OEdeme' at 37;15.", repo.Sepetim.BreadCrumb1ugPj.OEdemeInfo, new RecordItemIndex(44));
            repo.Sepetim.BreadCrumb1ugPj.OEdeme.Click("37;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.BreadCrumb1ugPj.OEzet' at 42;18.", repo.Sepetim.BreadCrumb1ugPj.OEzetInfo, new RecordItemIndex(45));
            repo.Sepetim.BreadCrumb1ugPj.OEzet.Click("42;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DarkSentAhşapKuşEviYuvası14x13x17cm.Geri' at 28;24.", repo.DarkSentAhşapKuşEviYuvası14x13x17cm.GeriInfo, new RecordItemIndex(46));
            repo.DarkSentAhşapKuşEviYuvası14x13x17cm.Geri.Click("28;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SidebarContent1fiE.SECİLENUERUENLER2' at 77;6.", repo.Sepetim.SidebarContent1fiE.SECİLENUERUENLER2Info, new RecordItemIndex(47));
            repo.Sepetim.SidebarContent1fiE.SECİLENUERUENLER2.Click("77;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SecilenleriSil2' at 52;5.", repo.Sepetim.SecilenleriSil2Info, new RecordItemIndex(48));
            repo.Sepetim.SecilenleriSil2.Click("52;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SeciliUeruenleriSilmekUezeresiniz' at 200;21.", repo.Sepetim.SeciliUeruenleriSilmekUezeresinizInfo, new RecordItemIndex(49));
            repo.Sepetim.SeciliUeruenleriSilmekUezeresiniz.Click("200;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.ButtonTagSil' at 82;22.", repo.Sepetim.ButtonTagSilInfo, new RecordItemIndex(50));
            repo.Sepetim.ButtonTagSil.Click("82;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SepetinŞuAnBoş' at 605;26.", repo.Sepetim.SepetinŞuAnBoşInfo, new RecordItemIndex(51));
            repo.Sepetim.SepetinŞuAnBoş.Click("605;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SpanTagTU' at 29;22.", repo.Sepetim.SpanTagTUInfo, new RecordItemIndex(52));
            repo.Sepetim.SpanTagTU.Click("29;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.CıkışYap' at 41;10.", repo.Sepetim.CıkışYapInfo, new RecordItemIndex(53));
            repo.Sepetim.CıkışYap.Click("41;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SepetinŞuAnBoş' at 570;24.", repo.Sepetim.SepetinŞuAnBoşInfo, new RecordItemIndex(54));
            repo.Sepetim.SepetinŞuAnBoş.Click("570;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SepetinŞuAnBoş' at 650;23.", repo.Sepetim.SepetinŞuAnBoşInfo, new RecordItemIndex(55));
            repo.Sepetim.SepetinŞuAnBoş.Click("650;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.SfAccount3m2O' at 12;11.", repo.Sepetim.SfAccount3m2OInfo, new RecordItemIndex(56));
            repo.Sepetim.SfAccount3m2O.Click("12;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Sepetim.GirişYap' at 62;21.", repo.Sepetim.GirişYapInfo, new RecordItemIndex(57));
            repo.Sepetim.GirişYap.Click("62;21");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}