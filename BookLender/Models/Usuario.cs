using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLender.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Dni { get; set; }
        [Display(Name = "Nombre del Libro")]
        public string? NombreDelLibro { get; set; }
        [Display(Name = "Fecha de Prestamo")]
        public DateTime? FechaDelPrestamo { get; set; }
    }
}
