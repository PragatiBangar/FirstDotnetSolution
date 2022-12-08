using CatalogLib;
using OrderProcessingLib;
using CRMLib;

//dotnet cli
//dotnet new console -o testapp

//Entry point logic : main function logic

Product p1 = new Product();
p1.Id = 15;
p1.Title = "Rose";
p1.Description = "Red Flower";
p1.UnitPrice = 25 ;
p1.StockAvailable = 30000;
p1.ImageUrl = "http://wordpress.com/ravitambade/logo.jpg";

Console.WriteLine(p1.Description);
Console.WriteLine(p1.ImageUrl);
Console.WriteLine(p1.Title);

Order o1 = new Order();
o1.OrderId = 32 ;
o1.OrderDate = new DateTime(2022,12,18);
o1.Customer = "Microsoft";
o1.TotalAmount = 45000 ;
o1.Status = "Approved";
 
Console.WriteLine(o1.OrderDate);
Console.WriteLine(o1.Status);
Console.WriteLine(o1.Customer);


Customer c1 = new Customer();
c1.CustomerId = 53;
c1.FirstName = "Pragati";
c1.LastName = "Bangar";
c1.ContactNumber = "7498035692";
c1.Email = "bangarpragati11@gmail.com";

Console.WriteLine(c1.FirstName);
Console.WriteLine(c1.LastName);
Console.WriteLine(c1.Email);