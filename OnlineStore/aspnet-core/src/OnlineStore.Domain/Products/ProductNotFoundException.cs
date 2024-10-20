using Volo.Abp;

namespace OnlineStore.Products
{
    public class ProductNotFoundException : BusinessException
    {
        public ProductNotFoundException(int id) : base(OnlineStoreDomainErrorCodes.PRODUCT_NOT_FOUND)
        {
            WithData("id", id);
        }
    }
}
