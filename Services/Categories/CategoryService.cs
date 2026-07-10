using Sales.API.Dtos.Common;
using Sales.API.Entities;
using Sales.API.DataBase;
using Sales.API.Constants;
using Sales.API.Dtos.Categories;

namespace Sales.API.Services.Categories
{
    
    public  class CategoryService : ICategoryService
    {
        private readonly SalesDbContext _context;
        public CategoryService(
            SalesDbContext context
        )
        {
            _context = context;
        }
        public async Task<ResponseDto<ResponseCategoryDto>> CreateAsync(CreateCategoryDto dto)
        {
            CategoryEntity entity = new CategoryEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = dto.Name,
                Description = dto.Description,
                IsActive = true
            };
            
             _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
            
            return new ResponseDto<ResponseCategoryDto>
            {
              StatusCode = HttpStatusCode.CREATED,
              Status = true,
              Message = "Registro creado correctamente",
              Data = new ResponseCategoryDto
              {
                  Id = entity.Id
              }

            };

        }
    }
}