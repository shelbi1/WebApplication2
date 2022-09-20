using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels.UserViewModel;

namespace WebApplication2.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(GetByIdUser userModel);
        bool Create(CreateUserViewModel userModel);
        bool Edit(EditUserViewModel userModel);
        bool Delete(DeleteUserViewModel userModel);
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

        public User GetById(GetByIdUser userModel)
        {
            return _context.CurrentUsers.First(l => l.Id == userModel.Id);
        }

        public bool Create(CreateUserViewModel userModel)
        {
            try
            {
                var user = new User() { Nickname = userModel.Nickname, Type = userModel.Type };
                _context.CurrentUsers.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(EditUserViewModel userModel)
        {
            try
            {
                var user = new User() { Id = userModel.Id, Nickname = userModel.Nickname, Type = userModel.Type };
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

        public bool Delete(DeleteUserViewModel userModel)
        {
            try
            {
                var entity = _context.CurrentUsers.First(l => l.Id == userModel.Id);
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
