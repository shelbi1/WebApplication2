using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels.UserViewModel
{
    public class EditUserViewModel
    {
        public Guid Id { get; set; }
        public string Nickname { get; set; }
        public UserType Type { get; set; }
    }
}
