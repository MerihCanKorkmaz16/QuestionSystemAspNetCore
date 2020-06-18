using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.DataAccess.Abstract
{
    public interface IYorumDal:IAppRepository<Yorumlar>
    {
        List<YorumDetay> GetYorumAll(int soruId);
    }
}
