using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MulakatExam.DataAccess.Interface;
using MulakatExam.Entity.Entities;

namespace MulakatExam.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CityApiController : ControllerBase
    {
        private ICityRepository cityRepository;

        public CityApiController(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        
        public List<City> GetAllData()
        {
            return cityRepository.GetAllCities();
        }

        [HttpGet("DistrictsOfTheCity/{CityName}")]
        public List<District> DistrictsOfTheCity(string CityName)
        {
            return cityRepository.DistrictsOfTheCity(CityName);
        }

        [HttpGet("GetCityCount")]
        public int getCityCount()
        {
            return cityRepository.GetCityCount();
        }

    }
}
