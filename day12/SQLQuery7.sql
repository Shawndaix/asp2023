use NORTHWND;
go

select country from Customers;
select distinct country from Customers;

select * from Customers order by Country;

select * from Customers where CompanyName like 'a%';

select * from Customers where CompanyName like '_r%';


select * from Customers where City = 'London';

update Customers set CompanyName = 'Toronto Cosco' where CustomerID='AROUT';

use NORTHWND;
go
delete from Customers where CustomerID='AROUT';

select * from Orders where CustomerID='AROUT';

use Market;
go

select * from Customers;
delete from Customers where customerID=11;