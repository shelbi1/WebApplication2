using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.ViewModels
{
    /// <summary>
    /// Передать данные с представления в модель  
    /// Сущность, что хранит в себе данные с клиента, соответсвует с таблицей. Контейнер.
    /// Если хотим изменить какие-то поля - отправлять поля, что будут изменены
    /// Для каждого контроллера своя ViewModel
    /// </summary>  

    public class CreateOrderViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
