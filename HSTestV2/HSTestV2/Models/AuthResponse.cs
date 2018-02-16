using System;
using System.Collections.Generic;
using System.Text;

namespace HSTestV2.Models
{
    class AuthResponse
    {
        public bool Success { get; set; }

        public string Error { get; set; }

        public string Token { get; set; }
    }
}
