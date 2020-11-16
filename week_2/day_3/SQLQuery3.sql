-- join exercises (Chinook database)

-- 1. show all invoices of customers from brazil (mailing address not billing)
select i.* from invoice as i 
inner join customer as  c on i.billingaddress = c.address 
where c.Country = 'Brazil' 
order by c.customerId ASC;

-- 2. show all invoices together with the name of the sales agent of each one
select  e.FirstName, e.LastName, i.*
from invoice as i 
inner join customer as c on i.customerid = c.customerid
left join Employee as e on c.SupportRepId = e.EmployeeId;

-- 3. show all playlists ordered by the total number of tracks they have
select p.*, count(pt.TrackId) as TrackCount
from Playlist as p
left join PlaylistTrack as pt on p.PlaylistId = pt.PlaylistId
group by p.PlaylistId, p.Name
order by TrackCount desc

-- 4. which sales agent made the most in sales in 2009?
select top(1) e.FirstName, sum(i.total) as TotalSales
from invoice as i 
left join customer as c on i.customerid = c.customerid
left join Employee as e on c.SupportRepId = e.EmployeeId
where Year(InvoiceDate) = '2009'
group by e.FirstName
order by TotalSales desc;

-- 5. how many customers are assigned to each sales agent?
select e.FirstName, count(c.SupportRepId) as NumberOfCustomers
from Employee as e
inner join customer as c on e.EmployeeId = c.SupportRepId
group by e.FirstName
order by NumberOfCustomers DESC

-- 6. which track was purchased the most since 2010?
select top(1) t.TrackId, t.Name, count(*) as TimesPurchased
from track as t
left join invoiceline as il on t.TrackId = il.TrackId
inner join invoice as i on i.InvoiceId = il.InvoiceId
where YEAR(i.InvoiceDate) >= '2010'
group by t.TrackId, t.Name
order by TimesPurchased desc

-- 7. show the top three best-selling artists.


-- 8. which customers have the same initials as at least one other customer?