using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonelProject.DTO;
using static PersonelProject.Models.Data.PersonelEntities;
using static PersonelProject.Repository.Repository;

namespace PersonelProject.Controllers
{
    public class PersonelController : Controller
    {
        private readonly RepPersonel _repPersonel;
        public PersonelController(RepPersonel repPersonel)
        {
            _repPersonel = repPersonel;
        }
        public IActionResult Liste()
        {
            var plist = _repPersonel.Doldur();
            return Json(plist);
        }
        [HttpPost]
        public async Task<IActionResult> Ekle([FromBody]PersonelDTO pDto)
        {
            Personel per = new Personel();
            per.Name = pDto.name;
            per.Surname = pDto.surName;
            per.CityId = pDto.cityId;
            _repPersonel.Add(per);
            await _repPersonel.Comit();
            return Json(pDto);
        }
        [HttpPost]
        public async Task<IActionResult> Sil(int id)
        {
            Personel p = await _repPersonel.Find(id);
            _repPersonel.Delete(p);
            await _repPersonel.Comit();
            return Json(p);
        }
        [HttpPost]
        public async Task<IActionResult> Guncel([FromBody]PersonelDTO pDto)
        {
            Personel per = new Personel();
            per.Name = pDto.name;
            per.Surname = pDto.surName;
            per.CityId = pDto.cityId;
            _repPersonel.Update(per);
            await _repPersonel.Comit();
            return Json(pDto);
        }
    }
}