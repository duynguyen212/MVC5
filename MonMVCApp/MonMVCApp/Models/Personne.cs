using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonMVCApp.Models
{
    public class Personne : IValidatableObject
    {
        [Required(ErrorMessage = "Le champ de Nom est requis")]
        public string Nom { get; set; }


        public int Age { get; set; }

        [Required(ErrorMessage = "Le champ de Email est requis")]
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var resultats = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(Email) == false && Email.EndsWith(".com") == false)
            {
                var erreur = new ValidationResult(
                    "L'email ne termine pas par .com", 
                    new List<string> { "Email" });

                resultats.Add(erreur);
            }

            return resultats;
        }
    }
}