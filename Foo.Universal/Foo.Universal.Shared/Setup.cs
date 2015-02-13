using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsCommon.Platform;
using Windows.UI.Xaml.Controls;

namespace Foo.Universal
{
    public class Setup : MvxWindowsSetup
    {
        public static bool SetupDone { get; private set; }

        public static void DoSetup(Frame rootFrame)
        {
            var setup = new Setup(rootFrame);
            setup.Initialize();
            SetupDone = true;
        }

        private Setup(Frame rootFrame)
            : base(rootFrame, "AppFrame")   // ONLY when providing a suspensionManagerStateKey the suspension manager is properly intialised for handling suspend/resume
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}