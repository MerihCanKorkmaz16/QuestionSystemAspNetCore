using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.DataAccess.Abstract
{
    public interface ISoruDal:IAppRepository<Soru>
    {
        List<SoruDetay> GetAllSoruDetails(int categoryId);
        List<SoruDetay> GetUserQuestion(int soruId);
        List<SoruDetay> GetMyQuestion(string userId);

    }
}
