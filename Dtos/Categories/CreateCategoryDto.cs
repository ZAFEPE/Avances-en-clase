using System.ComponentModel.DataAnnotations;

namespace Sales.API.Dtos.Categories
{
    public class CreateCategoryDto
    {
        [StringLength(50,ErrorMessage = "El nombre no puede ser mayor a 50 caracteres")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string? Name { get; set; }
        [StringLength(150, ErrorMessage = "La descripcion no puede ser mayor a 150 caracteres")]
        public string? Description { get; set; }
    }
}