using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService) 
        { 
            _baseService = baseService;
        }

        public Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.CouponAPIBase + "/api/coupon",
                Data = couponDto
            });
        }

        public Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/coupon/" + id,
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto() 
            { 
                ApiType = SD.ApiType.GET, 
                Url = SD.CouponAPIBase + "/api/coupon" 
            });
        }

        public Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/GetByCode" + couponCode
            });
        }

        public Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Url = SD.CouponAPIBase + "/api/coupon",
                Data = couponDto
            });
        }
    }
}
