using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjePersonelBusiness.Abstract;
using ProjePersonelModel.Entities;
using System.Reflection;

namespace ProjePersonelMVC.Controllers
{
    public class PhoneNumberController : Controller
    {
        private readonly IPersonnelPhoneNumberService _personnelPhoneNumberService;
        private readonly IPersonnelService _personnelService;
        public PhoneNumberController(IPersonnelService personnelService,IPersonnelPhoneNumberService personnelPhoneNumberService)
        {
            _personnelPhoneNumberService = personnelPhoneNumberService;
            _personnelService = personnelService;
        }

        public IActionResult Index()
        {
            var result = _personnelPhoneNumberService.GetFullAll();
            return View(result);
        }

        public IActionResult GetByPersonelID(int id)
        {
            var result = _personnelPhoneNumberService.GetByPersonelID(id);
            return View(result);
        }
        [HttpGet]
        public IActionResult PhoneNumberEkle()
        {
            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name");
            return View(new PersonelPhoneNumber());
        }
        [HttpPost]
        public IActionResult PhoneNumberEkle(PersonelPhoneNumber personelPhoneNumber)
        {
            _personnelPhoneNumberService.Add(new PersonelPhoneNumber
            {
                PhoneNumber = personelPhoneNumber.PhoneNumber,
                NumberDescription = personelPhoneNumber.NumberDescription,
                PersonnelID = personelPhoneNumber.PersonnelID,
                IsActive = true,
                IsDeleted = false
            });
            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PhoneNumberGuncelle(int id)
        {
            var result = _personnelPhoneNumberService.GetById(id);

            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name", result.PersonnelID);

            return View(result);
        }

      
      

        [HttpPost]
        public IActionResult PhoneNumberGuncelle(PersonelPhoneNumber personelPhoneNumber)
        {
            _personnelPhoneNumberService.Update(new PersonelPhoneNumber()
            {
                PersonnelPhoneNumberID = personelPhoneNumber.PersonnelPhoneNumberID,
                NumberDescription=personelPhoneNumber.NumberDescription,
                PhoneNumber= personelPhoneNumber.PhoneNumber,
                PersonnelID = personelPhoneNumber.PersonnelID,
                IsActive = personelPhoneNumber.IsActive,
                IsDeleted = personelPhoneNumber.IsDeleted,


            });
            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name", personelPhoneNumber.PersonnelID);
           
            return RedirectToAction("Index");
        }

        public IActionResult NumaraSil(int id)
        {
            _personnelPhoneNumberService.Delete(new PersonelPhoneNumber { PersonnelPhoneNumberID = id });
            return RedirectToAction("Index");
        }



    }
}
