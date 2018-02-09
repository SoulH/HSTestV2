using Xamarin.Forms;

[assembly: Dependency(typeof(HSTestV2.Droid.Implementations.CloseApplicationAndroidPlatform))]
namespace HSTestV2.Droid.Implementations
{
    using HSTestV2.Interfaces;

    public class CloseApplicationAndroidPlatform : ICloseApplicationPlatform
    {
        public void Close()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}