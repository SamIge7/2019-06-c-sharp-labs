/* Operators e.g * */
select*from [Order Details]
/* Products Price Quantity %Discount */
select*, unitprice *quantity as 'Gross Order' from [Order Details]
/* include discount*/
select*, unitprice *quantity as 'Gross Order', 
unitprice * quantity * (1-discount) as 'Net Order' from [Order Details]
order by 'Net Order' desc

/* aggregate sum, avg, min, max, count */
select sum(UnitPrice) from [Order Details] where ProductID = '38'

select avg(quantity) from [Order Details]

select min(unitprice) from [Order Details]

select max(unitprice) from [Order Details]

select count(quantity) from [Order Details]

/* Group by */
select*from Products
/*can we list products by supplierID?*/
select*from Products order by SupplierID
/* statistics (sum, avg) per supplier?*/
select supplierid from Products order by SupplierID
/*total units in stock per supplier?*/
select supplierid,
sum(unitsinstock) as Stock,
sum(unitsonorder) as OnOrder,
max(unitsonorder) as MaxOrder 
from Products 
group by SupplierID order by Stock desc

/* Use Group by to calculate the Average reorder level for all products by CatagoryID */
select avg(reorderlevel) as AvgReorder,
CategoryID
from Products
group by CategoryID
/*What is the highest average reorder level?*/
select avg(reorderlevel) as AvgReorder,
CategoryID
from Products
group by CategoryID
order by AvgReorder desc

/* Having */
select avg(reorderlevel) as AvgReorder,
CategoryID
from Products
where categoryID = 5 or CategoryID = 1
group by CategoryID
having avg(reorderlevel) > 10
order by AvgReorder desc
/*when we group by a certain column, calculating a statistical aum/avg/min/max etc the regular 'where' clause is not applicable because the statistic has not yet been calculated. Replace with 'having' after group by to fix this.*/

select avg(UnitsInStock) as AvgStock,
ProductID
from Products
group by ProductID
having avg(unitsinstock) > 15
order by AvgStock desc