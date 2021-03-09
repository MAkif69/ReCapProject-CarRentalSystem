using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {



            //CarManager carManager = new CarManager(new EfCarDal());
            //UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //CarAddTest(carManager);
            //UserAddTest(userManager);
            //GetAllTest();
            RentalAddTest(rentalManager);



        }
        private static void RentalAddTest(RentalManager rentalManager)
                {
                    rentalManager.Add(new Rental {CarId=1,CustomerID=1,
                                      RentDate=DateTime.Now,ReturnDate=null});
                    foreach (var rental in rentalManager.GetAll().Data)
                    {
                        Console.WriteLine(rental.CarId);
                    }
                }
        private static void UserAddTest(UserManager userManager)
        {
            userManager.Add(new User { FirstName = "Akif", LastName = "HAşlak", Email = "abc@gmail.com", Password = "123456" });
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }

        private static void CarAddTest(CarManager carManager)
        {
            carManager.Add(new Car {BrandId=1,ColorId=1,CarName="Skoda",
                            DailyPrice=150,Description="H",ModelYear=2010});
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName+ " " +car.ModelYear);
            }
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetailDtos();

            if (result.Success==true)
            {
              foreach (var car in result.Data)
                     {
                        Console.WriteLine(car.CarName);
                     }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
          
        }
    }

   
}
