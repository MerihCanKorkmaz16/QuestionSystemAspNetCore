using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.Business.Abstract
{
    public interface ISoruService
    {
        List<Soru> GetAll();
        List<Soru> GetByCategory(int categoryId);
        List<SoruDetay> GetSoruDetay(int categoryId);
        List<SoruDetay> GetUserSoru(int soruId);
        bool SoruSorgulama(string userId);
        void SoruEkle(Soru soru);
        void SoruGüncelle(Soru soru);
        void SoruSil(int soruId);
        Soru GetById(int soruId);
    }
}
