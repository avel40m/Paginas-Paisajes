using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Turismo.Models
{
    public class CiudadModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Ciudad")]
        [Required(ErrorMessage ="Campo obligatorio")]
        public string Nombre { get; set; }
    }
}