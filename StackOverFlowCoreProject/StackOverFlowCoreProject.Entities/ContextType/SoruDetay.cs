using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.Entities.ContextType
{
    public class SoruDetay
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LAstName { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SoruIcerik { get; set; }
        public string CategoryName { get; set; }
        public bool Durum { get; set; }
        public int soruId { get; set; }
    }
}
