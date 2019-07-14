select*from Products where Discontinued = '0' and CategoryID = '1'
select*from Categories

Select*From Customers where City = 'London' or City = 'New York'

Select*From Customers where City != 'Berlin'

Select*From Products where UnitPrice > 10.99

Select*From Products where UnitPrice < 35.99

Select distinct(Country) From Customers order by country desc
Select distinct(City) From Customers order by City desc

Select*From Products where ProductName like'%ch%'
Select*From Products where ProductName like '[ABC]%'
Select*From Products where ProductName like '[^ABC]%'

Select*From Products where ProductName like 'ch__'

Select*From Customers where region in ('BC', 'SP', 'OR')

select*from Products where UnitsInStock between 0 and 30 order by UnitsInStock desc

/* quoted identifier */
SET quoted_identifier off
Select*from Products where ProductName like "%'%"

Select*from Products where UnitPrice < 5.00
Select*from Categories where CategoryName like '[bs]'
Select Count(*) from Orders where EmployeeID in (5,7)

/* as */
select CustomerID as ID, Address + ', ' + City + ', ' + Country as location from Customers

select distinct Country from Customers where Region IS NOT NULL
select count(distinct Country) from Customers where Region IS NOT NULL