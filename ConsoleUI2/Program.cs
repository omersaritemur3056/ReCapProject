using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();

            //CarDetailTest();

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CustomerId = 111,
                UserId = 1111,
                CompanyName = "Turşuu İmalat"
            });
            

        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);

            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 184, ColorName = "Turkuaz" });
            foreach (var color in colorManager.GetAll().Data)
            {
                //Console.WriteLine("{0} --- {1}" + color.ColorName, color.ColorId);
                Console.WriteLine(color.ColorName + " id'si : " + color.ColorId);
            }

            Console.WriteLine("Değişiklik ten sonra----------------------------");

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Delete(new Color { ColorId = 100, ColorName = "Beyaz"});
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName + " id'si : " + color.ColorId);
            //}

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car();

            //carManager.Add(new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=1250, ModelYear=1992, Description="İd tekrarına düştüm, umarım konsola basmaz... :)"});
            //carManager.Add(new Car { DailyPrice = 9250, ModelYear=2016, Description="Benzersiz deneyim sunan sürpriz araba..." });
            //carManager.Delete(new Car { Id = 3}); başarılı oldu 3 id'li Mercedesi sildi :)

            foreach (var car1 in carManager.GetAll().Data)
            {
                Console.WriteLine(car1.Description + " id'si : " + car1.Id);
            }
        }
    }
}