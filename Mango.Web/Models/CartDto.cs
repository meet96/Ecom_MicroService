namespace Mango.Web.Models
{
    public class CartDto
    {
        public CartHeaderDto CartHeaderDto { get; set; }

        public IEnumerable<CartDetailsDto> ?CartDetails{ get; set; }
    }
}
