using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema logo")]
        [Required(ErrorMessage = " A logo is required!")]
        public string Logo { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage = " A name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The full name must be between 3 and 50 characters")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        [Required(ErrorMessage = " A description is required!")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
