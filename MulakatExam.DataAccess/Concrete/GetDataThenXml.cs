using MulakatExam.DataAccess.Interface;
using MulakatExam.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MulakatExam.DataAccess.Concrete
{
    public class GetDataThenXml : IGetData
    {
        private string path;

        public GetDataThenXml(string path)
        {
            this.path = path;
        }
        public List<City> getData()
        {
            List<City> cities = new List<City>();
            City city = new City();
            District district = new District();


            XmlTextReader oku = new XmlTextReader("sample_data.xml");

            while (oku.Read()) //Dosyadaki veriler tükenene kadar okuma işlemi devam eder.
            {
                if (oku.NodeType == XmlNodeType.Element)//Düğümlerdeki veri element türünde ise okuma gerçekleşir.
                {

                    if (oku.Name == "City")
                    {
                        city = new City();
                        city.CityName = oku.GetAttribute("name");
                        city.CityCode = Int32.Parse(oku.GetAttribute("code"));
                        cities.Add(city);
                    }
                    if (oku.Name == "District")
                    {
                        district = new District();
                        district.DistrictName = oku.GetAttribute("name");
                        city.Districts.Add(district);
                    }
                    if (oku.Name == "Zip")
                    {
                        district.ZipCodes.Add(Int32.Parse(oku.GetAttribute("code")));
                    }

                }
            }
            return cities;
        }
    }
}
