using System.ComponentModel.DataAnnotations;

namespace WebEvaluation.Models
{
    public enum Estado
    {
        Aprobado,
        Reprobado,
    }
    public class Nota
    {
        [Key]
        public int NotaID { get; set; }
        [Required(ErrorMessage ="Ingrese una calificacion")]
        public int Calificacion { get; set; }
        [Required]
        public Estado Estado  { get; set; }
    }
}