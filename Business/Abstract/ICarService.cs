using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
      
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IDataResult<Car> GetById(int CarId);
        IResult Add(Car car);

        IResult AddTransactionalTest(Car car);



    }
}
