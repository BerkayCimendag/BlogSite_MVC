namespace BlogSite_MVC.Models
{
    public class HomeViewModel
    {
        public int? KategoriId { get; set; }
        public List<Gonderi> Gonderiler { get; set; } = new();

        public int Sayfa { get; set; }
        public int SayfaAdet { get; set; }
        public bool EskisiVar => SayfaAdet > Sayfa;
        public bool YenisiVar => Sayfa > 1;
    }
}
