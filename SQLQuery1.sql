create table Customers (CustomerId int, UserId int, CompanyName nvarchar(50));
create table Users( UserId int, FirstName nvarchar(50), LastName nvarchar(50), Email nvarchar(50), Password nvarchar (50));
create table Rentals(RentalId int, CarId int, CustomerId int, RentDate datetime, ReturnDate datetime);