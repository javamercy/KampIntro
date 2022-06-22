
-- Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*) Adet from Products where CategoryID = 2

select CategoryID,Count(*) Adet from Products group by CategoryID

select CategoryID,Count(*) Adet from Products 
where UnitPrice > 20 
group by CategoryID having count(*) < 10

select ProductID, ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 20
order by Products.UnitPrice

select * 
from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

