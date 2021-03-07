using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join cl in context.Colors on c.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Brand = b.Name,
                                 Color = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Model = c.Model,
                                 ModelYear = c.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}