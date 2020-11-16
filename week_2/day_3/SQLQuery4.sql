-- exercises

-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?
select ArtistId from artist 
except 
select artistid from album

-- 2. which artists did not record any tracks of the Latin genre?


-- 3. which video track has the longest length? (use media type table)
select top(5) name, Milliseconds from track where MediaTypeId = 3
order by Milliseconds desc
select top(5) name, Milliseconds from track where MediaTypeId in (select MediaTypeId from MediaType where Name = 'Protected MPEG-4 video file')
order by Milliseconds desc

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
select FirstName, LastName 
from Customer 
where city = (
	select City
	from Employee
	where ReportsTo is NULL)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
select sum(il.UnitPrice*il.Quantity) as TotalPricePaid
from track as t
	inner join MediaType as mt on mt.name like '%audio%' AND mt.MediaTypeId = t.MediaTypeId
	inner join InvoiceLine as il on il.TrackId = t.TrackId
	inner join invoice as i on i.Invoiceid = il.InvoiceId
	inner join customer as c on c.CustomerId = i.CustomerId
where c.Country = 'germany'
group by t.TrackId


select sum(il.quantity) as TotalSold from invoiceline il where il.invoiceid in (
select invoiceid from invoice where customerid in(
select customerid from customer where country = 'Germany')
)

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.