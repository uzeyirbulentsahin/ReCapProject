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
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {
            //c# guid oluştur
            //yolundanresmi al
            //adını değiştir ve yeni kalsore yerleştir
            //yeni yolunu kaydet

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.EntityAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.EntityDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
           return new SuccessDataResult< List < CarImage >>( _carImageDal.GetAll(),Messages.EntityListed );

        }

        public IDataResult<CarImage> GetById(int carImageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c=>c.CarId==carImageId ), Messages.EntityListed);

        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.EntityUpdated);
        }
    }
}
