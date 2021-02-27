﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Model.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetsCarByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetsCarByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }

   
}
