using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol;
using ProjePersonelBusiness.Abstract;
using ProjePersonelModel.Entities;

namespace ProjePersonelMVC.Controllers
{
    public class PersonnelController : Controller
    {
        private readonly IPersonnelService _personnelService;
        private readonly IMissionService _missionService;
        private readonly IDepartmanService _departmanService;
        private readonly IGenderService _genderService;
        public PersonnelController(IPersonnelService personnelService,IMissionService missionService,IDepartmanService departmanService,IGenderService genderService)
        {
            _personnelService = personnelService;
            _missionService = missionService;
            _departmanService = departmanService;
            _genderService=genderService;
        }
        public IActionResult Index()
        {
            var result= _personnelService.GetAllFull();
            return View(result);
        }

        public IActionResult IstenAyrılanPersonel()
        {
            var result = _personnelService.GetNoIsActivePersonnel();
            return View(result);  
        }

        public IActionResult CalisanPersonel()
        {
            var result = _personnelService.GetIsActivePersonnel();
            return View(result);
        }


        [HttpGet]
        public IActionResult EklePersonel()
        {
            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName");
            ViewBag.Gorevler = new SelectList(_missionService.GetAll(), "MissionID", "MissionName");
            ViewBag.Cinsiyetler = new SelectList(_genderService.GetAll(), "GenderID", "GenderName");

            return View(new Personnel());
        }


        [HttpPost]
        public IActionResult EklePersonel(Personnel personnel)
        {
            _personnelService.Add(new Personnel
            {
                IdentityNumber = personnel.IdentityNumber,
                Name = personnel.Name,
                Surname = personnel.Surname,
                BirthDate = personnel.BirthDate,
                EducationStatus = personnel.EducationStatus,
                PlaceOfBirth = personnel.PlaceOfBirth,
                FinishWorkDate = personnel.FinishWorkDate,
                StartWorkDate = personnel.StartWorkDate,
                Email = personnel.Email,
                SummaryInfoPersonnel = personnel.SummaryInfoPersonnel,
                DepartmanID = personnel.DepartmanID,
                GenderID = personnel.GenderID,
                MissionID = personnel.MissionID,
                IsActive = true,
                IsDeleted = false

            });
            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName");
            ViewBag.Gorevler = new SelectList(_missionService.GetAll(), "MissionID", "MissionName");
            ViewBag.Cinsiyetler = new SelectList(_genderService.GetAll(), "GenderID", "GenderName");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GuncellePersonel(int id)
        {
            var result=_personnelService.GetById(id);
            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName",result.DepartmanID);
            ViewBag.Gorevler = new SelectList(_missionService.GetAll(), "MissionID", "MissionName",result.MissionID);
            ViewBag.Cinsiyetler = new SelectList(_genderService.GetAll(), "GenderID", "GenderName",result.GenderID);
            return View(result);
        }

        [HttpPost]
        public IActionResult GuncellePersonel(Personnel personnel)
        {
            _personnelService.Update(new Personnel
            {
                PersonnelID=personnel.PersonnelID,
                DepartmanID=personnel.DepartmanID,
                GenderID=personnel.GenderID,
                MissionID=personnel.MissionID,
                IdentityNumber=personnel.IdentityNumber,
                Name=personnel.Name,
                Surname=personnel.Surname,
                BirthDate=personnel.BirthDate,
                PlaceOfBirth=personnel.PlaceOfBirth,
                EducationStatus=personnel.EducationStatus,
                StartWorkDate=personnel.StartWorkDate,
                FinishWorkDate=personnel.FinishWorkDate,
                Email=personnel.Email,
                SummaryInfoPersonnel=personnel.SummaryInfoPersonnel,
                IsDeleted=personnel.IsDeleted,
                IsActive=personnel.IsActive,
            });
            ViewBag.Departmanlar = new SelectList(_departmanService.GetAll(), "DepartmanID", "DepartmanName", personnel.DepartmanID);
            ViewBag.Gorevler = new SelectList(_missionService.GetAll(), "MissionID", "MissionName", personnel.MissionID);
            ViewBag.Cinsiyetler = new SelectList(_genderService.GetAll(), "GenderID", "GenderName", personnel.GenderID);
            return RedirectToAction("Index");
        }


   
        public IActionResult PersonelSil(int id)
        {
            _personnelService.Delete(new Personnel { PersonnelID=id});
            return RedirectToAction("Index");
        }

        //public IActionResult PersonelSilmedenSilme(int id)
        //{
        //    var deger=_personnelService.GetById(id);

        //    deger.IsActive =false;
        //    return View(deger);
        //}
        //[HttpPost]
        //public IActionResult PersonelSilmedenSilme(Personnel personel)
        //{
        //     _personnelService.Update(new Personnel
        //    {
        //        PersonnelID = personel.PersonnelID,
        //        IsActive=false

        //    });


        //    return RedirectToAction("Index");
        //}

    }
}
