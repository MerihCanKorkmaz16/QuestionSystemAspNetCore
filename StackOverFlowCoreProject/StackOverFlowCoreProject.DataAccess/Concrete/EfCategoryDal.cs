using StackOverFlowCoreProject.DataAccess.Abstract;
using StackOverFlowCoreProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.DataAccess.Concrete
{
    public class EfCategoryDal:AppRepositoryBase<Category,ProjectDataContext>,ICategoryDal
    {
    }
}
