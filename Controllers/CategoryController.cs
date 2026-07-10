using Microsoft.AspNetCore.Mvc;
using Sales.API.Entities;

namespace Sales.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private static readonly List<CategoryEntity> _categories = new List<CategoryEntity>
        {
            new CategoryEntity { Id = "1", Name = "Lácteos", Description = "" },
            new CategoryEntity { Id = "2", Name = "Frutas", Description = "" },
            new CategoryEntity { Id = "3", Name = "Higiene", Description = "" },
            new CategoryEntity { Id = "4", Name = "Carnes", Description = "" }
        };

// ¡Y dejas el constructor completamente vacío!
public CategoryController()
{
}

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categories);
        }

        [HttpGet("{id}")] // GET: /categories/{id}
        public IActionResult GetOne(string id)
        {
            return Ok(_categories.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]CategoryEntity category)
        {
            _categories.Add(category);
            Console.WriteLine($"Categoría agregada: {category.Id}, {category.Name}, {category.Description}");
            return Ok("Categoría creada");
        }
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] CategoryEntity category)
        {
            category.Id = id;// se iguala para no mandarlo(????????(En la vida real no se hace)
            var oldCategory = _categories.FirstOrDefault(c => c.Id == id);
            if (oldCategory != null)
            {
                _categories.Remove(oldCategory);
                _categories.Add(category);
                Console.WriteLine($"Categoría actualizada: {category.Id}, {category.Name}, {category.Description}");
            }
            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(string id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if(category != null)
            {
                _categories.Remove(category);
                Console.WriteLine($"Categoría borrada: {category.Id}, {category.Name}, {category.Description}");

            }
            return Ok();
        }

    }
}