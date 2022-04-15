using WebMvc.Models.DocentModels.Models;
using Core.Models.Entities;

namespace WebMvc.Helpers.ConvertToModel
{
    static public class MuhendislikConvert
    {
        static public MuhendislikEntity MuhendislikModelToMuhendislikEntity(MuhendislikDocentModel model)
        {
            /*********** Hesaplama yaparken ilk indexten geleni hesaplama o numune olan************/

            MuhendislikEntity entity = new();

            /***   M a k a l e l e r  ***/
            if (model.MakalelerAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.MakalelerAdoktora.Count(); i++)
                {

                    if (model.MakalelerAhatirlatici[i] != null) entity.MakalelerAhatirlatici += model.MakalelerAhatirlatici[i].ToString() + "/";
                    else entity.MakalelerAhatirlatici += "./";
                    entity.MakalelerAdoktora += model.MakalelerAdoktora[i].ToString() + "/";
                    entity.MakalelerAyazarsayisi += model.MakalelerAyazarsayisi[i].ToString() + "/";
                    entity.MakalelerAmakalesayisi += model.MakalelerAmakalesayisi[i].ToString() + "/";
                    entity.MakalelerAbasYazar += model.MakalelerAbasYazar[i].ToString() + "/";
                    entity.MakalelerAsirasi += model.MakalelerAsirasi[i].ToString() + "/";
                    entity.MakalelerACount = model.MakalelerAdoktora.Count() - 1;
                }
            }

            if (model.MakalelerBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.MakalelerBdoktora.Count(); i++)
                {

                    if (model.MakalelerBhatirlatici[i] != null) entity.MakalelerBhatirlatici += model.MakalelerBhatirlatici[i].ToString() + "/";
                    else entity.MakalelerBhatirlatici += "./";
                    entity.MakalelerBdoktora += model.MakalelerBdoktora[i].ToString() + "/";
                    entity.MakalelerByazarsayisi += model.MakalelerByazarsayisi[i].ToString() + "/";
                    entity.MakalelerBmakalesayisi += model.MakalelerBmakalesayisi[i].ToString() + "/";
                    entity.MakalelerBbasYazar += model.MakalelerBbasYazar[i].ToString() + "/";
                    entity.MakalelerBsirasi += model.MakalelerBsirasi[i].ToString() + "/";
                    entity.MakalelerBCount = model.MakalelerBdoktora.Count() - 1;
                }
            }

            if (model.MakalelerCdoktora.Count() > 1)
            {
                for (int i = 1; i < model.MakalelerCdoktora.Count(); i++)
                {

                    if (model.MakalelerChatirlatici[i] != null) entity.MakalelerChatirlatici += model.MakalelerChatirlatici[i].ToString() + "/";
                    else entity.MakalelerChatirlatici += "./";
                    entity.MakalelerCdoktora += model.MakalelerCdoktora[i].ToString() + "/";
                    entity.MakalelerCyazarsayisi += model.MakalelerCyazarsayisi[i].ToString() + "/";
                    entity.MakalelerCmakalesayisi += model.MakalelerCmakalesayisi[i].ToString() + "/";
                    entity.MakalelerCbasYazar += model.MakalelerCbasYazar[i].ToString() + "/";
                    entity.MakalelerCsirasi += model.MakalelerCsirasi[i].ToString() + "/";
                    entity.MakalelerCCount = model.MakalelerCdoktora.Count() - 1;
                }
            }


            /********  P A T E N T  ********/
            if (model.PatentAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.PatentAdoktora.Count(); i++)
                {

                    if (model.PatentAhatirlatici[i] != null) entity.PatentAhatirlatici += model.PatentAhatirlatici[i].ToString() + "/";
                    else entity.PatentAhatirlatici += "./";
                    entity.PatentAdoktora += model.PatentAdoktora[i].ToString() + "/";
                    entity.PatentAyazarsayisi += model.PatentAyazarsayisi[i].ToString() + "/";
                    entity.PatentAsayi += model.PatentAsayi[i].ToString() + "/";
                    entity.PatentACount = model.PatentAdoktora.Count() - 1;
                }
            }

            if (model.PatentBdoktora.Count() > 1)
            {
                for (int i = 1; i < model.PatentBdoktora.Count(); i++)
                {

                    if (model.PatentBhatirlatici[i] != null) entity.PatentBhatirlatici += model.PatentBhatirlatici[i].ToString() + "/";
                    else entity.PatentBhatirlatici += "./";
                    entity.PatentBdoktora += model.PatentBdoktora[i].ToString() + "/";
                    entity.PatentByazarsayisi += model.PatentByazarsayisi[i].ToString() + "/";
                    entity.PatentBsayi += model.PatentBsayi[i].ToString() + "/";
                    entity.PatentBCount = model.PatentBdoktora.Count() - 1;
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
                    entity.YayinAmakalesayisi += model.YayinAmakalesayisi[i].ToString() + "/";
                    entity.YayinAbasYazar += model.YayinAbasYazar[i].ToString() + "/";
                    entity.YayinAsirasi += model.YayinAsirasi[i].ToString() + "/";
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
                    entity.YayinBmakalesayisi += model.YayinBmakalesayisi[i].ToString() + "/";
                    entity.YayinByazarsayisi += model.YayinByazarsayisi[i].ToString() + "/";
                    entity.YayinBbasYazar += model.YayinBbasYazar[i].ToString() + "/";
                    entity.YayinBsirasi += model.YayinBsirasi[i].ToString() + "/";
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
                    entity.YayinCbildiri += model.YayinCbildiri[i].ToString() + "/";
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
                    entity.YayinDbildiri += model.YayinDbildiri[i].ToString() + "/";
                    entity.YayinDyazarsayisi += model.YayinDyazarsayisi[i].ToString() + "/";
                    entity.YayinDCount = model.YayinDdoktora.Count() - 1;
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
