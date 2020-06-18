using StackOverFlowCoreProject.Business.Abstract;
using StackOverFlowCoreProject.DataAccess.Abstract;
using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace StackOverFlowCoreProject.Business.Concrete
{
    public class SoruManager : ISoruService
    {
        private ISoruDal _soruDal;
        public SoruManager(ISoruDal soruDal)
        {
            _soruDal = soruDal;
        }
        public List<Soru> GetAll()
        {
            return _soruDal.GetAll();
        }

        public List<Soru> GetByCategory(int categoryId)
        {
            return _soruDal.GetAll(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public Soru GetById(int soruId)
        {
            return _soruDal.Get(p => p.Id == soruId);
        }

        public Soru GetSoruById(int soruId)
        {
            return _soruDal.Get(x=>x.Id == soruId);
        }

        public List<SoruDetay> GetSoruDetay(int categoryId)
        {
            return _soruDal.GetAllSoruDetails(categoryId);
        }

        public List<SoruDetay> GetUserSoru(int soruId)
        {
            return _soruDal.GetUserQuestion(soruId);
        }

        public void SoruEkle(Soru soru)
        {
            _soruDal.Add(soru);
        }

        public void SoruGüncelle(Soru soru)
        {
            _soruDal.Update(soru);
        }

        public void SoruSil(int soruId)
        {
            _soruDal.Delete(new Soru { Id = soruId });
        }

        public bool SoruSorgulama(string userId)
        {
            var checkuser = _soruDal.Get(x=>x.UserId == userId);
            if (checkuser == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
