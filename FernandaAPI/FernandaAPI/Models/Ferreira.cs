using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FernandaAPI.Models
{
    public class Ferreira
    {
        [Key] 
        [Required]
        public int FerreiraID { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 2)]
        [DisplayName("Nombre completo")]
        public string FriendofFerreira { get; set; }

        [Required(ErrorMessage ="Ingresar lugar")]
        public Place place { get; set; }

        [EmailAddress(ErrorMessage ="Ingresar email en el formato correcto")]
        public string Email { get; set; }

        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:dd//MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/YYYY}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime Birthdate { get; set; }

    }
       public enum Place
    {
        Bolivia,
        Argentina, 
        Colombia,
        Uruguay,
        Venezuela
    }


}

