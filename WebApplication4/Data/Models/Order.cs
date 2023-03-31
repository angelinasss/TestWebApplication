using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Data.Models
{
    public class Order
    {

        [BindNever] public int id { get; set; }


        
        [Display(Name = "Введите имя")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType (DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина номера не менее 10 символов")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина email не менее 15 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetails> orderDetails { get; set; }
    }
}
