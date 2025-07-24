

---- file di query

use Northwind; 

--Retrieve all columns in the Region table
select * from Region;
--Select the FirstName and LastName columns from the Employees table.
select Firstname, LastName from Employees;
--Select the FirstName and LastName columns from the Employees table. Sort by LastName.
select Firstname, lastname from Employees 
order by Lastname;
--Create a report showing Northwind's orders sorted by Freight from most expensive to cheapest. Show OrderID, OrderDate, ShippedDate, CustomerID, and Freight. 
select freight, orderid, orderdate, shippeddate, customerid from Orders
order by freight desc;
--Create a report showing the title and the first and last name of all sales representatives. 
select title, firstname, lastname from Employees
where title= 'Sales Representative';
--Create a report showing the first and last names of all employees who have a region specified. 
select firstname, lastname, region from Employees where Region is not null;
--Create a report showing the first and last name of all employees whose last names start with a letter in the last half of the alphabet. Sort by LastName in descending order. 
select firstname, lastname from Employees 
where LastName >= 'n' 
order by lastname desc;
--Create a report showing the title of courtesy and the first and last name of all employees whose title of courtesy begins with "M".
select titleofcourtesy, firstname, lastname from Employees
where TitleOfCourtesy like 'm%';
--Create a report showing the first and last name of all sales representatives who are from Seattle or Redmond. 
select title, firstname, lastname, city from Employees
where title= 'sales representative'  
and ( city = 'Seattle' or city= 'redmond') ;
--Create a report that shows the company name, contact title, city and country of all customers in Mexico or in any city in Spain except Madrid. 
select companyname, contacttitle, city, country 
from customers
where (country = 'mexico' or country= 'Spain')
and city != 'Madrid';
--If the cost of freight is greater than or equal to $500.00, it will now be taxed by 10%. Create a report that shows the order id, freight cost, freight cost with this tax for all orders of $500 or more. 
select orderid, freight, freight+10%(freight) as taxedfreight from orders
where freight+10%(freight) >=500.00;
--Find the Total Number of Units Ordered of Product ID 3
select unitsonorder, productname, productid from products
where productid = '3';
--Retrieve the number of employees in each city 
select count (employeeid) as numberofemployees , city from employees 
group by city; 
--Find the number of sales representatives in each city that contains at least 2 sales representatives. Order by the number of employees.
select count(title) as number, city from Employees
where title = 'Sales Representative' 
group by city
having count(EmployeeID)>2;

--Find the Companies (the CompanyName) that placed orders in 1997
select customers.CompanyName, orders.orderdate
from Customers
join orders on orders.customerid= orders.customerid
where orders.orderdate= '1997';

--Create a report showing employee orders. 
select * from orders
join employees on orders.EmployeeID = employees.EmployeeID;
--Create a report showing the Order ID, the name of the company that placed the order, and the first and last name of the associated employee. Only show orders placed after January 1, 1998 that shipped after they were required. Sort by Company Name.
SELECT o.OrderID, c.CompanyName,e.FirstName,e.LastName 
FROM Orders o INNER JOIN Customers c ON c.CustomerID = o.CustomerID INNER JOIN Employees e 
ON e.EmployeeID = o.EmployeeID WHERE o.OrderDate > '1998-01-01 00:00:00.000' AND o.ShippedDate > o.RequiredDate ORDER BY c.CompanyName
--Create a report that shows the total quantity of products (from the Order_Details table)
SELECT SUM(od.Quantity) as 'Quantity', p.ProductName as 'Product' 
FROM [Order Details] od INNER JOIN Products p ON p.ProductID = od.ProductID 
GROUP BY p.ProductName HAVING SUM(od.Quantity) < 200