using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.Models.Data
{
    public class PersonelEntities
    {
        [Table("Personel")]
        public class Personel
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Image { get; set; }
            public int CityId { get; set; }
            [ForeignKey("CityId")]
            public virtual City City { get; set; }
            public virtual ICollection<PersonelGallery> PersonelGallery { get; set; }
        }
        [Table("City")]
        public class City
        {
            [Key]
            public int Id { get; set; }
            public string CityName { get; set; }
            public string Image { get; set; }
            public virtual ICollection<Personel> Personel { get; set; }
            public virtual ICollection<CityGallery> CityGallery { get; set; }
        }
        [Table("PersonelGallery")]
        public class PersonelGallery
        {
            [Key]
            public int Id { get; set; }
            public string Image { get; set; }
            public int PersonelId { get; set; }
            [ForeignKey("PersonelId")]
            public virtual Personel Personel { get; set; }
        }
        [Table("CityGallery")]
        public class CityGallery
        {
            [Key]
            public int Id { get; set; }
            public string Image { get; set; }
            public int CityId { get; set; }
            [ForeignKey("CityId")]
            public virtual City City { get; set; }
        }
    }
}
