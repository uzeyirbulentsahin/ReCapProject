using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<CarDetailDto> GetCarDetailDtos();
        Car GetById(int CarId);
        void Add(Car car);
        void Update(Car car);
        void Deleted(Car car);
    }
}
