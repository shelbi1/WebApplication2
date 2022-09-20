using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public enum Authority
    {
        AddOrder,
        TakeOrder,
        DeleteOrder,
        GetAllOrders,
        GetOrdersByCreator, 
        EditOrder,

        DeleteUser,
        GetAllUsers, 
        EditUser,
        CreateUser
    }
}
