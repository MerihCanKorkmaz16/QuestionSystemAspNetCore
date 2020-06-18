using StackOverFlowCoreProject.Entities.Abstract;
using StackOverFlowCoreProject.Entities.Identity;
using StackOverFlowCoreProject.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackOverFlowCoreProject.Entities.Concrete
{
    public class Soru:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen kategoriyi seçiniz")]
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Sorunuzun detayını yazmayı unutmayınız")]
        public string SoruDetay { get; set; }
        public bool Durum { get; set; }
        public int? YorumId { get; set; }
        public virtual Category Category { get; set; }
        public virtual AppIdentityUser User { get; set; }
        public virtual Yorumlar Yorum { get; set; }
    }
}
