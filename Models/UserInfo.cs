using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set;}

        [Required (ErrorMessage = "Lütfen ismini belirtiniz")]
        public string? Name { get; set; }

        [Required (ErrorMessage = "Lütfen geçerli bir e-posta adresi giriniz")]
        [EmailAddress]
        public string? Email{ get; set; }

    
        [Required (ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz")]
        public string? Number{ get; set; }

        [Required (ErrorMessage = "Lütfen katılım durumunuzu belirtiniz")]
        public bool? Participate{ get; set; }
    }
}