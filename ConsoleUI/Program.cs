using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarRentalContext carRentalContext = new CarRentalContext();
//foreach (var car in carRentalContext.Cars)
//{
//    Console.WriteLine(car.Description);
//}  

//CarTest();
//GetCarDetailsTest();
//GetAllCustomerTest();
//GetAllRentalTest();


CarManager carManager = new CarManager(new EfCarDal());

var result = carManager.GetCarDetails();
if (result.Success == true)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.Description);
    }
}
else
{
    Console.WriteLine(result.Message);
}


static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetAll().Data)
    {
        Console.WriteLine(car.Description);
    }
}

static void GetCarDetailsTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetCarDetails().Data)
    {
        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
    }
}

static void GetAllCustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    var result1 = customerManager.GetAll();
    if (result1.Success)
    {
        foreach (var customer in result1.Data)
        {
            Console.WriteLine(customer.CompanyName);
        }
    }
    else
    {
        Console.WriteLine(result1.Message);
    }
}

static void GetAllRentalTest()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());
    var result2 = rentalManager.GetAll();

    if (result2.Success)
    {
        foreach (var rental in result2.Data)
        {
            Console.WriteLine(rental.RentDate);
        }
    }
    else
    {
        Console.WriteLine(result2.Message);
    }
}