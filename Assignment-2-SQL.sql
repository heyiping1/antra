--Assignment 2 SQL	04/03/2024	Yiping He

--Use AdventureWorks database
USE AdventureWorks2019
GO

--1. How many products can you find in the Production.Product table? 
--Answer: 504
SELECT COUNT(*) AS TotalProducts
FROM Production.Product

--2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
--Answer: 295
SELECT COUNT(*) AS ProductsWithSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--3. How many Products reside in each SubCategory? Write a query to display the results with the following titles. ProductSubcategoryID CountedProducts.
--Assume that we want to include the products without subcategory.
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID

--4. How many products that do not have a product subcategory.
--Answer: 209
SELECT COUNT(*) AS ProductsWithoutSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
--Assume that we want the sum of quantity for each product.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
GROUP BY ProductID

--6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100. ProductID TheSum.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

--7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100. Shelf ProductID TheSum.
--Assume that we want to include the products with N/A shelf information.
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

--8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
--Assume that we want the average of quantity for each product.
SELECT ProductID, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--9. Write query to see the average quantity of products by shelf from the table Production.ProductInventory. ProductID Shelf TheAvg.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--10. Write query to see the average quantity of products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory. ProductID Shelf TheAvg.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf

--11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null. Color Class TheCount AvgPrice
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following. Country Province.
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr
JOIN Person.StateProvince sp ON sp.CountryRegionCode = cr.CountryRegionCode
ORDER BY Country, Province

--13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following. Country Province.
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr
JOIN Person.StateProvince sp ON sp.CountryRegionCode = cr.CountryRegionCode
WHERE cr.Name IN ('Germany', 'Canada')
ORDER BY Country, Province

--Use Northwind database
USE Northwind
GO

--14. List all Products that has been sold at least once in last 25 years.
--It seems that the most recent order date is 1998-05-06, which is more than 25 years ago, so the result set is empty.
SELECT DISTINCT p.ProductID, p.ProductName
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -25, CURRENT_TIMESTAMP)

--15. List top 5 locations (Zip Code) where the products sold most.
--Assume that "sold most" means the highest number of orders and orders with NULL ShipPostalCode are excluded.
SELECT TOP 5 ShipPostalCode, COUNT(*) AS OrderCount
FROM Orders
WHERE ShipPostalCode IS NOT NULL
GROUP BY ShipPostalCode 
ORDER BY OrderCount DESC

--16. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 ShipPostalCode, COUNT(*) AS OrderCount
FROM Orders
WHERE ShipPostalCode IS NOT NULL AND OrderDate >= DATEADD(YEAR, -25, CURRENT_TIMESTAMP)
GROUP BY ShipPostalCode 
ORDER BY OrderCount DESC

--17. List all city names and number of customers in that city.  
SELECT City, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY City

--18. List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY City
HAVING COUNT(*) > 2

--19. List the names of customers who placed orders after 1/1/98 with order date.
SELECT c.ContactName, o.OrderDate
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'

--20. List the names of all customers with most recent order dates.
SELECT c.ContactName, MAX(o.OrderDate) AS MostRecentOrderDate
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID, c.ContactName

--21. Display the names of all customers along with the count of products they bought.
--Assume that "count of products" means the sum of product quantities in all of their orders.
--If "count of products" means the number of distinct products, SUM(od.Quantity) can be replaced with COUNT(od.ProductID).
SELECT c.ContactName, SUM(od.Quantity) AS ProductCount
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, c.ContactName

--22. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID, SUM(od.Quantity) AS ProductCount
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100

--23. List all of the possible ways that suppliers can ship their products. Display the results as below. 'Supplier Company Name' 'Shipping Company Name'.
--Assume that any shipping company can ship any supplier's products.
SELECT s.CompanyName AS 'Supplier Company Name', sh.CompanyName AS 'Shipping Company Name'
FROM Suppliers s
CROSS JOIN Shippers sh
ORDER BY s.CompanyName

--24. Display the products order each day. Show Order date and Product Name.
--Assume that we want to list distinct product names for each day.
SELECT DISTINCT o.OrderDate, p.ProductName
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate

--25. Displays pairs of employees who have the same job title.
--Assume that we don't want duplicate pairs, e.g. (a, b) vs. (b, a).
SELECT e1.EmployeeID AS EmployeeID1, e1.FirstName + ' ' + e1.LastName AS EmployeeName1,
       e2.EmployeeID AS EmployeeID2, e2.FirstName + ' ' + e2.LastName AS EmployeeName2,
       e1.Title
FROM Employees e1
JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID < e2.EmployeeID

--26. Display all the Managers who have more than 2 employees reporting to them.
SELECT m.EmployeeID AS ManegerID, m.FirstName + ' ' + m.LastName AS ManagerName, COUNT(*) AS EmployeeCount
FROM Employees e
JOIN Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY m.EmployeeID, m.FirstName, m.LastName
HAVING COUNT(*) > 2

--27. Display the customers and suppliers by city. The results should have the following columns. City Name 'Contact Name' Type (Customer or Supplier).
SELECT City, CompanyName AS Name, ContactName, 'Customer' AS Type
FROM Customers
UNION
SELECT City, CompanyName AS Name, ContactName, 'Supplier' AS Type
FROM Suppliers
