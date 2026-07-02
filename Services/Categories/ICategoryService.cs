using Sales.API.Dtos.Common;
using Sales.API.Entities;

namespace Sales.API.Services.Categories
{
    public interface ICategoryService
    {
        Task<ResponseDto<CategoryEntity>> CreateAsync(CategoryEntity category);
    }
}