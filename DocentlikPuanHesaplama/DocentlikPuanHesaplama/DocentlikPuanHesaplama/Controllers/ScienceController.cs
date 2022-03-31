using Microsoft.AspNetCore.Mvc;

namespace DocentlikPuanHesaplama.Controllers
{
    public class ScienceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult pResult()
        {
            // yine .cshtml dosyasını render etmemizi sağlar 
            // view resulttan temel farkı  client tabanlı yapılan 
            //ajax isteklerinde kullanımı sağlanır bu sayede sayfayı komple değiştirmek yerine
            // sayfanın bir kısmı değişir.
            PartialViewResult result = PartialView();
            return result;
        }

    }
}
