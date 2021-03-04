
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.EntityFramework;

namespace DataAccess.Concrete
{
    public class CarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (ReCapContext context=new ReCapContext()) 
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto { BrandName = b.Name, ColorName = cl.Name,
                                 ModelYear = c.ModelYear, Description = c.Description };
                return result.ToList();
            }

        }
    }
}
