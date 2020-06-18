using StackOverFlowCoreProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowCoreProject.Entities.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            Soru = new HashSet<Soru>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Soru> Soru { get; set; }
    }
}
