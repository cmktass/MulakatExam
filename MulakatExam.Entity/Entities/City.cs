using System;
using System.Collections.Generic;
using System.Text;

namespace MulakatExam.Entity.Entities
{
    public class City
    {
        public City()
        {
            Districts = new List<District>();
        }
        public string CityName { get; set; }

        public int CityCode { get; set; }

        public List<District> Districts { get; set; }
    }
}
