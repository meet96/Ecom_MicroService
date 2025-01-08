using Mango.Services.ShoppingCartAPI.Models.Dto;
using Mango.Services.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;

namespace Mango.Services.ShoppingCartAPI.Service
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var client = _clientFactory.CreateClient("Product");
            var response = await client.GetAsync($"/api/product");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseDto>(content);
            if (result.IsSuccess)
            {
                return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(Convert.ToString(result.Result));
            }
            return new List<ProductDto>();
            
        }
    }
}
