using System;
using System.Collections.Generic;
using System.Text;

namespace MulakatExam.Entity.Entities
{
    public class District
    {
        public District()
        {
            ZipCodes = new List<int>();
        }
        public string DistrictName { get; set; }

        public List<int> ZipCodes { get; set; }
    }
}
