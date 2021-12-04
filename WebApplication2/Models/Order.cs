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
        public string Topic { get; set; }                    // Тема 
        public int Difficuilty { get; set; }                 // Сложность
        public int Deadline { get; set; }                    // Срок выполнения 
        public int DateOfCreation { get; set; }              // Дата создания
        public OrderStatus Status;                           // Статус заказа
        public Guid CreatedBy { get; set; }                  // Принадлежность заказа
        public Guid TakenBy { get; set; }                    // Кто взял заказ 

        /*
        проверить редактирование, удаление у order, user. 
        выбрать что делать на клиенте? 
            почитать про JavaScript React, Angular, Vue - три самых популярных способа для клиента 
            1 - библиотеки, 2, 3 - frameworks.

        сделать пару страничек чтобы познакомиться 

        Гайд: Знакомимся с реактом, посмотреть как работает. Сделать пару тестовых по гайду. 
        Потом к проекту делать странички. 
            
        */

        /*
        внешние ключи в entity framework 
        посмотреть какие способы есть для организации и разобрать какой легче Guid/User 
        есть специальное расширение с помощью которого можно в entity framework 
        загружать связнные данные из других таблиц.
        метод include.entity framework core 
        */
    }
}
