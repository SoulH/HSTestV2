using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSTestV2Api.ViewModels
{
    public class UserModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool RememberMe { get; set; }
    }
}