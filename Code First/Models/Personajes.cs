using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Code_First.Models
{
    public class Personajes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Per_Id { get; set; }

        public int Per_LibId { get; set; }

        public int Per_RolId { get; set; }
        [Required]
        [StringLength(255)]
        public string Per_Nombre { get; set; } = null!;
        [Required]
        [StringLength(255)]
        public string Per_Apellido { get; set; } = null!;
        [Required]
        [StringLength(255)]
        public string Per_Descripcion { get; set; } = null!;

        public DateTime? Per_FechaNacimiento { get; set; }
        [Required]
        [StringLength(255)]
        public string? Per_LugarNacimiento { get; set; }
        [Required, StringLength(10)]
        public string Per_Status { get; set; } = null!;

        public Libros libro { get; set; } 

        public virtual Roles Rol { get; set; } 
    }
}
