using Volo.Abp;

namespace OnlineStore.Products
{
    public class ProductAlreadyExistsException : BusinessException
    {
        public ProductAlreadyExistsException(string nameEn) : base(OnlineStore.OnlineStoreDomainErrorCodes.PRODUCT_ALREADY_EXISTS)
        {
            WithData("nameEn", nameEn);
        }
    }
}
