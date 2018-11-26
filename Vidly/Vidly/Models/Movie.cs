using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the film's name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the film's release date")]
        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Required(ErrorMessage = "Please enter the film's number in stock")]
        [Range(1, 20, ErrorMessage = "Film's number in stock has to be a value between 1 and 20")]
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }
        
        public int AvailableNumber { get; set; }

        [Required(ErrorMessage = "Please select film's genre")]
        [ForeignKey("Genre")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}