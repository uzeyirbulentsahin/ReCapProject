using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColor_Service
    {
        List<Color_> GetAll();
        Color_ GetById(int colorId);
        void Add(Color_ color);
        void Update(Color_ color);
        void Deleted(Color_ color);
    }
}
