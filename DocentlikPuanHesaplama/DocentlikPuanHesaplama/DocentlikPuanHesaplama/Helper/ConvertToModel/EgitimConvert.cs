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

                    if (model.UluslarArasiAhatirlatici[i] != null) entity.UluslarArasiAhatirlatici += model.UluslarArasiAhatirlatici[i].ToString() + "/";
                    else entity.UluslarArasiAhatirlatici += "./";
                    entity.UluslarArasiAdoktora += model.UluslarArasiAdoktora[i].ToString() + "/";
                    entity.UluslarArasiAyazarsayisi += model.UluslarArasiAyazarsayisi[i].ToString() + "/";
                    entity.UluslarArasiAmakalesayisi += model.UluslarArasiAmakalesayisi[i].ToString() + "/";
                    entity.UluslarArasiACount = model.UluslarArasiAdoktora.Count() - 1;
                }
            }

            if (model.UluslarArasiBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.UluslarArasiBdoktora.Count(); i++)
                {

                    if (model.UluslarArasiBhatirlatici[i] != null) entity.UluslarArasiBhatirlatici += model.UluslarArasiBhatirlatici[i].ToString() + "/";
                    else entity.UluslarArasiBhatirlatici += "./";
                    entity.UluslarArasiBdoktora += model.UluslarArasiBdoktora[i].ToString() + "/";
                    entity.UluslarArasiByazarsayisi += model.UluslarArasiByazarsayisi[i].ToString() + "/";
                    entity.UluslarArasiBmakalesayisi += model.UluslarArasiBmakalesayisi[i].ToString() + "/";
                    entity.UluslarArasiBCount = model.UluslarArasiBdoktora.Count() - 1;
                }
            }
            if (model.UluslarArasiCdoktora.Count() > 1)
            {
                for (int i = 1; i < model.UluslarArasiCdoktora.Count(); i++)
                {

                    if (model.UluslarArasiChatirlatici[i] != null) entity.UluslarArasiChatirlatici += model.UluslarArasiChatirlatici[i].ToString() + "/";
                    else entity.UluslarArasiChatirlatici += "./";
                    entity.UluslarArasiCdoktora += model.UluslarArasiCdoktora[i].ToString() + "/";
                    entity.UluslarArasiCyazarsayisi += model.UluslarArasiCyazarsayisi[i].ToString() + "/";
                    entity.UluslarArasiCmakalesayisi += model.UluslarArasiCmakalesayisi[i].ToString() + "/";
                    entity.UluslarArasiCCount = model.UluslarArasiCdoktora.Count() - 1;
                }
            }
            return entity;
        }
    }
}
