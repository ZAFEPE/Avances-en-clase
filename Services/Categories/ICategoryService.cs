using Sales.API.Dtos.Common;
using Sales.API.Dtos.Categories;

namespace Sales.API.Services.Categories
{
    public interface ICategoryService
    {
        Task<ResponseDto<ResponseCategoryDto>> CreateAsync(CreateCategoryDto dto);
    }
}
/*
Task<...>: Significa que el método es asíncrono. 
No bloquea el servidor mientras espera a que el disco duro responda.

ResponseDto<...>: Es el DTO genérico de salida que estandariza la respuesta 
(Status, Message, Data).

<ResponseCategoryDto>: Es el tipo real que viaja dentro de la propiedad Data 
del genérico. Bruno recibirá este molde con los datos limpios.

CreateAsync: Es el nombre del método. Por convención, en .NET todo método asíncrono 
debe terminar con la palabra Async.

(CreateCategoryDto dto): Es el parámetro de entrada. Indica que este método solo aceptará
 la "caja de cartón" que trae el Name y la Description desde Bruno.
*/