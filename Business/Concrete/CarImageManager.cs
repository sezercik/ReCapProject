using Business.Abstract;
using Business.Constants;
using Core.Results;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _imageHelper;
        public CarImageManager(ICarImageDal carImageDal, IFileHelper imageHelper)
        {
            _carImageDal = carImageDal;
            _imageHelper = imageHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageLimitExceeded(carImage.CarId));
            if(result == null)
            {
                carImage.ImagePath = _imageHelper.Upload(file,Paths.Root).Message;
                Console.WriteLine("Sonuç: " + carImage.ImagePath);
                carImage.Date = DateTime.Now;
                _carImageDal.Add(carImage);
                return new SuccessResult(Messages.CarImagesAdded);
            }
            return new ErrorResult(Messages.CarImagesNotAdded);
        }
        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = _imageHelper.Update(file, Paths.Root + carImage.ImagePath, Paths.Root).Message;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        public IResult Delete(CarImage carImage)
        {
            _imageHelper.Delete(Paths.Root + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);

        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if(result.Count == 0)
            {
                var defaultResult = getDefaultImage(carId);
                return new SuccessDataResult<List<CarImage>>(defaultResult);
            }
            return new SuccessDataResult<List<CarImage>>(result);

        }


        public IDataResult<CarImage> GetById(int imageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == imageId));
        }

        public  IResult CheckIfCarImageLimitExceeded(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if(result < 5)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.CarImageLimitExceeded);
        }


        private List<CarImage> getDefaultImage(int carId)
        {
            List<CarImage> result = new();
            result.Add(new CarImage { CarId = carId, ImagePath = Paths.DefaultCarImageShort, Date = DateTime.Now });
            return result;
        }
    }
}
