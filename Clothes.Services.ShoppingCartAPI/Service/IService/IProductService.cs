using Clothes.Services.ShoppingCartAPI.Models.Dto;

namespace Clothes.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task <IEnumerable<ProductDto>> GetProducts ();
    }
}
