using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Display(Name="Movie name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "Movie price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Display(Name = "Movie poster url")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageURL { get; set; }
        [Display(Name = "Movie startdate")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Movie enddate")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Movie category")]
        [Required(ErrorMessage = "Category is required")]
        public MovieCategory MovieCategory { get; set; }


        //Relationships
        [Display(Name = "Select Movie actor(s)")]
        [Required(ErrorMessage = "Every movie has some actor(s)")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Select Movie cinema")]
        [Required(ErrorMessage = "Cinema is required")]
        public int CinemaId { get; set; }
        [Display(Name = "Select Movie producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducerId { get; set; }

    }
}
