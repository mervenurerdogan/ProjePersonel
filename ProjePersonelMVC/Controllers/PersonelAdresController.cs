using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjePersonelBusiness.Abstract;
using ProjePersonelModel.Entities;

namespace ProjePersonelMVC.Controllers
{
    public class PersonelAdresController : Controller
    {
        private readonly IPersonnelAddressService _personnelAddressService;
        private readonly IPersonnelService _personnelService;
        public PersonelAdresController(IPersonnelAddressService personnelAddressService,IPersonnelService personnelService)
        {
            _personnelAddressService = personnelAddressService;
            _personnelService = personnelService;
        }
        public IActionResult Index()
        {
            var result = _personnelAddressService.GetFullAll();
            return View(result);
        }

        public IActionResult GetByPersonelID(int id)
        {
            var result = _personnelAddressService.GetByPersonelID(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult PersonelAdresEkle()
        {
            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name");
            return View(new PersonnelAddress());
        }

        [HttpPost]
        public IActionResult PersonelAdresEkle(PersonnelAddress  personnelAddress)
        {
            _personnelAddressService.Add(new PersonnelAddress
            {
                Address = personnelAddress.Address,
                AddressDescription = personnelAddress.AddressDescription,
                PersonnelID = personnelAddress.PersonnelID,
                IsActive = true,
                IsDeleted = false,

            });
            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PhoneAdresGuncelle(int id)
        {
            var result=_personnelAddressService.GetById(id);
            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name",result.PersonnelID);
            return View(result);
        }
        [HttpPost]
        public IActionResult PhoneAdresGuncelle(PersonnelAddress personnelAddress)
        {
            _personnelAddressService.Update(new PersonnelAddress
            {
                AdressID = personnelAddress.AdressID,
                AddressDescription = personnelAddress.AddressDescription,
                Address = personnelAddress.Address,
                PersonnelID = personnelAddress.PersonnelID,
                IsActive = personnelAddress.IsActive,
                IsDeleted = personnelAddress.IsDeleted
            });
            ViewBag.Personeller = new SelectList(_personnelService.GetAll(), "PersonnelID", "Name", personnelAddress.PersonnelID);

            return RedirectToAction("Index");
        }

    }
}
