using StackOverFlowCoreProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverFlowCoreProject.WebUI.Models
{
    public class YorumEklemeViewModel
    {
        public Yorumlar Yorum { get; set; }
        public int soruId { get; set; }
    }
}
