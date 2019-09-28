using System.Data.Entity;

namespace WebEvaluation.Models
{
    public class DataContext :DbContext
    {
        public DataContext():base("DefaultConnection")
         {

        }
    }
}