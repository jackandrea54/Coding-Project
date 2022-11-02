-- Câu 1: Write a SELECT query to display Full name of all employees in lower-case as following ---
select LOWER(CONCAT(LastName, ' ', FirstName) ) as Fullname, Title as titleOfCourtesy from Employees 

-- Cau 2: Write a SELECT query to display Full name of all employees in upper-case as following
select UPPER(CONCAT(LastName, ' ', FirstName) ) as Fullname, Title as titleOfCourtesy from Employees 

-- Cau 3: Write a SELECT query to display all employees that are from United States as following
select * from Employees where Country = 'USA'


-- Cau 4: Write a SELECT query to display all customers that are from UK as following
select * from Customers where Country = 'UK'

-- Cau 5: Write a SELECT query to display all customers that are from Mexico
select * from Customers where Country = 'Mexico'

-- Cau 6: Write a SELECT query to display all customers that are from Sweden 
select * from Customers where Country = 'Sweden'

-- Cau 7: In Products table, values of UnitsInStock tell you the total units in the inventory of every product. 
--Write a SELECT query to display product id, product name, unit price of all products such that their total units in the inventory is between 5 and 10 
select ProductID,ProductName,UnitPrice from Products where UnitsInStock between 5 and 10

-- Cau 8: In Products table, the value of UnitsOnOrder tells you the total ordered units for every product. 
--Write a SELECT query to display product id, product name, unit price, re-order level… of all products that have total ordered units between 60 and 100 :
select ProductID,ProductName,UnitPrice, ReorderLevel, UnitsOnOrder from Products where UnitsOnOrder between 60 and 100

-- Cau 9: Write a SELECT query to display total orders of every employee in 1996
;with a as (select EmployeeID, count(EmployeeID) as [total orders] from Orders where YEAR(OrderDate) = '1996' GROUP BY EmployeeID )
select Employees.EmployeeID, LastName, FirstName, City, Country, [total orders] from Employees inner join a on Employees.EmployeeID = a.EmployeeID

--Cau 10: Write a SELECT query to display total orders of every employee in 1998
;with a as (select EmployeeID, count(EmployeeID) as [total orders] from Orders where YEAR(OrderDate) = '1998' GROUP BY EmployeeID )
select Employees.EmployeeID, LastName, FirstName, City, Country, [total orders] from Employees inner join a on Employees.EmployeeID = a.EmployeeID

-- Cau 11: Write a SELECT query to display total orders of every employee from 1/1/1998 to 31/7/1998 --
;with a as (select EmployeeID, count(EmployeeID) as [total orders] from Orders where OrderDate between '1998-01-01' and '1998-07-31'  GROUP BY EmployeeID )
select Employees.EmployeeID, LastName, FirstName, City, Country, [total orders] from Employees inner join a on Employees.EmployeeID = a.EmployeeID

select o.EmployeeID, count(o.EmployeeID) as [total orders]  from Employees e, Orders o where e.EmployeeID = o.EmployeeID and OrderDate between '1998-01-01' and '1998-07-31' GROUP BY o.EmployeeID

-- Cau 12: Write a SELECT query to display total orders of every employee from 1/1/1997 to 30/6/1997 --
;with a as (select EmployeeID, count(EmployeeID) as [total orders] from Orders where OrderDate between '1997-01-01' and '1997-06-30'  GROUP BY EmployeeID )
select Employees.EmployeeID, LastName, FirstName, City, Country, [total orders] from Employees inner join a on Employees.EmployeeID = a.EmployeeID

-- Cau 13: An order will be taxed 10% if its freight cost is larger than or equal to 100$.
--Otherwise, an order will be taxed 5% if its freight cost is smaller than 100$. 
--Write a SELECT query to show the freight with taxes of orders placed between 1/8/1996 and 5/8/1996 
select OrderID, DAY(OrderDate) as OrderDay, MONTH(OrderDate) as OrderMonth, YEAR(OrderDate) as OrderYear, Freight, 
CASE
    WHEN Freight >= 100 THEN '10%'
	else '5%'
END AS tax,
CASE 
	WHEN Freight >= 100 then Freight + Freight * 0.1
	else Freight + Freight * 0.05
END AS [Freight with tax]
from Orders where OrderDate between '1996-08-01' and '1996-08-05'

-- Cau 14: Write a SELECT query to display the full name, title of courtesy and sex for all employees
select CONCAT(LastName, ' ', FirstName) as Fullname, TitleOfCourtesy as titleOfCourtesy, 
CASE
    WHEN TitleOfCourtesy = 'Mrs.' or TitleOfCourtesy = 'Ms.' THEN 'Female'
    WHEN TitleOfCourtesy = 'Mr.' THEN 'Male'
    ELSE 'Unknown'
END AS Sex from Employees

-- Cau 15: Write a SELECT query to display the full name, title of courtesy and sex for all employees 
select CONCAT(LastName, ' ', FirstName) as Fullname, TitleOfCourtesy as titleOfCourtesy, 
CASE
    WHEN TitleOfCourtesy = 'Mrs.' or TitleOfCourtesy = 'Ms.' THEN 'F'
    WHEN TitleOfCourtesy = 'Mr.' THEN 'M'
    ELSE 'Unknown'
END AS Sex from Employees

-- Cau 16: Write a SELECT query to display the full name, title of courtesy and sex for all employees
select CONCAT(LastName, ' ', FirstName) as Fullname, TitleOfCourtesy as titleOfCourtesy, 
CASE
    WHEN TitleOfCourtesy = 'Mrs.' or TitleOfCourtesy = 'Ms.' THEN 'Female'
    WHEN TitleOfCourtesy = 'Mr.' THEN 'Male'
    ELSE 'Unknown'
END AS Sex from Employees

-- Cau 17: Write a SELECT query to display the full name, title of courtesy and sex for all employees such that
select CONCAT(LastName, ' ', FirstName) as Fullname, TitleOfCourtesy as titleOfCourtesy, 
CASE
    WHEN TitleOfCourtesy = 'Mrs.' or TitleOfCourtesy = 'Ms.' THEN '0'
    WHEN TitleOfCourtesy = 'Mr.' THEN '1'
    ELSE '2'
END AS Sex from Employees

-- Cau 18: Write a SELECT query to display the full name, title of courtesy and sex for all employees such that
select CONCAT(LastName, ' ', FirstName) as Fullname, TitleOfCourtesy as titleOfCourtesy, 
CASE
    WHEN TitleOfCourtesy = 'Mrs.' or TitleOfCourtesy = 'Ms.' THEN 'F'
    WHEN TitleOfCourtesy = 'Mr.' THEN 'M'
    ELSE 'N/A'
END AS Sex from Employees;

-- Cau 21: Write a query to determine the revenues for all products from 1/7/1996 to 5/7/1996 as following (Revenue = Quantity * Unitprice).
--  Note: The output must be order by category id and then product id
;with a as (select Orders.OrderID, OrderDate, Quantity, ProductID from [Order Details] inner join Orders on [Order Details].OrderID = Orders.OrderID where OrderDate between '1996-07-01' and '1996-07-05')
, b as (select Products.ProductID, ProductName, CategoryID, UnitPrice, DAY(OrderDate) as day,MONTH(OrderDate) as month,YEAR(OrderDate) as year, UnitPrice * Quantity as Revenue from Products inner join a on Products.ProductID = a.ProductID)
select Categories.CategoryID, CategoryName,ProductID, ProductName, day, month,year, Revenue from b inner join Categories on b.CategoryID = Categories.CategoryID order by CategoryID, ProductID

-- Cau 22: Write a query to display information about 7-days late orders and their employees (an order is called late if it is shipped after required date)
select Employees.EmployeeID, LastName, FirstName, OrderID, OrderDate, RequiredDate, ShippedDate from Orders inner join Employees on Orders.EmployeeID = Employees.EmployeeID where ShippedDate - RequiredDate > 7 order by EmployeeID

-- Cau 23: Write a query to display the names and telephone numbers of all employees and all customers satisfy the condition:  all customers have names start with ‘W’
select CompanyName, Phone from Customers where CompanyName like 'W%'
UNION
select CONCAT(LastName, ' ', FirstName) as CompanyName, HomePhone as Phone from Employees

-- Cau 24: Write a query to display information about the customer that placed the order with Id equal to 10643
select CustomerID, CompanyName, ContactName, ContactTitle from Customers where CustomerID = (select CustomerID from Orders where OrderID = 10643)

-- Cau 25: Write a query to display the product ids, product names and total units ordered of all products that satisfy: the total units ordered must be greater than or equal to 1200 units
;with a as (select ProductID ,SUM(Quantity) as [Total Ordered] from [Order Details] group by ProductID)
select Products.ProductID, ProductName, [Total Ordered] from Products inner join a on Products.ProductID = a.ProductID where [Total Ordered] >= 1200

-- cau 26: Write a query to display the product ids, product names, supplier id, category id and total units ordered of all products that satisfy: the total units ordered must be greater than or equal to 1400 units
;with a as (select ProductID ,SUM(Quantity) as [Total Ordered] from [Order Details] group by ProductID)
select Products.ProductID, ProductName, SupplierID, CategoryID ,[Total Ordered] from Products inner join a on Products.ProductID = a.ProductID where [Total Ordered] >= 1400

-- cau 27: Write a query to display the categories that have maximum total product as following
;with a as (select Products.CategoryID ,Count(ProductID) as [Total products] from Products inner join Categories on Products.CategoryID = Categories.CategoryID group by Products.CategoryID)
select a.CategoryID, CategoryName, [Total products] from a inner join Categories on a.CategoryID = Categories.CategoryID where a.[Total products] = (select MAX([Total products]) as [Total products] from a)

-- Cau 28: Write a query to display the categories that have minimum total product (CHUA BIET LAM)
;with a as (select Products.CategoryID ,Count(ProductID) as [Total products] from Products inner join Categories on Products.CategoryID = Categories.CategoryID group by Products.CategoryID)
select a.CategoryID, CategoryName, [Total products] from a inner join Categories on a.CategoryID = Categories.CategoryID where a.[Total products] in (select MIN([Total products]) as [Total products] from a)


-- Cau 29: Write a query to display the total record in Customer and Employees 
;with a as (
select CONVERT(varchar,CustomerID) as ID from Customers
UNION
select CONVERT(varchar,EmployeeID) as ID from Employees
)
select COUNT(ID) as [Total records] from a

-- Cau 30: Write a query to display information about employees who have minimum total orders
;with a as (select EmployeeID, count(EmployeeID) as [total orders] from Orders group by EmployeeID)
, b as (select Employees.EmployeeID, LastName, FirstName, Title,
case
	when [total orders] = null then 0
	else [total orders]
end as [total orders]
 from Employees left join a on Employees.EmployeeID = a.EmployeeID)
 select * from b where b.[total orders] = (select MIN([total orders]) from b)

 -- Cau 31: Write a query to display information about employees who have maximum total orders 
 ;with a as (select EmployeeID, count(EmployeeID) as [total orders] from Orders group by EmployeeID)
, b as (select Employees.EmployeeID, LastName, FirstName, Title,
case
	when [total orders] = null then 0
	else [total orders]
end as [total orders]
 from Employees left join a on Employees.EmployeeID = a.EmployeeID)
 select * from b where b.[total orders] = (select MAX([total orders]) from b)

 -- Cau 32: In Products table, the value of UnitsInStock tells you the total unit in the inventory for every product.  Write a query to display information about products that have maximum total unit in inventory 
 select ProductID, ProductName, SupplierID, CategoryID, UnitsInStock from Products where UnitsInStock = (select MAX(UnitsInStock) from Products)

 -- Cau 33: In Products table, the value of UnitsInStock tells you the total unit in the inventory for every product.  Write a query to display information about products that have minimum total unit in inventory 
 select ProductID, ProductName, SupplierID, CategoryID, UnitsInStock from Products where UnitsInStock = (select MIN(UnitsInStock) from Products)

 -- Cau 34: In Products table, the value of UnitsOnOrder tells you the total ordered unit for every product.  Write a query to display information about products that have maximum total ordered unit as 
 select ProductID, ProductName, SupplierID, CategoryID, UnitsOnOrder from Products where UnitsOnOrder = (select MAX(UnitsOnOrder) from Products)

 -- Cau 35: Write a query to display information about products that have maximum re-order level 
 select ProductID, ProductName, SupplierID, CategoryID, ReorderLevel as reorderlevel from Products where ReorderLevel = (select MAX(ReorderLevel) from Products)

 -- Cau 36: Write a query to display the information about employees who have maximum total delayed-orders 
;with a as (select Employees.EmployeeID, COUNT(Employees.EmployeeID) as [Delayed orders] from Orders inner join Employees on Orders.EmployeeID = Employees.EmployeeID where ShippedDate > RequiredDate group by Employees.EmployeeID)
, b as (select Employees.EmployeeID, LastName, FirstName, 
case
	when [Delayed orders] = null then 0
	else [Delayed orders] 
end as [Delayed orders] 
from Employees inner join a on Employees.EmployeeID = a.EmployeeID) 
select * from b where b.[Delayed orders] = (select MAX([Delayed orders]) from b)


-- Cau 37: Write a query to display the information about employees who have at least one delayed-order and have minimum total delayed-orders
;with a as (select Employees.EmployeeID, COUNT(Employees.EmployeeID) as [Delayed orders] from Orders inner join Employees on Orders.EmployeeID = Employees.EmployeeID where ShippedDate > RequiredDate group by Employees.EmployeeID)
, b as (select Employees.EmployeeID, LastName, FirstName, 
case
	when [Delayed orders] = null then 0
	else [Delayed orders] 
end as [Delayed orders] 
from Employees inner join a on Employees.EmployeeID = a.EmployeeID) 
select * from b where b.[Delayed orders] = (select MIN([Delayed orders]) from b where [Delayed orders] != 0)

-- Cau 38: Write a query to display product ids and product names of all products that have total ordered-units in three-highest level (top 3 to top 1) 
;with a as (select ProductID ,SUM(Quantity) as [Total Ordered] from [Order Details] group by ProductID)
,b as (select TOP(3) Products.ProductID, ProductName, 
case 
	when [Total Ordered] = null then 0
	else [Total Ordered]
end as [Total Ordered]
from Products left join a on Products.ProductID = a.ProductID order by [Total Ordered] desc)
select * from b order by [Total Ordered]

-- Cau 39: Write a query to display product ids and product names of all products that have total ordered-units in five-highest level
;with a as (select ProductID ,SUM(Quantity) as [Total Ordered] from [Order Details] group by ProductID)
,b as (select TOP(5) Products.ProductID, ProductName, 
case 
	when [Total Ordered] = null then 0
	else [Total Ordered]
end as [Total Ordered]
from Products left join a on Products.ProductID = a.ProductID order by [Total Ordered] desc)
select * from b order by [Total Ordered]


--- Cau 40: Display "CategoryID, CategoryName, ProductID, ProductName, UnitPrice" from products that have maximum UnitPrice in each Categories.
;with a as (select c.CategoryID, MAX(UnitPrice) as UnitPrice from Categories c inner join Products p on c.CategoryID = p.CategoryID group by c.CategoryID)
select c.CategoryID, c.CategoryName, p.ProductID, p.ProductName, p.UnitPrice from Categories c 
inner join a on c.CategoryID = a.CategoryID
inner join Products p on c.CategoryID = p.CategoryID and a.UnitPrice = p.UnitPrice