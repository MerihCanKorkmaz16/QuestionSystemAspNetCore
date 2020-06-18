using StackOverFlowCoreProject.Business.Abstract;
using StackOverFlowCoreProject.DataAccess.Abstract;
using StackOverFlowCoreProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
           return  _categoryDal.GetAll();
        }
    }
}
