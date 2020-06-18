using StackOverFlowCoreProject.Entities.Abstract;
using StackOverFlowCoreProject.Entities.Identity;
using StackOverFlowCoreProject.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackOverFlowCoreProject.Entities.Concrete
{
    public class Yorumlar:IEntity
    {
        public Yorumlar()
        {
            Soru = new HashSet<Soru>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen cevabınızı giriniz")]
        public string YorumDetay { get; set; }
        public DateTime CreatedDate { get; set; }
        public int SoruId { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<Soru> Soru { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
