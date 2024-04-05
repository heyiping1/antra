--Assignment 3 SQL Subqueries	04/04/2024	Yiping He

--Use Northwind database
USE Northwind
GO

--1. List all cities that have both Employees and Customers.
	--a. Use intersect
	SELECT City
	FROM Employees
	INTERSECT
	SELECT City
	FROM Customers

	--b. Use sub-query 
	SELECT DISTINCT City
	FROM Employees 
	WHERE City IN (
		SELECT City
		FROM Customers)

	--c. Use inner join
	SELECT DISTINCT e.City
	FROM Employees e
	JOIN Customers c ON e.City = c.City 

--2. List all cities that have Customers but no Employee.
	--a. Use sub-query
	SELECT DISTINCT City
	FROM Customers
	WHERE City NOT IN (
		SELECT City
		FROM Employees)

	--b. Do not use sub-query
	SELECT DISTINCT c.City
	FROM Customers C
	LEFT JOIN Employees e ON c.City = e.City
	WHERE e.City IS NULL;

--3. List all products and their total order quantities throughout all orders.
	-- Assume that we want to display both product id and name.
	SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS TotalQuantity
	FROM Products p
	JOIN [Order Details] od ON p.ProductID = od.ProductID
	GROUP BY p.ProductID, p.ProductName
	ORDER BY p.ProductID

--4. List all Customer Cities and total products ordered by that city.
	--Assume that "total products" means total quantity of the product. 
	SELECT c.City, SUM(od.Quantity) AS TotalQuantity
	FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
	GROUP BY c.City
	ORDER BY c.City

--5. List all Customer Cities that have at least two customers.
	SELECT City, COUNT(*) AS TotalCustomers
	FROM Customers 
	GROUP BY City
	HAVING COUNT(*) >= 2

	--a. Use union
	SELECT City, COUNT(*) AS TotalCustomers
	FROM Customers 
	GROUP BY City
	HAVING COUNT(*) = 2
	UNION
	SELECT City, COUNT(*) AS TotalCustomers
	FROM Customers 
	GROUP BY City
	HAVING COUNT(*) > 2

	--b. Use sub-query and no union
	SELECT City, TotalCustomers
	FROM (
		SELECT City, COUNT(*) AS TotalCustomers
		FROM Customers
		GROUP BY City) CustomersPerCity
	WHERE TotalCustomers >= 2

--6. List all Customer Cities that have ordered at least two different kinds of products.
	SELECT c.City, COUNT(DISTINCT od.ProductID) AS KindsOfProducts 
	FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
	GROUP BY c.City
	HAVING COUNT(DISTINCT od.ProductID) >= 2

--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
	SELECT DISTINCT c.CustomerID, c.ContactName
	FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
	WHERE o.ShipCity != c.City

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
	--Assume that "most popular products" means products with the highest ordered quantity. 
	SELECT TOP 5 p.ProductID, p.ProductName, AVG(od.UnitPrice) AS AvgPrice, SUM(od.Quantity) AS TotalQuantity,
		(SELECT TOP 1 c.City
		FROM Customers c
		JOIN Orders o ON c.CustomerID = o.CustomerID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
		WHERE od.ProductID = p.ProductID
		GROUP BY c.City
		ORDER BY SUM(od.Quantity) DESC) AS MostOrderedCity
	FROM Products p
	JOIN [Order Details] od ON p.ProductID = od.ProductID
	GROUP BY p.ProductID, p.ProductName
	ORDER BY SUM(od.Quantity) DESC

--9. List all cities that have never ordered something but we have employees there.
	--Assume that "cities that have ordered something" refers to ShipCity of orders.
	--a. Use sub-query
	SELECT DISTINCT City
	FROM Employees
	WHERE City NOT IN (
		SELECT ShipCity
		FROM Orders o)
		
	--b. Do not use sub-query
	SELECT DISTINCT e.City
	FROM Employees e
	LEFT JOIN Orders o ON e.City = o.ShipCity
	WHERE o.ShipCity IS NULL

--10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
	--Assume that both cities refer to the city of the employee, not the order's ship city or the customer's city. 
	SELECT TOP 1 e.City AS MostOrdersCity,
		(SELECT TOP 1 e2.City
		 FROM Employees e2
		 JOIN Orders o ON e2.EmployeeID = o.EmployeeID
		 JOIN [Order Details] od ON o.OrderID = od.OrderID
		 GROUP BY e2.City
		 ORDER BY SUM(od.Quantity) DESC) AS MostProductsCity
	FROM Employees e
	JOIN Orders o ON e.EmployeeID = o.EmployeeID
	GROUP BY e.City
	ORDER BY COUNT(o.OrderID) DESC;

--11. How do you remove the duplicates record of a table?
	--Take Products table as an example
	--a) use DISTINCT
	SELECT DISTINCT * 
	FROM Products

	--b) use GROUP BY on specific columns that we want to remove dupliates on (e.g. ProductName)
	SELECT ProductName
	FROM Products
	GROUP BY ProductName
	HAVING COUNT(*) = 1
	
	--c) use UNION
	SELECT * 
	FROM Products 
	UNION
	SELECT * 
	FROM Products

	--To remove duplicates from the original table, we can use temporary tables 
	SELECT DISTINCT *
	INTO #TempProducts
	FROM Products

	DROP TABLE Products

	EXEC sp_rename '#TempProducts', 'Products'