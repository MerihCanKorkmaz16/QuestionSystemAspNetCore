using StackOverFlowCoreProject.Business.Abstract;
using StackOverFlowCoreProject.DataAccess.Abstract;
using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace StackOverFlowCoreProject.Business.Concrete
{
    public class YorumManager:IYorumService
    {
        private IYorumDal _yorumDal;
        public YorumManager(IYorumDal yorumDal)
        {
            _yorumDal = yorumDal;
        }

        public void AddYorum(Yorumlar yorumlar)
        {
            _yorumDal.Add(yorumlar);
        }

        public List<YorumDetay> GetYorumlars(int soruId)
        {
            return _yorumDal.GetYorumAll(soruId);
        }
    }
}
