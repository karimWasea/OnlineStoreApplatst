using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OnlineStore.Categories
{
    public class CategoriesAppService :
      CrudAppService<Category,
                     CategoryDto,
                     int,
                     PagedAndSortedResultRequestDto,
                     CreateUpdateCategoryDto>,
      ICategoriesAppService
    {

        #region constructor
        public CategoriesAppService(IRepository<Category, int> repository) : base(repository)
        {
        }
        #endregion constructor
    }
}
