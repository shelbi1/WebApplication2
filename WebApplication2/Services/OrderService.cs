using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels;
using WebApplication2.Models.ViewModels.OrderViewModels; 

namespace WebApplication2.Services
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(GetByIdOrderViewModel orderModel);
        bool Save(CreateOrderViewModel order);
        bool Edit(EditOrderViewModel orderModel);
        bool Delete(DeleteOrderViewModel orderModel);
        List<Order> GetOrdersByCreator(GetOrdersByCreator orderModel);
    }

    public class OrderService : IOrderService
    {
        private readonly OrderDbContext _context;

        public OrderService(OrderDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAll()
        {
            return _context.CurrentOrders.ToList();
        }

        public Order GetById(GetByIdOrderViewModel orderModel)
        {
            return _context.CurrentOrders.First(l => l.Id == orderModel.Id);
        }

        public bool Save(CreateOrderViewModel orderModel)
        {
            try
            {
                var order = new Order() { Name = orderModel.Name, CreatedBy = orderModel.CreatedBy } ;
                _context.CurrentOrders.Add(order);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(EditOrderViewModel orderModel)
        {
            try
            {
                var order = new Order() { Id = orderModel.Id, Name = orderModel.Name, CreatedBy = orderModel.CreatedBy };
                var entity = _context.CurrentOrders.First(l => l.Id == order.Id);
                _context.CurrentOrders.Remove(entity);
                _context.CurrentOrders.Add(order);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool Delete(DeleteOrderViewModel orderModel)
        {
            try
            {
                var entity = _context.CurrentOrders.First(l => l.Id == orderModel.Id);
                _context.CurrentOrders.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Order> GetOrdersByCreator(GetOrdersByCreator orderModel)
        {
            // лямбда выражение, находятся делегаты
            return _context.CurrentOrders.Where(order => order.CreatedBy == orderModel.CreatorId).ToList(); 
        }
    }
}
