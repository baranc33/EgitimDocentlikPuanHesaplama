namespace DocentlikPuanHesaplama.IdentityModel.Entity
{
    public class GuzelSanatlarEntity
    {
        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region Sinema

        public string? SinemaIDoktora { get; set; } = default!;
        public string? SinemaIEtkinlikSayisi { get; set; } = default!;
        public string? SinemaIHatirlatici { get; set; } = default!;
        public int SinemaICount { get; set; } = 0;



        public string? SinemaIIDoktora { get; set; } = default!;
        public string? SinemaIIEtkinlikSayisi { get; set; } = default!;
        public string? SinemaIIHatirlatici { get; set; } = default!;
        public int SinemaIICount { get; set; } = 0;



        public string? SinemaIIIDoktora { get; set; } = default!;
        public string? SinemaIIIEtkinlikSayisi { get; set; } = default!;
        public string? SinemaIIIHatirlatici { get; set; } = default!;
        public int SinemaIIICount { get; set; } = 0;


        public string? SinemaIVDoktora { get; set; } = default!;
        public string? SinemaIVEtkinlikSayisi { get; set; } = default!;
        public string? SinemaIVTur { get; set; } = default!; 
        public string? SinemaIVHatirlatici { get; set; } = default!;
        public int SinemaIVCount { get; set; } = 0;



        public string? SinemaVDoktora { get; set; } = default!;
        public string? SinemaVEtkinlikSayisi { get; set; } = default!;
        public string? SinemaVHatirlatici { get; set; } = default!;
        public int SinemaVCount { get; set; } = 0;


        #endregion
    }
}
