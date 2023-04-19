using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjePersonelBusiness.Abstract;
using ProjePersonelModel.Entities;

namespace ProjePersonelMVC.Controllers
{
    public class MissionController : Controller
    {
        private readonly IMissionService _missionService;
        private readonly IDepartmanService _departmanService;
        public MissionController(IMissionService missionService,IDepartmanService departmanService)
        {
            _missionService = missionService;
            _departmanService = departmanService;
        }
        public IActionResult Index()
        {
             var result=_missionService.GetAllFull();
            return View(result);
        }
        [HttpGet]
        public IActionResult GorevEkle()
        {
            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName");

            return View(new Mission() );
        }
        [HttpPost]
        public IActionResult GorevEkle(Mission mission)
        {
            _missionService.Add(new Mission
            {
                MissionName = mission.MissionName,
                DepartmanID = mission.DepartmanID,
                Description = mission.Description,
                IsActive = true,
                IsDeleted = false,

            });
            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GorevGuncelle(int id)
        {
            var result=_missionService.GetById(id);

            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName", result.DepartmanID);

            return View(result);
        }

       

        [HttpPost]
        public IActionResult GorevGuncelle(Mission mission)
        {
            
                _missionService.Update(new Mission
                {
                    MissionID = mission.MissionID,
                    DepartmanID = mission.DepartmanID,
                    MissionName = mission.MissionName,
                    Description = mission.Description,
                    IsActive = mission.IsActive,
                    IsDeleted = mission.IsDeleted,


                });
                
            
           
            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName", mission.DepartmanID);

            return RedirectToAction("Index");
        }



        public IActionResult GetByDepartmanID(int id)
        {
            var result = _missionService.GetByDepartmanID(id);
            return View(result);
        }

        //public IActionResult GorevSil(int id)
        //{
        //    _missionService.Delete(new Mission { MissionID = id });
        //    return Json(null);
        //}
    }
}
