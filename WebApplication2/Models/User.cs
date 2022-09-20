using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    [Table("CurrentUsers")]
    public class User
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();
        public string Nickname { get; set; }
        public UserType Type { get; set; }
        private readonly Authority[] _authority; 
        public Authority[] Authority 
        { 
            get => _authority; 
            set
            { 
            switch (Type)
            {
                case UserType.Administrator:
                    {
                        this.Authority[0] = Models.Authority.AddOrder;
                        this.Authority[1] = Models.Authority.TakeOrder;
                        this.Authority[2] = Models.Authority.DeleteOrder;
                        this.Authority[3] = Models.Authority.GetAllOrders;
                        this.Authority[4] = Models.Authority.GetOrdersByCreator;
                        this.Authority[5] = Models.Authority.EditOrder;

                        this.Authority[6] = Models.Authority.DeleteUser;
                        this.Authority[7] = Models.Authority.GetAllUsers;
                        this.Authority[8] = Models.Authority.EditUser;
                        this.Authority[9] = Models.Authority.CreateUser;
                        break;
                    }
                case UserType.Customer:
                    {
                        this.Authority[0] = Models.Authority.AddOrder;
                        this.Authority[1] = Models.Authority.DeleteOrder;
                        this.Authority[2] = Models.Authority.GetAllOrders;
                        this.Authority[3] = Models.Authority.GetOrdersByCreator;
                        this.Authority[4] = Models.Authority.EditOrder;

                        this.Authority[5] = Models.Authority.EditUser;
                        this.Authority[6] = Models.Authority.CreateUser;
                        break;
                    }
                case UserType.Performer:
                    {
                        this.Authority[0] = Models.Authority.TakeOrder;
                        this.Authority[1] = Models.Authority.GetAllOrders;
                        this.Authority[2] = Models.Authority.GetOrdersByCreator;
                        this.Authority[3] = Models.Authority.EditUser;
                        this.Authority[4] = Models.Authority.CreateUser;
                        break;
                    }
                case UserType.Guest:
                    {
                        this.Authority[0] = Models.Authority.GetAllOrders;
                        this.Authority[1] = Models.Authority.GetOrdersByCreator;
                        this.Authority[2] = Models.Authority.CreateUser;
                        break;
                    }
            }
            }
        }

    }
}
