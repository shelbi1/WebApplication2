using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.ViewModels
{
    public class EditOrderViewModel
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
