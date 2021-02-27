using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public string CarName { get; set; }
        public int CarModel { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
   
    }
}
