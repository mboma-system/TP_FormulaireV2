using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_form_blazor.Models
{
    public class Utilisateur
    {
        [Required, RegularExpression(@"^[A-Z]{1}[a-zA-Z\séèë\-_]*$")]
        public string Nom { get; set; }
        [Required, RegularExpression(@"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$")]
        public string Email { get; set; }
        [Required, RegularExpression(@"^([a-zA-Z0-9\.\-_\s]*)$")]
        public string Adresse { get; set; }
        [Required, RegularExpression(@"^[0-9]{5}$")]
        public string CodePostal { get; set; }

        [Required, RegularExpression("^[1-9]{1,125}$")]
        public int Age { get; set; }
        [Required]
        public DateTime DateDeNaissance { get; set; }

        public string CheckingMaritalStatus()
        {
            if (IsMarried)
            {
                return "Marié(e)";
            }
            else { return "Célibataire"; }
            }
        public bool IsMarried { get; set; }

        [Required]
        public string Favoritcolor { get; set; }
    }
}
