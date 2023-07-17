using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProje.DAL.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityCount { get; set; }
        public string CityImageUrl { get; set; }
    }
}