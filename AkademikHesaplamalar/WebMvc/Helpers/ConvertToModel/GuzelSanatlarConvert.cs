using WebMvc.Models.DocentModels.Models;
using Core.Models.Entities;

namespace WebMvc.Helpers.ConvertToModel
{
    public class GuzelSanatlarConvert
    {
        static public GuzelSanatlarEntity GuzelSanatlarModelToGuzelSanatlarEntity(GuzelSanatlarDocentModel model)
        {
            GuzelSanatlarEntity entity = new();

            /***  S İ N E M A  ***/
            if (model.SinemaIDoktora.Count() > 1)
            {
                for (int i = 1; i < model.SinemaIDoktora.Count(); i++)
                {

                    if (model.SinemaIHatirlatici[i] != null) entity.SinemaIHatirlatici += model.SinemaIHatirlatici[i].ToString() + "/";
                    else entity.SinemaIHatirlatici += "./";
                    entity.SinemaIDoktora += model.SinemaIDoktora[i].ToString() + "/";
                    entity.SinemaIEtkinlikSayisi += model.SinemaIEtkinlikSayisi[i].ToString() + "/";
                    entity.SinemaICount = model.SinemaIDoktora.Count() - 1;
                }
            }

            if (model.SinemaIIDoktora.Count() > 1)
            {
                for (int i = 1; i < model.SinemaIIDoktora.Count(); i++)
                {

                    if (model.SinemaIIHatirlatici[i] != null) entity.SinemaIIHatirlatici += model.SinemaIIHatirlatici[i].ToString() + "/";
                    else entity.SinemaIIHatirlatici += "./";
                    entity.SinemaIIDoktora += model.SinemaIIDoktora[i].ToString() + "/";
                    entity.SinemaIIEtkinlikSayisi += model.SinemaIIEtkinlikSayisi[i].ToString() + "/";
                    entity.SinemaIICount = model.SinemaIIDoktora.Count() - 1;
                }
            }

            if (model.SinemaIIIDoktora.Count() > 1)
            {
                for (int i = 1; i < model.SinemaIIIDoktora.Count(); i++)
                {

                    if (model.SinemaIIIHatirlatici[i] != null) entity.SinemaIIIHatirlatici += model.SinemaIIIHatirlatici[i].ToString() + "/";
                    else entity.SinemaIIIHatirlatici += "./";
                    entity.SinemaIIIDoktora += model.SinemaIIIDoktora[i].ToString() + "/";
                    entity.SinemaIIIEtkinlikSayisi += model.SinemaIIIEtkinlikSayisi[i].ToString() + "/";
                    entity.SinemaIIICount = model.SinemaIIIDoktora.Count() - 1;
                }
            }

            if (model.SinemaIVDoktora.Count() > 1)
            {
                for (int i = 1; i < model.SinemaIVDoktora.Count(); i++)
                {

                    if (model.SinemaIVHatirlatici[i] != null) entity.SinemaIVHatirlatici += model.SinemaIVHatirlatici[i].ToString() + "/";
                    else entity.SinemaIVHatirlatici += "./";
                    entity.SinemaIVEtkinlikSayisi += model.SinemaIVEtkinlikSayisi[i].ToString() + "/";
                    entity.SinemaIVDoktora += model.SinemaIVDoktora[i].ToString() + "/";
                    entity.SinemaIVTur += model.SinemaIVTur[i].ToString() + "/";
                    entity.SinemaIVCount = model.SinemaIVDoktora.Count() - 1;
                }
            }
          
            if (model.SinemaVDoktora.Count() > 1)
            {
                for (int i = 1; i < model.SinemaVDoktora.Count(); i++)
                {

                    if (model.SinemaVHatirlatici[i] != null) entity.SinemaVHatirlatici += model.SinemaVHatirlatici[i].ToString() + "/";
                    else entity.SinemaVHatirlatici += "./";
                    entity.SinemaVDoktora += model.SinemaVDoktora[i].ToString() + "/";
                    entity.SinemaVEtkinlikSayisi += model.SinemaVEtkinlikSayisi[i].ToString() + "/";
                    entity.SinemaVCount = model.SinemaVDoktora.Count() - 1;
                }
            }



            return entity;
        }
    }
}
