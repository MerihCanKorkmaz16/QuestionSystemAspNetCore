using StackOverFlowCoreProject.Entities.ContextType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverFlowCoreProject.WebUI.Models
{
    public class MyQuestionViewModel
    {
        public IOrderedEnumerable<SoruDetay> MyQuestions { get; set; }
    }
}
