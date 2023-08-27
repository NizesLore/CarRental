using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<Rental> GetByRentalId(int rentalId);
        IDataResult<Rental> GetRentalByCarId(int carId);
        //IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
