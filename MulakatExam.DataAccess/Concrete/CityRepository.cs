using MulakatExam.DataAccess.Interface;
using MulakatExam.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MulakatExam.DataAccess.Concrete
{
    public class CityRepository : ICityRepository
    {
        private IGetData getData;
        public CityRepository(IGetData getData)
        {
            this.getData = getData;
        }

        public List<District> DistrictsOfTheCity(string CityName)
        {
            return getData.getData().Find(i => i.CityName.ToLower() == CityName.ToLower()).Districts;
        }

        public List<City> GetAllCities()
        {
            return getData.getData();
        }

        public int GetCityCount()
        {
            return getData.getData().Count;
        }

       
    }
}
