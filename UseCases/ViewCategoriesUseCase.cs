using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoryRepsitory;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepsitory)
        {
            this.categoryRepsitory = categoryRepsitory;
        }

        public IEnumerable<Category> Execute() 
        {
            return categoryRepsitory.GetCategories();
        }
    }
}
