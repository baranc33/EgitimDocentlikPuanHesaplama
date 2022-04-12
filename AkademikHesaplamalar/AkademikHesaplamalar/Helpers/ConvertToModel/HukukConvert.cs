using AkademikHesaplamalar.Models.Entities;
using AkademikHesaplamalar.ViewModels.DocentModels.Models;

namespace AkademikHesaplamalar.Helpers.ConvertToModel
{
    public class HukukConvert
    {
        static public HukukEntity EgitimModelToEgitimEntity(HukukDocentModel model)
        {

            HukukEntity entity = new();

            /***  U L U S L A R    A R A S I   ***/
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

            /********  U L U S A L  ********/
            if (model.UlusalAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.UlusalAdoktora.Count(); i++)
                {

                    if (model.UlusalAhatirlatici[i] != null) entity.UlusalAhatirlatici += model.UlusalAhatirlatici[i].ToString() + "/";
                    else entity.UlusalAhatirlatici += "./";
                    entity.UlusalAdoktora += model.UlusalAdoktora[i].ToString() + "/";
                    entity.UlusalAyazarsayisi += model.UlusalAyazarsayisi[i].ToString() + "/";
                    entity.UlusalAmakalesayisi += model.UlusalAmakalesayisi[i].ToString() + "/";
                    entity.UlusalACount = model.UlusalAdoktora.Count() - 1;
                }
            }

            if (model.UlusalBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.UlusalBdoktora.Count(); i++)
                {

                    if (model.UlusalBhatirlatici[i] != null) entity.UlusalBhatirlatici += model.UlusalBhatirlatici[i].ToString() + "/";
                    else entity.UlusalBhatirlatici += "./";
                    entity.UlusalBdoktora += model.UlusalBdoktora[i].ToString() + "/";
                    entity.UlusalByazarsayisi += model.UlusalByazarsayisi[i].ToString() + "/";
                    entity.UlusalBmakalesayisi += model.UlusalBmakalesayisi[i].ToString() + "/";
                    entity.UlusalBCount = model.UlusalBdoktora.Count() - 1;
                }
            }


            /********* Y A Y I N *********/
            if (model.YayinAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.YayinAdoktora.Count(); i++)
                {

                    if (model.YayinAhatirlatici[i] != null) entity.YayinAhatirlatici += model.YayinAhatirlatici[i].ToString() + "/";
                    else entity.YayinAhatirlatici += "./";
                    entity.YayinAdoktora += model.YayinAdoktora[i].ToString() + "/";
                    entity.YayinAyazarsayisi += model.YayinAyazarsayisi[i].ToString() + "/";
                    entity.YayinAkitap += model.YayinAkitap[i].ToString() + "/";
                    entity.YayinACount = model.YayinAdoktora.Count() - 1;
                }
            }

            if (model.YayinBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.YayinBdoktora.Count(); i++)
                {

                    if (model.YayinBhatirlatici?[i] != null) entity.YayinBhatirlatici += model.YayinBhatirlatici[i].ToString() + "/";
                    else entity.YayinBhatirlatici += "./";
                    entity.YayinBdoktora += model.YayinBdoktora[i].ToString() + "/";
                    entity.YayinBbolumSayisi += model.YayinBbolumSayisi[i].ToString() + "/";
                    entity.YayinByazarsayisi += model.YayinByazarsayisi[i].ToString() + "/";
                    entity.YayinBCount = model.YayinBdoktora.Count() - 1;
                }
            }

            if (model.YayinCdoktora.Count() > 1)
            {
                for (int i = 1; i < model.YayinCdoktora.Count(); i++)
                {

                    if (model.YayinChatirlatici[i] != null) entity.YayinChatirlatici += model.YayinChatirlatici[i].ToString() + "/";
                    else entity.YayinChatirlatici += "./";
                    entity.YayinCdoktora += model.YayinCdoktora[i].ToString() + "/";
                    entity.YayinCyazarsayisi += model.YayinCyazarsayisi[i].ToString() + "/";
                    entity.YayinCkitap += model.YayinCkitap[i].ToString() + "/";
                    entity.YayinCCount = model.YayinCdoktora.Count() - 1;
                }
            }

            if (model.YayinDdoktora.Count() > 1)
            {
                for (int i = 1; i < model.YayinDdoktora.Count(); i++)
                {

                    if (model.YayinDhatirlatici[i] != null) entity.YayinDhatirlatici += model.YayinDhatirlatici[i].ToString() + "/";
                    else entity.YayinDhatirlatici += "./";
                    entity.YayinDdoktora += model.YayinDdoktora[i].ToString() + "/";
                    entity.YayinDbolumSayisi += model.YayinDbolumSayisi[i].ToString() + "/";
                    entity.YayinDyazarsayisi += model.YayinDyazarsayisi[i].ToString() + "/";
                    entity.YayinDCount = model.YayinDdoktora.Count() - 1;
                }
            }


            if (model.YayinEdoktora.Count() > 1)
            {
                for (int i = 1; i < model.YayinEdoktora.Count(); i++)
                {

                    if (model.YayinEhatirlatici[i] != null) entity.YayinEhatirlatici += model.YayinEhatirlatici[i].ToString() + "/";
                    else entity.YayinEhatirlatici += "./";
                    entity.YayinEdoktora += model.YayinEdoktora[i].ToString() + "/";
                    entity.YayinEyazarsayisi += model.YayinEyazarsayisi[i].ToString() + "/";
                    entity.YayinEmakalesayisi += model.YayinEmakalesayisi[i].ToString() + "/";
                    entity.YayinECount = model.YayinEdoktora.Count() - 1;
                }
            }


            if (model.YayinFdoktora.Count() > 1)
            {
                for (int i = 1; i < model.YayinFdoktora.Count(); i++)
                {

                    if (model.YayinFhatirlatici[i] != null) entity.YayinFhatirlatici += model.YayinFhatirlatici[i].ToString() + "/";
                    else entity.YayinFhatirlatici += "./";
                    entity.YayinFdoktora += model.YayinFdoktora[i].ToString() + "/";
                    entity.YayinFyazarsayisi += model.YayinFyazarsayisi[i].ToString() + "/";
                    entity.YayinFmakalesayisi += model.YayinFmakalesayisi[i].ToString() + "/";
                    entity.YayinFCount = model.YayinFdoktora.Count() - 1;
                }
            }


            if (model.YayinGdoktora.Count() > 1)
            {
                for (int i = 1; i < model.YayinGdoktora.Count(); i++)
                {

                    if (model.YayinGhatirlatici[i] != null) entity.YayinGhatirlatici += model.YayinGhatirlatici[i].ToString() + "/";
                    else entity.YayinGhatirlatici += "./";
                    entity.YayinGdoktora += model.YayinGdoktora[i].ToString() + "/";
                    entity.YayinGyazarsayisi += model.YayinGyazarsayisi[i].ToString() + "/";
                    entity.YayinGmakalesayisi += model.YayinGmakalesayisi[i].ToString() + "/";
                    entity.YayinGCount = model.YayinGdoktora.Count() - 1;
                }
            }

            /********* K İ T A P *********/



            if (model.KitapAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.KitapAdoktora.Count(); i++)
                {

                    if (model.KitapAhatirlatici[i] != null) entity.KitapAhatirlatici += model.KitapAhatirlatici[i].ToString() + "/";
                    else entity.KitapAhatirlatici += "./";
                    entity.KitapAdoktora += model.KitapAdoktora[i].ToString() + "/";
                    entity.KitapAyazarsayisi += model.KitapAyazarsayisi[i].ToString() + "/";
                    entity.KitapAkitap += model.KitapAkitap[i].ToString() + "/";
                    entity.KitapACount = model.KitapAdoktora.Count() - 1;
                }
            }

            if (model.KitapBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.KitapBdoktora.Count(); i++)
                {

                    if (model.KitapBhatirlatici?[i] != null) entity.KitapBhatirlatici += model.KitapBhatirlatici[i].ToString() + "/";
                    else entity.KitapBhatirlatici += "./";
                    entity.KitapBdoktora += model.KitapBdoktora[i].ToString() + "/";
                    entity.KitapBbolumSayisi += model.KitapBbolumSayisi[i].ToString() + "/";
                    entity.KitapByazarsayisi += model.KitapByazarsayisi[i].ToString() + "/";
                    entity.KitapBCount = model.KitapBdoktora.Count() - 1;
                }
            }

            if (model.KitapCdoktora.Count() > 1)
            {
                for (int i = 1; i < model.KitapCdoktora.Count(); i++)
                {

                    if (model.KitapChatirlatici[i] != null) entity.KitapChatirlatici += model.KitapChatirlatici[i].ToString() + "/";
                    else entity.KitapChatirlatici += "./";
                    entity.KitapCdoktora += model.KitapCdoktora[i].ToString() + "/";
                    entity.KitapCyazarsayisi += model.KitapCyazarsayisi[i].ToString() + "/";
                    entity.KitapCkitap += model.KitapCkitap[i].ToString() + "/";
                    entity.KitapCCount = model.KitapCdoktora.Count() - 1;
                }
            }

            if (model.KitapDdoktora.Count() > 1)
            {
                for (int i = 1; i < model.KitapDdoktora.Count(); i++)
                {

                    if (model.KitapDhatirlatici[i] != null) entity.KitapDhatirlatici += model.KitapDhatirlatici[i].ToString() + "/";
                    else entity.KitapDhatirlatici += "./";
                    entity.KitapDdoktora += model.KitapDdoktora[i].ToString() + "/";
                    entity.KitapDbolumSayisi += model.KitapDbolumSayisi[i].ToString() + "/";
                    entity.KitapDyazarsayisi += model.KitapDyazarsayisi[i].ToString() + "/";
                    entity.KitapDCount = model.KitapDdoktora.Count() - 1;
                }
            }






            /********* A T I F L A R *********/


            if (model.AtiflarAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.AtiflarAdoktora.Count(); i++)
                {

                    if (model.AtiflarAhatirlatici[i] != null) entity.AtiflarAhatirlatici += model.AtiflarAhatirlatici[i].ToString() + "/";
                    else entity.AtiflarAhatirlatici += "./";
                    entity.AtiflarAdoktora += model.AtiflarAdoktora[i].ToString() + "/";
                    entity.AtiflarAatif += model.AtiflarAatif[i].ToString() + "/";
                    entity.AtiflarACount = model.AtiflarAdoktora.Count() - 1;
                }
            }

            if (model.AtiflarBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.AtiflarBdoktora.Count(); i++)
                {

                    if (model.AtiflarBhatirlatici[i] != null) entity.AtiflarBhatirlatici += model.AtiflarBhatirlatici[i].ToString() + "/";
                    else entity.AtiflarBhatirlatici += "./";
                    entity.AtiflarBdoktora += model.AtiflarBdoktora[i].ToString() + "/";
                    entity.AtiflarBatif += model.AtiflarBatif[i].ToString() + "/";
                    entity.AtiflarBCount = model.AtiflarBdoktora.Count() - 1;
                }
            }
            if (model.AtiflarCdoktora.Count() > 1)
            {
                for (int i = 1; i < model.AtiflarCdoktora.Count(); i++)
                {

                    if (model.AtiflarChatirlatici[i] != null) entity.AtiflarChatirlatici += model.AtiflarChatirlatici[i].ToString() + "/";
                    else entity.AtiflarChatirlatici += "./";
                    entity.AtiflarCdoktora += model.AtiflarCdoktora[i].ToString() + "/";
                    entity.AtiflarCatif += model.AtiflarCatif[i].ToString() + "/";
                    entity.AtiflarCCount = model.AtiflarCdoktora.Count() - 1;
                }
            }


            /********* D A N I Ş M A N L I K *********/

            if (model.DanismanlikAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.DanismanlikAdoktora.Count(); i++)
                {

                    if (model.DanismanlikAhatirlatici[i] != null) entity.DanismanlikAhatirlatici += model.DanismanlikAhatirlatici[i].ToString() + "/";
                    else entity.DanismanlikAhatirlatici += "./";
                    entity.DanismanlikAdoktora += model.DanismanlikAdoktora[i].ToString() + "/";
                    entity.DanismanlikAseviye += model.DanismanlikAseviye[i].ToString() + "/";
                    entity.DanismanlikAsayi += model.DanismanlikAsayi[i].ToString() + "/";
                    entity.DanismanlikACount = model.DanismanlikAdoktora.Count() - 1;
                }
            }

            if (model.DanismanlikBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.DanismanlikBdoktora.Count(); i++)
                {

                    if (model.DanismanlikBhatirlatici[i] != null) entity.DanismanlikBhatirlatici += model.DanismanlikBhatirlatici[i].ToString() + "/";
                    else entity.DanismanlikBhatirlatici += "./";
                    entity.DanismanlikBdoktora += model.DanismanlikBdoktora[i].ToString() + "/";
                    entity.DanismanlikBseviye += model.DanismanlikBseviye[i].ToString() + "/";
                    entity.DanismanlikBsayi += model.DanismanlikBsayi[i].ToString() + "/";
                    entity.DanismanlikBCount = model.DanismanlikBdoktora.Count() - 1;
                }
            }



            /********* A R A Ş T I R M A *********/



            if (model.ArastirmaAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.ArastirmaAdoktora.Count(); i++)
                {

                    if (model.ArastirmaAhatirlatici[i] != null) entity.ArastirmaAhatirlatici += model.ArastirmaAhatirlatici[i].ToString() + "/";
                    else entity.ArastirmaAhatirlatici += "./";
                    entity.ArastirmaAdoktora += model.ArastirmaAdoktora[i].ToString() + "/";
                    entity.ArastirmaAproje += model.ArastirmaAproje[i].ToString() + "/";
                    entity.ArastirmaACount = model.ArastirmaAdoktora.Count() - 1;
                }
            }

            if (model.ArastirmaBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.ArastirmaBdoktora.Count(); i++)
                {

                    if (model.ArastirmaBhatirlatici[i] != null) entity.ArastirmaBhatirlatici += model.ArastirmaBhatirlatici[i].ToString() + "/";
                    else entity.ArastirmaBhatirlatici += "./";
                    entity.ArastirmaBdoktora += model.ArastirmaBdoktora[i].ToString() + "/";
                    entity.ArastirmaBproje += model.ArastirmaBproje[i].ToString() + "/";
                    entity.ArastirmaBCount = model.ArastirmaBdoktora.Count() - 1;
                }
            }

            if (model.ArastirmaCdoktora.Count() > 1)
            {
                for (int i = 1; i < model.ArastirmaCdoktora.Count(); i++)
                {

                    if (model.ArastirmaChatirlatici[i] != null) entity.ArastirmaChatirlatici += model.ArastirmaChatirlatici[i].ToString() + "/";
                    else entity.ArastirmaChatirlatici += "./";
                    entity.ArastirmaCdoktora += model.ArastirmaCdoktora[i].ToString() + "/";
                    entity.ArastirmaCproje += model.ArastirmaCproje[i].ToString() + "/";
                    entity.ArastirmaCCount = model.ArastirmaCdoktora.Count() - 1;
                }
            }

            if (model.ArastirmaDdoktora.Count() > 1)
            {
                for (int i = 1; i < model.ArastirmaDdoktora.Count(); i++)
                {

                    if (model.ArastirmaDhatirlatici[i] != null) entity.ArastirmaDhatirlatici += model.ArastirmaDhatirlatici[i].ToString() + "/";
                    else entity.ArastirmaDhatirlatici += "./";
                    entity.ArastirmaDdoktora += model.ArastirmaDdoktora[i].ToString() + "/";
                    entity.ArastirmaDproje += model.ArastirmaDproje[i].ToString() + "/";
                    entity.ArastirmaDCount = model.ArastirmaDdoktora.Count() - 1;
                }
            }

            /********* T O P L A N T I *********/



            if (model.ToplantiAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.ToplantiAdoktora.Count(); i++)
                {

                    if (model.ToplantiAhatirlatici[i] != null) entity.ToplantiAhatirlatici += model.ToplantiAhatirlatici[i].ToString() + "/";
                    else entity.ToplantiAhatirlatici += "./";
                    entity.ToplantiAdoktora += model.ToplantiAdoktora[i].ToString() + "/";
                    entity.ToplantiAyazarsayisi += model.ToplantiAyazarsayisi[i].ToString() + "/";
                    entity.ToplantiAsayi += model.ToplantiAsayi[i].ToString() + "/";
                    entity.ToplantiACount = model.ToplantiAdoktora.Count() - 1;
                }
            }

            if (model.ToplantiBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.ToplantiBdoktora.Count(); i++)
                {

                    if (model.ToplantiBhatirlatici[i] != null) entity.ToplantiBhatirlatici += model.ToplantiBhatirlatici[i].ToString() + "/";
                    else entity.ToplantiBhatirlatici += "./";
                    entity.ToplantiBdoktora += model.ToplantiBdoktora[i].ToString() + "/";
                    entity.ToplantiByazarsayisi += model.ToplantiByazarsayisi[i].ToString() + "/";
                    entity.ToplantiBsayi += model.ToplantiBsayi[i].ToString() + "/";
                    entity.ToplantiBCount = model.ToplantiBdoktora.Count() - 1;
                }
            }




            /*********  E Ğ İ T İ M  *********/



            if (model.EgitimAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.EgitimAdoktora.Count(); i++)
                {

                    if (model.EgitimAhatirlatici[i] != null) entity.EgitimAhatirlatici += model.EgitimAhatirlatici[i].ToString() + "/";
                    else entity.EgitimAhatirlatici += "./";
                    entity.EgitimAdoktora += model.EgitimAdoktora[i].ToString() + "/";
                    entity.EgitimAders += model.EgitimAders[i].ToString() + "/";
                    entity.EgitimACount = model.EgitimAdoktora.Count() - 1;

                }
            }
            entity.Gorev2yil = model.Gorev2yil;
            if (model.EgitimBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.EgitimBdoktora.Count(); i++)
                {

                    if (model.EgitimBhatirlatici[i] != null) entity.EgitimBhatirlatici += model.EgitimBhatirlatici[i].ToString() + "/";
                    else entity.EgitimBhatirlatici += "./";
                    entity.EgitimBdoktora += model.EgitimBdoktora[i].ToString() + "/";
                    entity.EgitimBders += model.EgitimBders[i].ToString() + "/";
                    entity.EgitimBCount = model.EgitimBdoktora.Count() - 1;

                }
            }



            return entity;
        }
    }

}



