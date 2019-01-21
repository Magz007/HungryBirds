using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomUserField { get; set; }

        // add custom fields here...
        // e.g. link a user (parent?) to students

    }
}
