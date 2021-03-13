using Core.EntityFramework;
using Microsoft.EntityFrameworkCore;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;

namespace DataAccess.Concrete
{
    public class RentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    { 
            IMapper _mapper;
            public RentalDal (IMapper mapper)
            {
                        _mapper = mapper;
            }

        public List<RentalDetailDto> GetRentalDetailDtos()
        {

            //using (ReCapContext context = new ReCapContext())
            //{
            //    var result = context.Rentals.FromSqlInterpolated($"EXEC RentalView");

            //    var rentaldtos = _mapper.Map<List<RentalDetailDto>>(result);


            //    return rentaldtos.ToList();



            //}






            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers on r.CustomerId equals c.Id
                             join u in context.Users on c.UserId equals u.Id
                             join cr in context.Cars on r.CarId equals cr.Id
                             join b in context.Brands on cr.BrandId equals b.Id
                             select new RentalDetailDto
                             {
                                 CustomerName = c.CompanyName,
                                 UserName = u.FirstName + ' ' + u.LastName,
                                 CarModel = cr.ModelYear,
                                 CarName = b.Name,
                                 RentalDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();


            }

        }
    }
}

