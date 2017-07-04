using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Narcissus.Security.Abstract
{
    public class ClaimsIdentityOptions
    {
        public string RoleClaimType { get; set; } = ClaimTypes.Role;
        public string UserNameClaimType { get; set; } = ClaimTypes.Name;
        public string UserIdClaimType { get; set; } = ClaimTypes.NameIdentifier;
        public string SecurityStampClaimType { get; set; } = "Narcissus.Identity.SecurityStamp";
    }
}
