﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        Car GetByBrand (int brandId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        //List<Car> GetAllByBrand (int brandId);


    

    }
}