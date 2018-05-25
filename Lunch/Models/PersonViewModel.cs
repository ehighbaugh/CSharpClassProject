using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lunch.Models
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            FoodPreferences = new List<FoodPreferenceViewModel>();
        }

        public int? PersonId { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Name")]
        public string FullName => FirstName + " " + LastName;

        public List<FoodPreferenceViewModel> FoodPreferences { get; set; }
    }
}