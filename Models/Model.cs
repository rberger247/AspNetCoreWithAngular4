using System.ComponentModel.DataAnnotations;
using rafi.Models;

namespace rafi.Models
{
    public class Model
    {
        public int Id { get; set; }
           [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public Make make { get; set; }

        public int MakeId { get; set; }
    }
}