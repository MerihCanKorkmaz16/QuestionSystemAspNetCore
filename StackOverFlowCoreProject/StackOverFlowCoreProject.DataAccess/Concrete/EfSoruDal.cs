using StackOverFlowCoreProject.DataAccess.Abstract;
using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StackOverFlowCoreProject.DataAccess.Concrete
{
    public class EfSoruDal : AppRepositoryBase<Soru, ProjectDataContext>, ISoruDal
    {
        public List<SoruDetay> GetAllSoruDetails(int categoryId)
        {
            using (ProjectDataContext context = new ProjectDataContext())
            {
                if (categoryId == 0)
                {
                    var result = from p in context.AspNetUsers
                                 join c in context.Soru on p.Id equals c.UserId
                                 join z in context.Category on c.CategoryId equals z.Id
                                 select new SoruDetay
                                 {
                                     UserId = p.Id,
                                     FirstName = p.FirstName,
                                     LAstName = p.LastName,
                                     UserName = p.UserName,
                                     CreatedDate = c.CreatedDate,
                                     SoruIcerik = c.SoruDetay,
                                     CategoryName = z.CategoryName,
                                     Durum = c.Durum,
                                     soruId = c.Id
                                 };
                    return result.ToList();
                }
                else
                {
                    var result = from p in context.AspNetUsers
                                 join c in context.Soru on p.Id equals c.UserId
                                 join z in context.Category on c.CategoryId equals z.Id
                                 where categoryId == z.Id
                                 select new SoruDetay
                                 {
                                     UserId = p.Id,
                                     FirstName = p.FirstName,
                                     LAstName = p.LastName,
                                     UserName = p.UserName,
                                     CreatedDate = c.CreatedDate,
                                     SoruIcerik = c.SoruDetay,
                                     CategoryName = z.CategoryName,
                                     Durum = c.Durum,
                                     soruId = c.Id
                                 };
                    return result.ToList();
                }

            }
        }

        public List<SoruDetay> GetMyQuestion(string userId)
        {
            using (ProjectDataContext context = new ProjectDataContext())
            {
                var result = from p in context.AspNetUsers
                             join c in context.Soru on p.Id equals c.UserId
                             join z in context.Category on c.CategoryId equals z.Id
                             where p.Id == userId
                             select new SoruDetay
                             {
                                 UserId = p.Id,
                                 FirstName = p.FirstName,
                                 LAstName = p.LastName,
                                 UserName = p.UserName,
                                 CreatedDate = c.CreatedDate,
                                 SoruIcerik = c.SoruDetay,
                                 CategoryName = z.CategoryName,
                                 Durum = c.Durum,
                                 soruId = c.Id
                             };
                return result.ToList();

            }

        }

        public List<SoruDetay> GetUserQuestion(int soruId)
        {
            using (ProjectDataContext context = new ProjectDataContext())
            {
                var result = from p in context.AspNetUsers
                             join c in context.Soru on p.Id equals c.UserId
                             join z in context.Category on c.CategoryId equals z.Id
                             where c.Id == soruId
                             select new SoruDetay
                             {
                                 UserId = p.Id,
                                 FirstName = p.FirstName,
                                 LAstName = p.LastName,
                                 UserName = p.UserName,
                                 CreatedDate = c.CreatedDate,
                                 SoruIcerik = c.SoruDetay,
                                 CategoryName = z.CategoryName,
                                 Durum = c.Durum,
                                 soruId = c.Id
                             };
                return result.ToList();

            }
        }


    }
}
