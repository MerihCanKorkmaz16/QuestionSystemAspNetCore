using StackOverFlowCoreProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverFlowCoreProject.WebUI.Models
{
    public class AddQuestionViewModel
    {
        public List<Category> categories { get; set; }
        public Soru Soru { get; set; }
    }
}
