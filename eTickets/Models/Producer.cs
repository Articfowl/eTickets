using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = " A profile picture is required!")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full name")]
        [Required(ErrorMessage = " A full name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The full name must be between 3 and 50 characters")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = " A biography is required!")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
