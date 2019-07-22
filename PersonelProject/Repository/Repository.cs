using PersonelProject.DTO;
using PersonelProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PersonelProject.Models.Data.PersonelEntities;

namespace PersonelProject.Repository
{
    public class Repository
    {

        public class RepPersonel : BaseRepository<Personel>
        {
            public RepPersonel(PersonelContext db) : base(db)
            {

            }

            public ICollection<PersonelDTO> Doldur()
            {
                return Set().Select(x => new PersonelDTO
                {
                    personelId = x.Id,
                    name = x.Name,
                    surName = x.Surname,
                    city = x.City.CityName
                }).ToList();
            }
        }
        public class RepCity : BaseRepository<City>
        {
            public RepCity(PersonelContext db) : base(db)
            {

            }
            public ICollection<CityDTO> Doldur()
            {
                return Set().Select(x => new CityDTO
                {
                    cityId = x.Id,
                    name = x.CityName,
                    cityImage = x.Image
                }).ToList();

            }
            
            
            
            //public async Task<List<City>> Doldur()
            //{
            //    return await ListAll();
            //}


        }
        public class RepPerGallery : BaseRepository<PersonelGallery>
        {
            public RepPerGallery(PersonelContext db) : base(db)
            {

            }

        }
        public class RepCityGallery : BaseRepository<CityGallery>
        {
            public RepCityGallery(PersonelContext db) : base(db)
            {

            }

        }
    }
}
