using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Andreu.Models
{
    public class Clown
    {
        public enum lista
        {
            Alabar,
            Andar,
            Avion
        }
        [Key]
        public int ClownID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength =2)]
        public string NickName { get; set; }

        [Required]
        public lista Tricks { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cumpleanos")]
        public DateTime Birthdate { get; set; }
    }
}