using MulakatExam.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MulakatExam.DataAccess.Interface
{
    public interface ICityRepository
    {
        List<City> GetAllCities();

        int GetCityCount();

        List<District> DistrictsOfTheCity(string CityName);

        
    }
}
