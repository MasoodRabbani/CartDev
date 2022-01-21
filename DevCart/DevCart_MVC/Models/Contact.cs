using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCart_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد نمیتواند خالی باشد.")]
        [MaxLength(10,ErrorMessage = "حداقل  100 کاراکتر باشد")]
        [MinLength(3,ErrorMessage = "حداکثر 3 کاراکتر باید باشد.")]
        [Display(Name = "نام")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل صحیح نیست.!")]
        [Required(ErrorMessage = "این فیلد نمیتواند خالی باشد.")]
        public string Email { get; set; }
        public string Services { get; set; }
        public string Text { get; set; }
    }
}
