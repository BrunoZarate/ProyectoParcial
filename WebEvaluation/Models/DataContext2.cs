using System.Data.Entity;

namespace WebEvaluation.Models
{
    public class DataContext2 :DbContext
    {
        public DataContext2():base("DefaultConnection")
        {

        }
        public System.Data.Entity.DbSet<WebEvaluation.Models.Nota> Notas { get; set; }

    }

}