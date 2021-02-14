using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandManager brandManager = new BrandManager(new BrandDal());
            //brandManager.Add(new Brand {Name="Mercedes"});
            //brandManager.Add(new Brand {Name="Audi"});
            //brandManager.Add(new Brand {Name="Renault"});
            //brandManager.Add(new Brand {Name="Honda"});

            //Color_Manager color_Manager = new Color_Manager(new Color_Dal());
            //color_Manager.Add(new Color_ { Name = "Mavi" });
            //color_Manager.Add(new Color_ { Name = "Kırmızı" });
            //color_Manager.Add(new Color_ {  Name = "Siyah" });

            //CarManager carManager = new CarManager(new CarDal());

            //carManager.Add(new Car {BrandId=2,ColorId=1,ModelYear=2019,Description="Audi" });
            //carManager.Add(new Car {BrandId=1,ColorId=2,ModelYear=2019,Description="Mercedes" });
            //carManager.Add(new Car {BrandId=2,ColorId=3,ModelYear=2019,Description="Renault" });
            //carManager.Add(new Car {BrandId=1,ColorId=1,ModelYear=2019,Description="Mercedes" });

            //foreach (var car in carManager.GetAll() )
            //{

            //    Console.WriteLine(car.Description);
            //}

            //CarManager carManager = new CarManager(new CarDal());
            //foreach (var car in carManager.GetCarDetailDtos())
            //{

            //    Console.WriteLine(car.BrandName + " " + car.ColorName +" " + car.ModelYear +" "+ car.Description);
            //}

            CarManager carManager = new CarManager(new CarDal());

            //carManager.Update(new Car { Id = 1, BrandId = 2, ColorId = 1,ModelYear=2020,  DailyPrice = 25.57,Description="Mercsedes"});


            //var result = carManager.GetById(1);
            //                Console.WriteLine(result.BrandId  + " " + result.ColorId  + " " + result.ModelYear + " "+ result.DailyPrice  + " " + result.Description);

            carManager.Delete(new Car { Id = 1, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 25.57, Description = "Mercsedes" });



        }
    }
}
