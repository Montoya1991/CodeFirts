using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.Models
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }
        [Required]
        [StringLength(255)]
        public string RolDescripcion { get; set; } = null!;
        [Required, StringLength(10)]
        public string RolStatus { get; set; } = null!;

        public virtual ICollection<Personajes> Personajes { get; set; }
    }
}
