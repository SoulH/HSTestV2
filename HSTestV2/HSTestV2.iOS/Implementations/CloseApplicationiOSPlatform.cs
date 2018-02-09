using Xamarin.Forms;

[assembly: Dependency(typeof(HSTestV2.iOS.Implementations.CloseApplicationiOSPlatform))]
namespace HSTestV2.iOS.Implementations
{
    using System.Threading;
    using HSTestV2.Interfaces;

    public class CloseApplicationiOSPlatform : ICloseApplicationPlatform
    {
        public void Close()
        {
            //UIApplication.SharedApplication.PerformSelector(new MonoTouch.ObjCRuntime.Selector("terminateWithSuccess"),null,0f);
            Thread.CurrentThread.Abort();
        }
    }
}