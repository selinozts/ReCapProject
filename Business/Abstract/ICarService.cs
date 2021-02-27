using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface ICarService
   {
        void Add(Car car);
       List<Car> GetAll();
       List<Car> GetsCarByColorId(int id);

       List<Car> GetsCarByBrandId(int id);
    }
}
