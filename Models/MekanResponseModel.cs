namespace TekzenApiClient.Models
{
    public class MekanResponseModel
    {
        public int MekanId { get; set; }
        public string MekanKod { get; set; }
        public string MekanAd { get; set; }
        public string MekanTip { get; set; }
        public string MekanAdres { get; set; }
        public string MekanTel { get; set; }
        public string MekanFaks { get; set; }
        public short MekanKentAlanKod { get; set; }
        public byte MekanKentPlaka { get; set; }
        public int MekanIlceKod { get; set; }
        public string MekanKent { get; set; }
        public string MekanKentIlce { get; set; }
    }
}
