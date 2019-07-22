using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PersonelProject.Models.Data.PersonelEntities;

namespace PersonelProject.DTO
{
    public class CityDTO
    {
        public int cityId { get; set; }
        public string name { get; set; }
        public string cityImage { get; set; }
        //public ICollection<CityGallery> cityGallery { get; set; }
    }
}
