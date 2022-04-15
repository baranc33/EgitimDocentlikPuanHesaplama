using System.ComponentModel.DataAnnotations;

namespace Core.Models.Entities
{
    public class GuzelSanatlarEntity
    {
        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region Sinema

        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIDoktora { get; set; } = default!;
        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIEtkinlikSayisi { get; set; } = default!;
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? SinemaIHatirlatici { get; set; } = default!;
        public int SinemaICount { get; set; } = 0;



        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIIDoktora { get; set; } = default!;
        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIIEtkinlikSayisi { get; set; } = default!;
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? SinemaIIHatirlatici { get; set; } = default!;
        public int SinemaIICount { get; set; } = 0;



        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIIIDoktora { get; set; } = default!;
        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIIIEtkinlikSayisi { get; set; } = default!;
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? SinemaIIIHatirlatici { get; set; } = default!;
        public int SinemaIIICount { get; set; } = 0;


        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIVDoktora { get; set; } = default!;
        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIVEtkinlikSayisi { get; set; } = default!;
        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaIVTur { get; set; } = default!;
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? SinemaIVHatirlatici { get; set; } = default!;
        public int SinemaIVCount { get; set; } = 0;



        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaVDoktora { get; set; } = default!;
        [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? SinemaVEtkinlikSayisi { get; set; } = default!;
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? SinemaVHatirlatici { get; set; } = default!;
        public int SinemaVCount { get; set; } = 0;


        #endregion
    }
}
