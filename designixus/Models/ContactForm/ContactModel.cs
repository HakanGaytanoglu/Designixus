using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace designixus.Models.ContactForm
{
    public class ContactModel
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen isminizi giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen e.mail adresinizi giriniz")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Lütfen iletmek istediğiniz mesajı giriniz")]
        public string Message { get; set; }

        public DateTime? AddedDate { get; set; }
        public static object ModelState { get; internal set; }

    }
}