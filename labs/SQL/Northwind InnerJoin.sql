/* products grouped by supplier ID */
select p.SupplierID, companyname, avg(unitsonorder) as 'AvgOrder'
From Products p
JOIN Suppliers s on p.SupplierID = s.SupplierID
group by p.SupplierID, CompanyName
having avg(unitsonorder)>0
order by AvgOrder desc
