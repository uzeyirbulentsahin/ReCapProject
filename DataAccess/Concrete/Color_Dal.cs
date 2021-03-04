
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class Color_Dal:EfEntityRepositoryBase<Color_,ReCapContext>,IColor_Dal
    {
    }
}
