using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColor_Service
    {
        IDataResult<List<Color_>> GetAll();
        IDataResult<Color_> GetById(int colorId);
        IResult Add(Color_ color);
        IResult Update(Color_ color);
        IResult Deleted(Color_ color);
    }
}
