using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(Guid id);
        bool Save(User user);
        bool Edit(User user);
        bool Delete(Guid Id);
    }

    public class UserService : IUserService
    {
        private readonly UserDbContext _context;

        public UserService(UserDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.CurrentUsers.ToList();
        }

        public User GetById(Guid id)
        {
            return _context.CurrentUsers.First(l => l.Id == id);
        }

        public bool Save(User user)
        {
            try
            {
                _context.CurrentUsers.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(User user)
        {
            try
            {
                var entity = _context.CurrentUsers.First(l => l.Id == user.Id);
                _context.CurrentUsers.Remove(entity);
                _context.CurrentUsers.Add(user);
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
                var entity = _context.CurrentUsers.First(l => l.Id == Id);
                _context.CurrentUsers.Remove(entity);
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
