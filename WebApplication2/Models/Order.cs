using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    [Table("CurrentOrders")]
    public class Order
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid(); // Идентификатор (ключ) заказа 
        public string Name { get; set; }                     // Название текста
        public OrderStatus Status { get; set; }              // Статус заказа
        public Guid CreatedBy { get; set; }                  // Принадлежность заказа
        public Guid TakenBy { get; set; }                    // Кто взял заказ 
    }
}
