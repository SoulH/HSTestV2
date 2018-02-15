using HSTestV2.ViewModels;

namespace HSTestV2.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get { return new MainViewModel(); } }
        public LoginViewModel Login { get { return new LoginViewModel(); } }
        public RegisterViewModel Register { get { return new RegisterViewModel(); } }
    }
}
