using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProject.DTO;
using static PersonelProject.Models.Data.PersonelEntities;
using static PersonelProject.Repository.Repository;

namespace PersonelProject.Controllers
{

    public class CityController : Controller
    {
        private readonly RepCity _repCity;
        private readonly IMapper _Mapper;
        public CityController(RepCity repCity, IMapper Mapper)
        {
            _repCity = repCity;
            _Mapper = Mapper;
        }
        public IActionResult Liste()
        {
            //var cities = await _repCity.ListAll();
            //cities = _Mapper.Map()
            var cityList = _repCity.Doldur();
            return Json(cityList);
        }
        public async Task<IActionResult> Detay(int id)
        {
            var city = await _repCity.Find(id);
            return Json(city);
        }
        [HttpPut]
        public async Task<IActionResult> Guncel([FromBody]CityDTO cityDto)
        {
            City c = new City();
            //c.Id = cityDto.cityId;
            //c.CityName = cityDto.name;
            c = _Mapper.Map(cityDto, c);
            _repCity.Update(c);
            await _repCity.Comit();
            return Json(cityDto);
            
        }
        [HttpDelete]
        public async Task<IActionResult> Sil(int id)
        {
            
            City c = await _repCity.Find(id);
            _repCity.Delete(c);
            await _repCity.Comit();
            return Json(c);
        }
        [HttpPost]
        public async Task<IActionResult> Ekle([FromBody]CityDTO cDto)
        {
            City c = new City();
            //c.CityName = cDto.name;
            //c.Image = cDto.cityImage;
            c = _Mapper.Map(cDto, c);
            _repCity.Add(c);
            await _repCity.Comit();
            return Json(cDto);
        }
    }
}