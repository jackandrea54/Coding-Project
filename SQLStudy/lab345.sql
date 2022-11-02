use northwind

--1.Write a SELECT query to display Full name of all employees in lower-case 
select lower(LastName + ' ' + FirstName) as [Full name], TitleOfCourtesy from Employees

--2.Write a SELECT query to display Full name of all employees in upper-case 
select upper(LastName + ' ' + FirstName) as [Full name] from Employees

--3.Write a SELECT query to display all employees that are from United States 
select EmployeeID, LastName, FirstName, Title, City, Country 
from Employees where Country like '%USA%'

--4.Write a SELECT query to display all customers that are from UK 
select CustomerID, CompanyName, ContactName, ContactTitle, Country from Customers where Country like '%UK%'

--5.Write a SELECT query to display all customers that are from Mexico
select CustomerID, CompanyName, Address, City, Country from Customers where Country like '%Mexico%'

--6.Write a SELECT query to display all customers that are from Sweden 
select CustomerID, CompanyName, Phone, Address, City, Country from Customers where Country like '%Sweden%'

--7.In Products table, values of UnitsInStock tell you the total units in the inventory of every product.
--Write a SELECT query to display product id, product name, unit price of all products such that their total units in the inventory is between 5 and 10
select ProductID, ProductName, UnitPrice, UnitsInStock from Products where UnitsInStock between 5 and 10

--8.In Products table, the value of UnitsOnOrder tells you the total ordered units for every product. 
--Write a SELECT query to display product id, product name, unit price, re-order level… of all products 
--that have total ordered units between 60 and 100
select ProductID, ProductName, UnitPrice, ReorderLevel, UnitsOnOrder from Products where UnitsOnOrder between 60 and 100

--9.Write a SELECT query to display total orders of every employee in 1996 
select Employees.EmployeeID, LastName, FirstName, Title, 
		YEAR(OrderDate) as year, 
		COUNT(Employees.EmployeeID) as [total orders] 
from Employees
left join
Orders 
on Employees.EmployeeID = Orders.EmployeeID 
group by Employees.EmployeeID,  LastName, FirstName, Title, YEAR(OrderDate)
having YEAR(OrderDate) = 1996

--10.Write a SELECT query to display total orders of every employee in 1998
select Employees.EmployeeID, LastName, FirstName, City, Country, 
		COUNT(Employees.EmployeeID) as [total orders] 
from Employees, Orders
where Employees.EmployeeID = Orders.EmployeeID
group by Employees.EmployeeID, LastName, FirstName, City, Country, 
			YEAR(Orders.OrderDate)
having YEAR(Orders.OrderDate) = 1998

--11.Write a SELECT query to display total orders of every employee from 1/1/1998 to 31/7/1998 - orderDate 
select Employees.EmployeeID, LastName, FirstName, HireDate, 
		COUNT(Employees.EmployeeID) as [total orders] 
from Employees, Orders
where Employees.EmployeeID = Orders.EmployeeID 
	and Orders.OrderDate between '1998-1-1' and '1998-7-31'
group by Employees.EmployeeID, LastName, FirstName, HireDate

--12.Write a SELECT query to display total orders of every employee from 1/1/1997 to 30/6/1997
with EmployeeTotal as (select EmployeeID, COUNT(OrderID) as [total orders] from Orders where OrderDate between '1997-1-1' and '1997-6-30' group by EmployeeID)
select Employees.EmployeeID, LastName, FirstName, HireDate, HomePhone, [total orders] 
from Employees, EmployeeTotal 
where Employees.EmployeeID = EmployeeTotal.EmployeeID 


select Employees.EmployeeID, LastName, FirstName, HireDate, HomePhone, 
		COUNT(Employees.EmployeeID) as [total orders] 
from Employees, Orders
where Employees.EmployeeID = Orders.EmployeeID 
	and Orders.OrderDate between '1997-1-1' and '1997-6-30'
group by Employees.EmployeeID, LastName, FirstName, HireDate, HomePhone


--13.An order will be taxed 10% if its freight cost is larger than or equal to 100$.
--Otherwise, an order will be taxed 5% if its freight cost is smaller than 100$. 
--Write a SELECT query to show the freight with taxes of orders placed between 1/8/1996 and 5/8/1996 
select OrderID, DAY(OrderDate) as OrderDay, MONTH(OrderDate) as OrderMonth,
		 YEAR(OrderDate) as OrderYear, Freight, 
		 case when (Freight >= 100) 
			then '10%' 
			else '5%' end as tax, 
		 case when (Freight >= 100) 
			then Freight + Freight * 0.1 
			else Freight + Freight * 0.05 end as [Freight with tax] 
from Orders
where OrderDate between '1996-8-1' and '1996-8-5'

--14.Write a SELECT query to display the full name, title of courtesy and sex for all employees such that:
--	If title of courtesy is ‘Mr.’ then sex is set to ‘Male’
--	If title of courtesy is ‘Ms.’ or ‘Mrs.’ then sex is set to ‘Female’
select LastName + ' ' + FirstName as [Full name], TitleOfCourtesy, 
case when (TitleOfCourtesy like 'Ms.' or TitleOfCourtesy like 'Mrs.') 
	then 'Female' 
	else 'Male' end as Sex 
from Employees

--15.Write a SELECT query to display the full name, title of courtesy and sex for all employees such that:
--	If title of courtesy is ‘Mr.’ or ‘Dr.’ then sex is set to ‘M’
--	If title of courtesy is ‘Ms.’ or ‘Mrs.’ then sex is set to ‘F’
select LastName + ' ' + FirstName as [Full name], TitleOfCourtesy, 
	case when (TitleOfCourtesy like 'Ms.' or TitleOfCourtesy like 'Mrs.') 
		then 'Female' 
		else 'Male' end as Sex 
from Employees

--16.Write a SELECT query to display the full name, title of courtesy and sex for all employees such that:
--	If title of courtesy is ‘Mr.’ then sex is set to ‘Male’
--	If title of courtesy is ‘Ms.’ or ‘Mrs.’ then sex is set to ‘Female’
--	If title of courtesy is not ‘Mr.’ and not ‘Mrs.’ and not ‘Ms.’ then sex is set to ‘Unknown’
select LastName + ' ' + FirstName as [Full name], TitleOfCourtesy, 
		case when (TitleOfCourtesy like 'Ms.' or TitleOfCourtesy like 'Mrs.') 
			then 'Female' 
			else case when (TitleOfCourtesy like 'Mr.') 
				then 'Male' 
				else 'Unknown' end 
		end as Sex 
from Employees

--17.Write a SELECT query to display the full name, title of courtesy and sex for all employees
--	If title of courtesy is ‘Mr.’ then sex is set to 1
--	If title of courtesy is ‘Ms.’ or ‘Mrs.’ then sex is set to 0
--	If title of courtesy is not ‘Mr.’ and not ‘Mrs.’ and not ‘Ms.’ then sex is set to 2
select LastName + ' ' + FirstName as [Full name], TitleOfCourtesy, 
case when (TitleOfCourtesy like 'Ms.' or TitleOfCourtesy like 'Mrs.') then 0 
else case when (TitleOfCourtesy like 'Mr.') then 1 
else 2 end end as Sex from Employees

--18.Write a SELECT query to display the full name, title of courtesy and sex for all employees such that:
--	If title of courtesy is ‘Mr.’ then sex is set to ‘M’
--	If title of courtesy is ‘Ms.’ or ‘Mrs.’ then sex is set to ‘F’
--	If title of courtesy is not ‘Mr.’ and not ‘Mrs.’ and not ‘Ms.’ then sex is set to ‘N/A’
select LastName + ' ' + FirstName as [Full name], TitleOfCourtesy, 
case when (TitleOfCourtesy like 'Ms.' or TitleOfCourtesy like 'Mrs.') then 'F' 
else case when (TitleOfCourtesy like 'Mr.') then 'M' 
else 'N/A' end end as Sex from Employees

--21.Write a query to determine the revenues for all products from 1/7/1996 to 5/7/1996 
--as following (Revenue = Quantity * Unitprice). 
--Note: The output must be order by category id and then product id.
select Products.CategoryID, CategoryName,  Products.ProductID, ProductName, DAY(OrderDate) as day, MONTH(OrderDate) as month, YEAR(OrderDate) as year, Quantity * [Order Details].UnitPrice as Revenue  from Categories, Products, Orders, [Order Details]
where Products.CategoryID =  Categories.CategoryID and Products.ProductID = [Order Details].ProductID and [Order Details].OrderID = Orders.OrderID and  OrderDate between '1996-7-1' and '1996-7-5'
order by CategoryID, ProductID

--22.Write a query to display information about 7-days late orders and their employees 
--(an order is called late if it is shipped after required date)
select Employees.EmployeeID, LastName, 
		FirstName, OrderID, OrderDate, 
		RequiredDate, ShippedDate 
from Employees, Orders 
where Orders.EmployeeID = Employees.EmployeeID 
and ShippedDate - RequiredDate > 7 order by EmployeeID

--23.Write a query to display the names and telephone numbers of all employees
--and all customers satisfy the condition:  all customers have names start with ‘W’.
select LastName + ' ' + FirstName as CompanyName, HomePhone as Phone from Employees
union
select CompanyName, Phone from Customers where CompanyName like 'W%'

--24.Write a query to display information about the customer 
--that placed the order with Id equal to 10643 
select CustomerID, CompanyName, ContactName, ContactTitle from Customers where CustomerID in (select CustomerID from Orders where OrderID = 10643)

--25.Write a query to display the product ids, product names and total units ordered 
--of all products that satisfy: 
--the total units ordered must be greater than or equal to 1200 units.
select Products.ProductID, ProductName, SUM(Quantity) as [Total Ordered] from Products, [Order Details]
where Products.ProductID = [Order Details].ProductID
group by Products.ProductID, ProductName
having SUM(Quantity) >= 1200

--26.Write a query to display the product ids, product names, supplier id, 
--category id and total units ordered of all products that satisfy: 
--the total units ordered must be greater than or equal to 1400 units.
select Products.ProductID, ProductName, SupplierID, CategoryID,SUM(Quantity) as [Total ordered] from Products, [Order Details]
where Products.ProductID = [Order Details].ProductID
group by Products.ProductID, ProductName,SupplierID, CategoryID
having SUM(Quantity) >= 1400

--27.Write a query to display the categories that have maximum total product
with CategoryTotal as
(select Products.CategoryID, COUNT(ProductID) as [Total products] from Products group by CategoryID)
select Categories.CategoryID, CategoryName, [Total products] 
from Categories, CategoryTotal
where Categories.CategoryID = CategoryTotal.CategoryID 
and [Total products] = (select MAX([Total products]) from CategoryTotal) 

--28.Write a query to display the categories that have minimum total product
with CategoryTotal as
(select Products.CategoryID, COUNT(ProductID) as [Total products] from Products group by CategoryID)
select Categories.CategoryID, CategoryName, [Total products] 
from Categories, CategoryTotal
where Categories.CategoryID = CategoryTotal.CategoryID 
and [Total products] = (select MIN([Total products]) from CategoryTotal) 

--29.Write a query to display the total record in Customer and Employees tables
select COUNT(ID) as [Total records] from 
(select CONVERT(varchar,CustomerID) as ID from Customers
UNION
select CONVERT(varchar,EmployeeID) as ID from Employees)
as Total 

--30.Write a query to display information about employees who have minimum total orders
with EmployeeTotal as 
(select EmployeeID, COUNT(OrderID) as Total from Orders group by EmployeeID) 
select Employees.EmployeeID, 
		Employees.LastName, 
		Employees.FirstName, 
		Employees.Title, 
		Total as [total orders] 
from Employees, EmployeeTotal
where Employees.EmployeeID = EmployeeTotal.EmployeeID 
and Total = (select MIN(total)  from EmployeeTotal)

--31.Write a query to display information about employees who have maximum total orders
with EmployeeTotal as 
(select EmployeeID, COUNT(OrderID) as Total from Orders group by EmployeeID) 
select Employees.EmployeeID, 
		Employees.LastName, 
		Employees.FirstName, 
		Employees.Title, 
		Total as [total orders] 
from Employees, EmployeeTotal
where Employees.EmployeeID = EmployeeTotal.EmployeeID 
and Total = (select MAX(total) from EmployeeTotal)

--32.In Products table, the value of UnitsInStock tells you the total unit
-- in the inventory for every product.  
--Write a query to display information about products that 
--have maximum total unit in inventory 
 select ProductID, ProductName, SupplierID, CategoryID, UnitsInStock 
 from Products 
 where UnitsInStock = (select MAX(UnitsInStock) from Products)

 --33.In Products table, the value of UnitsInStock tells you the total unit
 -- in the inventory for every product.  
 --Write a query to display information about products that 
 --have minimum total unit in inventory 
  select ProductID, ProductName, SupplierID, CategoryID, UnitsInStock 
  from Products 
  where UnitsInStock = (select MIN(UnitsInStock) from Products)

--34.In Products table, the value of UnitsOnOrder tells you the total 
--ordered unit for every product.  
--Write a query to display information about products that 
--have maximum total ordered unit 
 select ProductID, ProductName, SupplierID, CategoryID, UnitsOnOrder 
 from Products 
 where UnitsOnOrder = (select MAX(UnitsOnOrder) from Products)

 --35.In Products table, the value of ReOrderLevel tells you the 
 --re-order level for every product.  
 --Write a query to display information about products that 
 --have maximum re-order level
  select ProductID, ProductName, SupplierID, CategoryID, 
  ReorderLevel as reorderlevel 
  from Products 
  where ReorderLevel = (select MAX(ReorderLevel) from Products)

 --36.Write a query to display the information about employees 
 --who have maximum total delayed-orders k
  with EmployeeTotalDelayed as 
(select EmployeeID, COUNT(OrderID) as TotalDelay from Orders where ShippedDate > RequiredDate group by EmployeeID) 
select Employees.EmployeeID, 
		Employees.LastName, 
		Employees.FirstName,  
		TotalDelay as [Delay Orders] 
from Employees, EmployeeTotalDelayed
where Employees.EmployeeID = EmployeeTotalDelayed.EmployeeID 
and TotalDelay = (select MAX(TotalDelay) from EmployeeTotalDelayed)

--37.Write a query to display the information about employees who 
--have at least one delayed-order and have minimum total delayed-orders 
  with EmployeeTotalDelayed as 
(select EmployeeID, COUNT(OrderID) as TotalDelay 
from Orders where ShippedDate > RequiredDate group by EmployeeID) 
select Employees.EmployeeID, 
		Employees.LastName, 
		Employees.FirstName,  
		TotalDelay as [Delay Orders] 
from Employees, EmployeeTotalDelayed
where Employees.EmployeeID = EmployeeTotalDelayed.EmployeeID 
and TotalDelay = (select MIN(TotalDelay) from EmployeeTotalDelayed) and TotalDelay > 0

--38.Write a query to display product ids and product names of all products
-- that have total ordered-units in three-highest level (top 3 to top 1) 
with ProductTotalOrdered as
(select ProductID ,SUM(Quantity) as [Total Ordered] from [Order Details] 
group by ProductID)
select * 
from (select top 3 Products.ProductID, ProductName, [Total Ordered] 
from Products, ProductTotalOrdered 
where Products.ProductID = ProductTotalOrdered.ProductID
order by [Total Ordered] desc) as Top3 
order by [Total Ordered]

--39.Write a query to display product ids and product names of all products
-- that have total ordered-units in five-highest level (top 5 to top 1)
 with ProductTotalOrdered as
(select ProductID ,SUM(Quantity) as [Total Ordered] from [Order Details] 
group by ProductID)
select * 
from (select top 5 Products.ProductID, ProductName, [Total Ordered] 
from Products, ProductTotalOrdered 
where Products.ProductID = ProductTotalOrdered.ProductID
order by [Total Ordered] desc) as Top5 order by [Total Ordered]