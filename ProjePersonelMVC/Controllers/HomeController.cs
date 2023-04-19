using Microsoft.AspNetCore.Mvc;
using ProjePersonelBusiness.Abstract;
using ProjePersonelMVC.Models;
using System.Diagnostics;

namespace ProjePersonelMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonnelService _personnelService;
        private readonly IDepartmanService _departmanService;


        public HomeController(ILogger<HomeController> logger,IPersonnelService personnelService,IDepartmanService departmanService)
        {
            _logger = logger;
            _personnelService = personnelService;
            _departmanService = departmanService;
        }

        public IActionResult Index()
        {

            ViewBag.AktifCalisanPersonelSayisi = _personnelService.GetirAktifCalisanPersonel();
            ViewBag.IstenAyrilmisPersonelSayisi = _personnelService.GetirAyrilmisCalisanPersonel();
            ViewBag.AktifDepartmanSayisi = _departmanService.GetirToplamDepartmanSayisi();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}