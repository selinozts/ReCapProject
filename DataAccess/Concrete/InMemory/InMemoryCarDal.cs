using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice =146000 , ModelYear = 2014, Model = "Alfa Romeo"},
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 209750, ModelYear = 2017, Model = "Honda" },
                new Car { Id = 3, BrandId = 3, ColorId = 5, DailyPrice = 272000, ModelYear = 2018, Model = "Hyundai" },
                new Car { Id = 4, BrandId = 4, ColorId = 3, DailyPrice = 197500, ModelYear = 2020, Model = "Nissan" },
                new Car { Id = 5, BrandId = 5, ColorId = 4, DailyPrice = 202500, ModelYear = 2016, Model = "Volkswagen" },
                new Car { Id = 6, BrandId = 6, ColorId = 2, DailyPrice = 839000, ModelYear = 2015, Model = "Tesla" }
            };
        }



        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByld(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToUpdate);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Model = car.Model;

        }
    }
}
