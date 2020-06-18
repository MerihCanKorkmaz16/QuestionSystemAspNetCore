using StackOverFlowCoreProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
