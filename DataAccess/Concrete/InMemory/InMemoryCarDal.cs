using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=1250, ModelYear=2004, Description="Renault ucuz arabanın en iyisi ve beyaz!"},
                new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=4000, ModelYear=2021, Description="Renault siyah renkli son model araç!"},
                new Car{Id=3, BrandId=2, ColorId=4, DailyPrice=3120, ModelYear=2011, Description="Kamyon gibi BMW sevenlere... :)"},
                new Car{Id=4, BrandId=3, ColorId=1, DailyPrice=2150, ModelYear=2009, Description="Canımızı bu temiz Volvo'ya emanet etmez misiniz?"},
                new Car{Id=5, BrandId=19, ColorId=7, DailyPrice=44725, ModelYear=2018, Description="Kırmızı spor araba... Sen anla! :)"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.FirstOrDefault(c=>car.Id==c.Id);

            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c=>c.Id==id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
           Car carToUpdate = _car.FirstOrDefault(c=>car.Id==c.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
