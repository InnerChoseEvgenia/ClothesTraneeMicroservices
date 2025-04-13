using Clothes.Services.ShoppingCartAPI.Models.Dto;

namespace Clothes.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task <CouponDto> GetCoupon (string couponCode);
    }
}
