using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<Car> GetAll();

        List<CarDetailDto> GetAllDetails();

        List<Car> GetsCarByColorId(int id);

        List<Car> GetsCarByBrandId(int id);
    }
}