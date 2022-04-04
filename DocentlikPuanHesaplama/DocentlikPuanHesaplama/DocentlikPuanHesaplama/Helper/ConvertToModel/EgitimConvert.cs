using DocentlikPuanHesaplama.IdentityModel.Entity;
using DocentlikPuanHesaplama.Models.Egitim;

namespace DocentlikPuanHesaplama.Helper.ConvertToModel
{
   static public class EgitimConvert
    {
        static public EgitimEntity EgitimModelToEgitimEntity(EgitimDocentModel model)
        {
            /*********** Hesaplama yaparken ilk indexten geleni hesaplama o numune olan************/

            EgitimEntity entity = new();

            if (model.UluslarArasiAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.UluslarArasiAdoktora.Count(); i++)
                {

                    if (model.uluslararasiAhatirlatici[i] != null) entity.uluslararasiAhatirlatici += model.uluslararasiAhatirlatici[i].ToString() + "/";
                    else entity.uluslararasiAhatirlatici += "./";
                    entity.UluslarArasiAdoktora += model.UluslarArasiAdoktora[i].ToString() + "/";
                    entity.UluslarArasiAyazarsayisi += model.UluslarArasiAyazarsayisi[i].ToString() + "/";
                    entity.UluslarArasiAmakalesayisi += model.UluslarArasiAmakalesayisi[i].ToString() + "/";
                    entity.UluslarArasiACount = model.UluslarArasiAdoktora.Count() - 1;
                }



            }


            return entity;
        }
    }
}
