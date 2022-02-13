using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepsitory)
        {
            this.categoryRepository = categoryRepsitory;
        }

        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();
        }
    }
}
