using StackOverFlowCoreProject.Entities.Concrete;
using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverFlowCoreProject.WebUI.Models
{
    public class UserSoruIndexViewModel
    {
        public List<SoruDetay> Soru { get; set; }
        public List<YorumDetay> Yorumlars { get; set; }
        public bool checkUser { get; set; }
        public int soruId { get; set; }
        public bool SoruDurum { get; set; }
    }
}
