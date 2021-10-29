using System;
using System.Collections.Generic;
using System.Text;

namespace Syracuse.Mobitheque.Core.Models
{
    public class AccountWebFrameOptions
    {
        public string category { get; set; } = "Profile";
        public int portalId { get; set; } = 8;
        public object providerCode { get; set; } = null;
    }
}
