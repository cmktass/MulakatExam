using MulakatExam.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MulakatExam.DataAccess.Interface
{
    public interface IGetData
    {
        List<City> getData();
    }
}
