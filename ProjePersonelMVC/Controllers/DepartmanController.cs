using Microsoft.AspNetCore.Mvc;
using ProjePersonelBusiness.Abstract;
using ProjePersonelModel.Entities;

namespace ProjePersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        private readonly IDepartmanService _departmanService;
        public DepartmanController(IDepartmanService departmanService)
        {
            _departmanService = departmanService;
        }
        public IActionResult Index()
        {
            var result=_departmanService.GetAll();
            return View(result);
        }

        public IActionResult GetirDepartmanPersonel(int id)
        {
            var result=_departmanService.GetirDepartmanCalisanPersonel(id);
            return View(result);
        }
        [HttpGet]
        public IActionResult EkleDepartman()
        {

            return View(new Departman());
        }
        [HttpPost]
        public IActionResult EkleDepartman(Departman departman)
        {
           
                _departmanService.Add(new Departman()
                {
                    DepartmanName=departman.DepartmanName,
                    Description=departman.Description,
                    IsActive=true,
                    IsDeleted=false
                });
                return RedirectToAction("Index");
           
        }
        [HttpGet]
        public IActionResult GuncelleDepartman(int id)
        { var result=_departmanService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult GuncelleDepartman(Departman departman)
        {
            _departmanService.Update(new Departman
            {
                DepartmanID = departman.DepartmanID,
                Description = departman.Description,
                IsActive = departman.IsActive,
                IsDeleted = departman.IsDeleted,
                DepartmanName = departman.DepartmanName,
            });
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            _departmanService.Delete(new Departman { DepartmanID = id });
            return RedirectToAction("Index");
        }

    }
}
