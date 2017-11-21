using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityIsolation.CrossCutting.Idenity.Models
{
    public class ApplicationUser : IdentityUser
    {
        
    }

    //public class User : ApplicationUser
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }

    //    public int MyProperty { get; set; }
    //}
}
