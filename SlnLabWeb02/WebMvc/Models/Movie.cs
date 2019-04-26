using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMvc.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Ingrese el título de la película")]
        [Display(Name = "Título")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Ingrese la Fecha de Lanzamiento")]
        [Display(Name = "Fecha de Lanzamiento")]


        
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Ingrese el género")]
        [Display(Name = "Género")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Ingrese el Precio")]
        [Display(Name = "Precio")]
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }

        [StringLength(5)]
        [Required(ErrorMessage = "Ingrese el rating")]
        public string Rating { get; set; }
    }
}