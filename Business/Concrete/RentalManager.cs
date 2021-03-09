using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentaDal;

        public RentalManager(IRentalDal rentaDal)
        {
            _rentaDal = rentaDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentaDal.GetAll(p => p.CarId == rental.CarId && p.ReturnDate > DateTime.Now).ToList();
            if (result.Count != 0)
            {
                return new ErrorResult(Messages.RentalAdded);
            }
            else
            {
                _rentaDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentaDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentaDal.GetAll(), Messages.RentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentaDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
