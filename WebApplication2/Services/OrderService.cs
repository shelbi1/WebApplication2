using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(Guid id);
        bool Save(Order order);
        bool Edit(Order order);
        bool Delete(Guid Id);
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

        public Order GetById(Guid id)
        {
            return _context.CurrentOrders.First(l => l.Id == id);
        }

        public bool Save(Order order)
        {
            try
            {
                _context.CurrentOrders.Add(order);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(Order order)
        {
            try
            {
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

        public bool Delete(Guid Id)
        {
            try
            {
                var entity = _context.CurrentOrders.First(l => l.Id == Id);
                _context.CurrentOrders.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

