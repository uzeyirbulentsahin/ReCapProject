using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class Color_Manager : IColor_Service
    {
        IColor_Dal _color_Dal;

        public Color_Manager(IColor_Dal color_Dal)
        {
            _color_Dal = color_Dal;
        }

        public IResult Add(Color_ color)
        {
            _color_Dal.Add(color);
            return new SuccessResult(Messages.EntityAdded );
        }

        public IResult Deleted(Color_ color)
        {
            _color_Dal.Delete(color);
            return new SuccessResult(Messages.EntityDeleted );
        }

        public IDataResult<List<Color_>> GetAll()
        {
           return new SuccessDataResult<List<Color_>>(  _color_Dal.GetAll(),Messages.EntityListed );
        }

        public IDataResult<Color_> GetById(int colorId)
        {
           
            return new SuccessDataResult<Color_>(_color_Dal.Get(c => c.Id == colorId), Messages.EntityListed);
        }

        public IResult Update(Color_ color)
        {
            _color_Dal.Update(color);
            return new SuccessResult(Messages.EntityUpdated) ;
        }
    }
}
