using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AtriyaMVC.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "این فیلد اجباریست")]
        [MaxLength(100,ErrorMessage = "حداکثر کاراکتر 100 است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        [EmailAddress (ErrorMessage = "ایمیله این آخه گوساله")]
        public string Email { get; set; }
        public int Services { get; set; }
        public string Message { get; set; }
        public SelectList ServiceList { get; set; }
    }
}