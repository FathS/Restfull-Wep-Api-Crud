using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.DTO
{
    public class PersonelDTO
    {
        public int personelId { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string city { get; set; }
        public int cityId { get; set; }
    }
}
