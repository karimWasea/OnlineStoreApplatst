using System.Threading.Tasks;

using Volo.Abp.DependencyInjection;

namespace OnlineStore.Products
{
    public interface IProductService : ITransientDependency
    {
        Task<bool> Exists(Product product);
    }
}
