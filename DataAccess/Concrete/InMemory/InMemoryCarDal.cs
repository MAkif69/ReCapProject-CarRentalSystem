using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : IEntityRepository<Car>
    {
        List<Car> _cars;

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car> {
        //        new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=2019,Description="Ford Mondeo TDI"},
        //         new Car{CarId=2,BrandId=1,ColorId=2,DailyPrice=250,ModelYear=2010,Description="Mercedes"},
        //          new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=300,ModelYear=2020,Description="Skoda Yeti"},
        //           new Car{CarId=4,BrandId=2,ColorId=3,DailyPrice=400,ModelYear=2015,Description="Ford Focus"},
        //            new Car{CarId=5,BrandId=3,ColorId=4,DailyPrice=500,ModelYear=2021,Description="TOGG"}
        //    };
        //}
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    _cars.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Car> GetAllCarId(int carId)
        //{
        //    return _cars.Where(c => c.CarId == carId).ToList();
        //}

        //public List<Car> GetById(Car car)
        //{
        //    throw new NotImplementedException();
        //}

        //public void GetCarsByBrandId(Car entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void GetCarsByColorId(Car entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Description = car.Description;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.ModelYear = car.ModelYear;
        //}
    }
}
