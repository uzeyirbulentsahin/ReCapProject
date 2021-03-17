using Core.Utilities.Results;
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
        IDataResult<List<CarDetailDto>> GetAllByColor(int ColorId);
        IDataResult<List<CarDetailDto>> GetAllByBrand(int BrandId);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IDataResult<Car> GetById(int CarId);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
