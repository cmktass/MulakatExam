using MulakatExam.DataAccess.Interface;
using MulakatExam.Entity.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MulakatExam.DataAccess.Concrete
{
    public class GetDataThenCsv : IGetData
    {
        private string path;

        public GetDataThenCsv(string path)
        {
            this.path = path;
        }
        public List<City> getData()
        {
            string[] allLines = File.ReadAllLines(path);
            List<City> cities = new List<City>();

            string[] data = allLines[1].Split(',');
            City city = new City();
            city.CityName = data[0];
            city.CityCode = Int32.Parse(data[1]);
            District district = new District();
            district.DistrictName = data[2];
            district.ZipCodes.Add(Int32.Parse(data[3]));
            city.Districts.Add(district);
            cities.Add(city);
            int a = 0;
            for (int i = 2; i < allLines.Length; i++)
            {
                string[] data2 = allLines[i].Split(',');
                if (cities[a].CityCode != Int32.Parse(data2[1]))
                {
                    a++;
                    city = new City();
                    city.CityName = data2[0];
                    city.CityCode = Int32.Parse(data2[1]);
                    district = new District();
                    district.DistrictName = data2[2];
                    district.ZipCodes.Add(Int32.Parse(data[3]));
                    city.Districts.Add(district);
                    cities.Add(city);
                }
                else
                {
                    if (cities[a].Districts[cities[a].Districts.Count - 1].DistrictName == data2[2])
                    {
                        cities[a].Districts[cities[a].Districts.Count - 1].ZipCodes.Add(Int32.Parse(data[3]));
                    }

                    else
                    {
                        district = new District();
                        district.DistrictName = data2[2];
                        district.ZipCodes.Add(Int32.Parse(data[3]));
                        cities[a].Districts.Add(district);
                    }
                }
            }
            return cities;
        }
    }
}
