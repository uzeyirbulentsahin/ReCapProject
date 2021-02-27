using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (CarPhotoCount(carImage.CarId ) <= 5)
            { 
            
                ResimiHazirla(carImage);


            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.EntityAdded);
            }
            return new ErrorResult(Messages.EntityCountBig5);
        }


        private int CarPhotoCount(int carId) {
            int imgcount = _carImageDal.GetAll(p => p.CarId == carId).Count;
            return imgcount;
        }




        private void ResimiHazirla(CarImage carImage)
        {
            

            string GuidKey = Guid.NewGuid().ToString();
            string getfileName = Path.GetFileName(carImage.ImagePath.ToString());
            string getDirName = Path.GetDirectoryName(carImage.ImagePath.ToString());
            string getFileExtension = Path.GetExtension(carImage.ImagePath.ToString());
            string yeniDosyaAdi = GuidKey + getFileExtension;
            string yeniYol =Path.Combine("CarImages/", yeniDosyaAdi);
          
            carImage.ImagePath = yeniDosyaAdi;

            System.IO.File.Create(yeniYol);





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
