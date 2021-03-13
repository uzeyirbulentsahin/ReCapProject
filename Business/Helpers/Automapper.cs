using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Helpers
{
    public class Automapper:Profile
    {
        public Automapper()
        {
            CreateMap<Rental, RentalDetailDto>().ReverseMap();
        }

    }
}
