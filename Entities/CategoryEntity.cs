using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sales.API.Entities

{
    [Table("categories")]
    public class CategoryEntity : BaseEntity
    {
        [Column("name")]
        public string? Name{get; set;}
        [Column("description")]
        public string? Description { get; set; }
        [Column ("is_active")]
        public bool IsActive { get; set; } = true;
    }
}