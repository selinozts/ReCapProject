using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
   class Program
    {
        static void Main(string[] args)
        {
            //AddCarTest();
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car
            {
                Id=5,
                Model = "BMW",
                BrandId = 4,
                ColorId = 2,
                DailyPrice = 250,
                ModelYear = 2019
            };  

            carManager.Update(car);
            //carManager.Delete(car);

            GetAllDetailTest();


            Console.ReadKey();

        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car
            
            {
                Model = "Tesla",
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 350,
                ModelYear = 2019
            };

            carManager.Add(car);
        }

        private static void GetAllDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllDetails())
            {
                Console.WriteLine($"{car.Id} {car.Brand} {car.Model} {car.ModelYear} {car.Color} {car.DailyPrice} ");
            }
        }
       
    }
}
