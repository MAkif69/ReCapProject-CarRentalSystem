using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalDBContex>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (RentalDBContex contex = new RentalDBContex())
            {
                var result = from c in contex.Cars
                             join b in contex.Brands
                             on c.BrandId equals b.BrandId

                             join cl in contex.Colors
                             on c.ColorId equals cl.ColorId
                             where c.BrandId == cl.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                
                             };
                return result.ToList();

            }
        }
        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (RentalDBContex contex = new RentalDBContex())
            {
                var result = from c in contex.Cars
                             join b in contex.Brands
                             on c.BrandId equals b.BrandId

                             join cl in contex.Colors
                             on c.ColorId equals cl.ColorId
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                
                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (RentalDBContex contex = new RentalDBContex())
            {
                var result = from c in contex.Cars
                             join b in contex.Brands
                             on c.BrandId equals b.BrandId

                             join cl in contex.Colors
                             on c.ColorId equals cl.ColorId
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                
                             };
                return result.ToList();
            }
        }
    }
}
