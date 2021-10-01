using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Turismo.Models
{
    public class PaisajeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        public string Lugar { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        public string Direccion { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        public string Descripcion { get; set; }
        [Display(Name ="Imagen")]
        public string ImageName { get; set; }
        [Display(Name ="Imagen")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        public int Valoracion { get; set; }
        [Display(Name ="Pais")]
        public int IdPais { get; set; }
        [ForeignKey("IdPais")]
        [Display(Name ="Pais")]
        public PaisModel paisModel { get; set; }
        [Display(Name ="Provincia")]
        public int IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        [Display(Name ="Provincias")]
        public ProvinciaModel provinciaModel { get; set; }
        [Display(Name ="Ciudad")]
        public int IdCiudad { get; set; }
        [ForeignKey("IdCiudad")]
        [Display(Name ="Ciudad")]
        public CiudadModel ciudadModel { get; set; }
    }
}