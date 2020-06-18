using StackOverFlowCoreProject.DataAccess.Abstract;
using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StackOverFlowCoreProject.DataAccess.Concrete
{
    public class EfYorumDal : AppRepositoryBase<Yorumlar, ProjectDataContext>, IYorumDal
    {
        public List<YorumDetay> GetYorumAll(int soruId)
        {
            using (ProjectDataContext context = new ProjectDataContext())
            {
                var result = from p in context.AspNetUsers
                             join c in context.Yorumlar on p.Id equals c.UserId
                             where c.SoruId == soruId
                             select new YorumDetay
                             {
                                 UserName = p.UserName,
                                 YorumIcerik = c.YorumDetay,
                                 CreatedDate = c.CreatedDate
                             };
                return result.ToList();

            }

        }
    }
}
