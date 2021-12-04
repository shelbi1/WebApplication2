using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/*
    Пользователь: заказчик(1), исполнитель(2). 
    Зарегистрироваться, удалиться, обновить профиль, отредактировать заказ.  
    Имя, количество заказов (оформленных либо выполненных), контактная информация, оценка профиля.
    Профиль и страница регистрации и входа. 
    
    (1) Создание, удаление, проверка, редактирование заказа
    (2) Принять, завершить заказ 

    Заказ: состояние заказа (открытый, взят, закончен), кто его создал, взял, время,   
    список заказов и пользователей (по идентификатору) 
 */

namespace WebApplication2.Models
{
    [Table("CurrentUsers")]
    public class User
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();
        public string Nickname { get; set; }
        /*
        public UserType Type { customer, performer }
        public int Rating { get; set; }
        public int RegistrationDate { get; set; }
        public bool IsOnline { get; set; }
        public int Contacts { get; set; }
        */
    }
}
