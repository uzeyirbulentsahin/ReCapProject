using Business.Abstract;
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

        public void Add(Color_ color)
        {
            _color_Dal.Add(color);
        }

        public void Deleted(Color_ color)
        {
            _color_Dal.Delete(color);
        }

        public List<Color_> GetAll()
        {
           return  _color_Dal.GetAll();
        }

        public Color_ GetById(int colorId)
        {
            return _color_Dal.Get(c=>c.Id==colorId);
        }

        public void Update(Color_ color)
        {
            _color_Dal.Update(color);
        }
    }
}
