using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.Business.Abstract
{
    public interface IYorumService
    {
        List<YorumDetay> GetYorumlars(int soruId);
        void AddYorum(Yorumlar yorumlar);
    }
}
