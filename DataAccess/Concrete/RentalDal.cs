using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class RentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.Id
                             join u in context.Users
                             on c.UserId equals u.Id
                             join cr in context.Cars
                             on r.CarId equals cr.Id
                             join b in context.Brands
                             on cr.BrandId equals b.Id
                              select new RentalDetailDto
                              {
                                  CustomerName = c.CompanyName,
                                  UserName = u.FirstName + ' ' +  u.LastName ,
                                  CarModel = cr.ModelYear,
                                  CarName = cr.Description,
                                  RentalDate = r.RentDate,
                                  ReturnDate = r.ReturnDate
                              };



                                return result.ToList();

            }

        }
    }
}

