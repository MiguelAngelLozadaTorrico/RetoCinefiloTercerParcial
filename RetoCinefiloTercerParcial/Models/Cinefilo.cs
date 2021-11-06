using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetoCinefiloTercerParcial.Models
{
    public class Cinefilo
    {
        [Url]
        [Display(Name = "Imagen del poster")]
        public string Portada { get; set; }

        [Key]
        [Display(Name = "Genero de la pelicula")]
        public string Genero { get; set; }
        
        [Display(Name = "Nombre completo de la pelicula")]
        public string Nombre { get; set; }

        [Display(Name = "Director de la pelicula")]
        public string Director { get; set; }

        [Display(Name = "Sinopsis de de la pelicula")]
        public string Sinopsis { get; set; }

        [Display(Name = "Duracion de la pelicula")]
        public string Tiempo { get; set; }

        [Display(Name = "Calificacion en IMDb")]
        public string CalificacionIMDb { get; set; }

        [Display(Name = "Calificacion en Rotten Tomatoes")]
        public string CalificacionRottenTomatoes { get; set; }

        [Display(Name = "Nominaciones a oscars")]
        public string NominacionesOscars { get; set; }

        [Display(Name = "Galadornes oscars")]
        public string GalardonesOscars { get; set; }

        [Display(Name = "Secuelas")]
        public string Secuelas { get; set; }

        [Display(Name = "Precuelas")]
        public string Precuelas { get; set; }


        [Display(Name = "Reto")]
        public string Reto { get; set; }

        [Url]
        [Display(Name = "Link del trailer")]
        public string Trailer { get; set; }

        [Display(Name = "Curiosidades de la pelicula")]
        public string Curiosidades { get; set; }











    }
}
