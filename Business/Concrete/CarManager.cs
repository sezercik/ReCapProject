using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private IProductDal _productDal;

        public CarManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Add(Car car)
        {
           _productDal.Add(car);
        }

        public void Update(Car car)
        {
            _productDal.Update(car);
        }

        public void Delete(Car car)
        {
            _productDal.Delete(car);
        }
    }
}
