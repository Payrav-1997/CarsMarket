using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Имя")]
        [StringLength(20)]
        [Required(ErrorMessage ="Имя не указана!")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(20)]
        [Required(ErrorMessage = "Фамилия не указана!")]
        public string surName { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(20)]
        [Required(ErrorMessage = "Укажите адрес!")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона!")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Укажите номер телефона!")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Укажите email!")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public  DateTime  orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }



    }
}
