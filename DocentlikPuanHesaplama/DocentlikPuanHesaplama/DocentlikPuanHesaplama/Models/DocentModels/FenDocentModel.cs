using DocentlikPuanHesaplama.IdentityModel;
using DocentlikPuanHesaplama.Models.Bolumler;

namespace DocentlikPuanHesaplama.Models.DocentModels
{
    public class FenDocentModel
    {
        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region Makaleler
        public int[] MakalelerAdoktora { get; set; } = default!;
        public int[] MakalelerAmakalesayisi { get; set; } = default!;
        public int[] MakalelerAyazarsayisi { get; set; } = default!;
        public string[] MakalelerAhatirlatici { get; set; } = default!;

        public int[] MakalelerBdoktora { get; set; } = default!;
        public int[] MakalelerBmakalesayisi { get; set; } = default!;
        public int[] MakalelerByazarsayisi { get; set; } = default!;
        public string[] MakalelerBhatirlatici { get; set; } = default!;

        public int[] MakalelerCdoktora { get; set; } = default!;
        public int[] MakalelerCmakalesayisi { get; set; } = default!;
        public int[] MakalelerCyazarsayisi { get; set; } = default!;
        public string[] MakalelerChatirlatici { get; set; } = default!;


        private Makaleler MakalelerHesapla()
        {
            Makaleler model = new();
            if (MakalelerAdoktora.Count() > 1)
            {
                for (int i = 1; i < MakalelerAdoktora.Count(); i++)
                {

                    if (MakalelerAdoktora[i] == 0 && MakalelerAmakalesayisi[i] > 0 && MakalelerAyazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (20 * MakalelerAmakalesayisi[i]) / (decimal)MakalelerAyazarsayisi[i];
                    }
                    else if (MakalelerAdoktora[i] == 1 && MakalelerAmakalesayisi[i] > 0 && MakalelerAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (20 * MakalelerAmakalesayisi[i]) / (decimal)MakalelerAyazarsayisi[i];
                    }
                }

            }
            if (MakalelerBdoktora.Count() > 1)
            {
                for (int i = 1; i < MakalelerBdoktora.Count(); i++)
                {

                    if (MakalelerBdoktora[i] == 0 && MakalelerBmakalesayisi[i] > 0 && MakalelerByazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (15 * MakalelerBmakalesayisi[i]) / (decimal)MakalelerByazarsayisi[i];
                    }
                    else if (MakalelerBdoktora[i] == 1 && MakalelerBmakalesayisi[i] > 0 && MakalelerByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (15 * MakalelerBmakalesayisi[i]) / (decimal)MakalelerByazarsayisi[i];
                    }
                }

            }
            // c seçeniğe girmeden kontrol işlemi yapıyorumki ekstra değişken tanımlama işlemi yapmiyalım 
            if (model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan < 20) model.Error = true;
            if (MakalelerCdoktora.Count() > 1)
            {
                for (int i = 1; i < MakalelerCdoktora.Count(); i++)
                {

                    if (MakalelerCdoktora[i] == 0 && MakalelerCmakalesayisi[i] > 0 && MakalelerCyazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (5 * MakalelerCmakalesayisi[i]) / (decimal)MakalelerCyazarsayisi[i];
                    }
                    else if (MakalelerCdoktora[i] == 1 && MakalelerCmakalesayisi[i] > 0 && MakalelerCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (5 * MakalelerCmakalesayisi[i]) / (decimal)MakalelerCyazarsayisi[i];
                    }
                }
            }
            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            model.ErrorMessage = "1. Uluslararası Makale  maddesinin a veya b bentleri kapsamında en az 20 puan almak zorunludur";
            return model;
        }

        #endregion




    }
}
