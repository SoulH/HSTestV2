using HSTestV2.ViewModels;

namespace HSTestV2.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public LoginViewModel Login { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
            Login = new LoginViewModel();
        }
    }
}
