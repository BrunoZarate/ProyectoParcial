using System;
using System.ComponentModel.DataAnnotations;

namespace WebEvaluation.Models
{
    public enum Genre
    {
        Male,
        Female,
    }
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage="Please Enter a Name")]
        public string Name { get; set; }
        [Required]
        public Genre Genero { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}