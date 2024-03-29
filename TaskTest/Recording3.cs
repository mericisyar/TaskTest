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
    ///The Recording3 recording.
    /// </summary>
    [TestModule("d0867248-1711-4531-a80e-75e6cc27bf41", ModuleType.Recording, 1)]
    public partial class Recording3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TaskTestRepository repository.
        /// </summary>
        public static TaskTestRepository repo = TaskTestRepository.Instance;

        static Recording3 instance = new Recording3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording3()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording3 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.UEyeOl' at 10;3.", repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.UEyeOlInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.UEyeOl.Click("10;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.DivTagEPostaAdresiIleUeyeOl' at 104;70.", repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.DivTagEPostaAdresiIleUeyeOlInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.DivTagEPostaAdresiIleUeyeOl.Click("104;70");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test ' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("test ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '     ' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("     ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'er' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("er");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' jg hg h' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press(" jg hg h");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 19}043 3 43 ' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("{Back 19}043 3 43 ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 15}' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("{Back 15}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.GirişYap' at 44;6.", repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.GirişYapInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.DivTag3GsvdTmLmWtmWX3ZOLPHU6FalseFals1.GirişYap.Click("44;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtUserName' at 99;28.", repo.ApplicationUnderTest.TxtUserNameInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.TxtUserName.Click("99;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'asdf' with focus on 'ApplicationUnderTest.TxtUserName'.", repo.ApplicationUnderTest.TxtUserNameInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.TxtUserName.PressKeys("asdf");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' ' with focus on 'ApplicationUnderTest.TxtUserName'.", repo.ApplicationUnderTest.TxtUserNameInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.TxtUserName.PressKeys(" ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 10}' with focus on 'ApplicationUnderTest.TxtUserName'.", repo.ApplicationUnderTest.TxtUserNameInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.TxtUserName.PressKeys("{Back 10}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
