using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PersonelProject.Models.Data.PersonelEntities;

namespace PersonelProject.Models.Data
{
    public class PersonelContext:DbContext
    {
        DbSet<Personel> Personel { get; set; }
        DbSet<City> City { get; set; }
        DbSet<PersonelGallery> PersonelGallery { get; set; }
        DbSet<CityGallery> CityGallery { get; set; }
        public PersonelContext(DbContextOptions<PersonelContext> option) : base(option)
        {

        }
    }
}
