
-- Câu 1: Danh sách các employees. Thông tin bao gồm EmployeeId, EmployeeName, Phone, Age.  
--Trong đó EmployeeName được ghép từ LastName và FirstName; Age là tuổi được tính  từ năm hiện hành (GetDate()) và năm của Birthdate. --
select EmployeeId, CONCAT(LastName, ' ', FirstName) as EmployeeName, HomePhone, DATEDIFF(hour,BirthDate,GETDATE())/8766 as Age from Employees

-- Câu 2: Danh sách employees có năm sinh <=1960 ---
select * from Employees where YEAR(BirthDate) <= 1960

-- Câu 3: Danh sách các products có từ ‘Boxes’ trong cột QuantityPerUnit ---
select * from Products where (QuantityPerUnit like '%Boxes%')

-- Câu 4: Danh sách các products có Unitprice lớn hon hoac bang 10 và nhỏ hơn  hoac bang 15 ---
select * from Products where UnitPrice between 10 and 15

--- Câu 5: Danh sách các orders có OrderDate được lập trong tháng 9 năm 1996  ---
select * from Orders where Month(OrderDate) = 9 and YEAR(OrderDate) = 1996
--Cach 2:
select * from Orders where OrderDate between '1996-09-01' and '1996-09-30'

-- Câu 6: Danh sách các products ứng với tiền tồn vốn. 
-- Thông tin bao gồm ProductId,  ProductName, Unitprice, UnitsInStock, TotalAccount. Trong đó TotalAccount=  UnitsInStock * Unitprice ---
select ProductId,  ProductName, Unitprice, UnitsInStock, (UnitsInStock * UnitPrice) as TotalAccount from Products

-- Câu 7: Danh sách 5 customers có city bắt đầu ‘M’---
select TOP 5 * from Customers where (City like 'M%')

select TOP 5.* from Customers where (City like 'M%')

select TOP(5) * from Customers where (City like 'M%')

-- Câu 8: Danh sách 2 employees có tuổi lớn nhất. Thông tin bao gồm EmployeeID,  EmployeeName, Age. 
--Trong đó, EmployeeName được ghép từ LastName và FirstName;  Age là năm hiện hành từ cho năm sinh ---
select Top 2 EmployeeId, CONCAT(LastName, ' ', FirstName) as EmployeeName, HomePhone, DATEDIFF(hour,BirthDate,GETDATE())/8766 as Age from Employees order by Age DESC

-- Câu 9: Danh sách các products đã từng có khách hàng đặt hàng (tức là ProductId có trong Order  Details). Thông tin bao gồm ProductId, ProductName, Unitprice---
--c1:
select DISTINCT  Products.ProductID, ProductName, Products.UnitPrice from Products inner join [Order Details] on Products.ProductID = [Order Details].ProductID
--c2:
select Products.ProductID, ProductName, UnitPrice from Products where ProductID in (select ProductID from [Order Details])

-- Câu 10: Cho biết những Customers chưa từng lập hóa đơn ---
--C1:
select * from Customers where CustomerID not in (select CustomerID from Customers intersect select CustomerID from Orders)
--C2:
select * from Customers where CustomerID not in (select CustomerID from Customers where CustomerID in (select CustomerID from Orders))

-- Câu 11: Các customer không lập hóa đơn trong tháng 7/1997  ---
--c1: tham chieu cot
select * from Customers 
where CustomerID not in 
(select CustomerID from Customers intersect 
select CustomerID from Orders 
where MONTH(OrderDate) = 7 and YEAR(OrderDate) = 1997)
--c2:
select * from Customers 
where CustomerID not in 
(select CustomerID from Customers intersect 
select CustomerID from Orders 
where OrderDate between '1997-07-01' and '1997-07-30')

-- Câu 12: Các customer có lập hóa đơn trong 15 ngày đầu tiên của 7/1997  ---
select * from Customers 
where CustomerID in 
(select CustomerID from Customers intersect select CustomerID from Orders 
where MONTH(OrderDate) = 7 and YEAR(OrderDate) = 1997 and DAY(OrderDate) between 1 and 15)

-- Câu 13: Danh sách các product, thông tin bao gồm: Productname, CategoryName, UnitPrice ---
select Productname, CategoryName, UnitPrice from Products, Categories where Products.CategoryID = Categories.CategoryID

-- Câu 14:Liệt kê danh sách các City có Customers hoặc Employee ----
select City from Customers union select City from Employees

-- Câu 15: Liệt kê danh sách các Country có Customers hoặc Employee ---
select Country from Customers union select Country from Employees

-- Câu 16: Hợp danh sách các Customer và Employee lại với nhau. Thông tin gồm CodeID, Name,  Address, Phone. 
--Trong đó CodeID là CustomerID/EmployeeID, Name là  Companyname/LastName + FirstName, Phone là Homephone. ---
select CustomerID as CodeID, CompanyName as Name, Phone from Customers 
union 
select CONVERT(nvarchar,EmployeeID) as CodeID, CONCAT(LastName, ' ', FirstName) as Name, HomePhone as Phone from Employees
