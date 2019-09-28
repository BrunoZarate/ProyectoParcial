using System.Data.Entity;

namespace WebEvaluation.Models
{
    public class DataContext :DbContext
    {
        public DataContext():base("DefaultConnection")
         {

        }

        public System.Data.Entity.DbSet<WebEvaluation.Models.Estudiante> Estudiantes { get; set; }


    }
}