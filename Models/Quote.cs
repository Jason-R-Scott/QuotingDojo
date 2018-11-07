using System.ComponentModel.DataAnnotations;
using DbConnection;
namespace quoting_dojo.Models
{
    public class Quote//name of the table created in SQL
    {
        [Required]
        [MinLength(4, ErrorMessage="Name must be atleast 4 characters.")]
        public string Name{get;set;} // Name of the field in the table.
        [Required]
        [MinLength(10, ErrorMessage="Quote must be atleast 10 characters.")]
        public string Description{get;set;}
    }
}