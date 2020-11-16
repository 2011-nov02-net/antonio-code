-- exercises

-- 1. insert two new records into the employee table.
insert into Employee (employeeid, lastname, firstname, title, birthdate, hiredate, address, city, state, country, phone, email) values
(17, 'Smith', 'Frank', 'Trainee',  '1996-11-27', '2020-11-2', 'Somewhere Ln.', 'Chicago', 'Illinois', 'United States', '555555555', 'Frank.Smith@email.com'),
(18, 'lastname', 'firstname', 'title',  NULL, NULL, 'address', 'Detroit', 'Michigan', 'United States', '1234567895', 'name.last@hotmail.com')
Select * from Employee
-- 2. insert two new records into the tracks table.
insert into Track (trackid, Name, AlbumId, MediaTypeId, GenreId, Composer, Milliseconds, Bytes, UnitPrice) values 
(171718,'Worst Track Ever', 12, 2, 7, 'Gavin', 123, 69, (4.50)),
(171717,'Greatest Track Ever', 12, 2, 7, 'Antonio', 4433330, 6893, (4.50))

-- 3. update customer Aaron Mitchell's name to Robert Walter
update customer
set firstname = 'Robert',
lastname = 'Walter'
where firstname = 'Aaron' AND LastName = 'Mitchell'

-- 4. delete one of the employees you inserted.
Delete from Employee where EmployeeId = 18

-- 5. delete customer Robert Walter.
delete from invoiceline where invoiceid in(
	select invoiceid from invoice where customerid in (
		select customerid from customer where firstname = 'robert' and LastName = 'walter'
	)
)

delete from customer where firstname = 'Robert' AND LastName = 'Walter'