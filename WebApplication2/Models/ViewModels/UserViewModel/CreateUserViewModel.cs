using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.UserViewModel
{
    public class CreateUserViewModel
    {
        public string Nickname { get; set; }
        public UserType Type { get; set; }
    }
}
