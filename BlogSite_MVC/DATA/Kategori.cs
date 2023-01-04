using System.ComponentModel.DataAnnotations;

namespace BlogSite_MVC.DATA
{
    public class Kategori
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Ad { get; set; } = null!;

        public List<Gonderi> Gonderiler { get; set; }=new List<Gonderi>();
    }
}
