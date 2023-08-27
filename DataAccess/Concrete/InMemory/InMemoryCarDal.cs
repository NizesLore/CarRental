using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { CarId=1, BrandId=1, ColorId=1, ModelYear= 2023, DailyPrice=8000, Description="MERCEDES"},
            new Car { CarId=2, BrandId=1, ColorId=2, ModelYear= 2022, DailyPrice=10000, Description="BMW"},
            new Car { CarId=3, BrandId=2, ColorId=1, ModelYear= 2021, DailyPrice=12000, Description="VOLKSWAGEN"},
            new Car { CarId=4, BrandId=2, ColorId=2, ModelYear= 2020, DailyPrice=14000, Description="AUDI"},
            new Car { CarId=5, BrandId=3, ColorId=3, ModelYear= 2019, DailyPrice=16000, Description="TOYOTA"}

        };
                    
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;

        }

        public Car GetByBrand (int brandId)
        {
            return _cars.SingleOrDefault(c=> c.BrandId == brandId);
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        //public List<Car> GetAllByBrand(int brandId)
        //{
        //    return _cars.Where(c=> c.BrandId== brandId).ToList();
        //}
    }
}
