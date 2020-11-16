create table Products(
	ID int primary key identity,
	Name nvarchar(150) not null,
	Price decimal(19,4) not null
)

create table Customers(
	ID int primary key identity,
	Firstname nvarchar(50) not null,
	Lastname nvarchar(50) not null,
	CardNumber nvarchar(16) not null unique
)
create table Orders(
	ID int primary key identity,
	CustomerID int not null foreign key references Customers(ID),
	ProductID int not null foreign key references Products(ID)
)

insert into products (name, price) values ('Doll', 9.99)
insert into products (name, price) values ('Computer Game', 19.99)
insert into products (name, price) values ('Xbox Game', 59.99)

insert into customers (Firstname, Lastname, CardNumber) values ('Darko', 'Donaldson', '4565456848547856')
insert into customers (Firstname, Lastname, CardNumber) values ('Gavin', 'Free', '7874895864521425')
insert into customers (Firstname, Lastname, CardNumber) values ('Michael', 'Scott', '1111222233334444')

insert into orders (CustomerID, ProductID) values (1, 2)
insert into orders (CustomerID, ProductID) values (2, 2)
insert into orders (CustomerID, ProductID) values (3, 3)

insert into products (name, price) values ('iPhone', 200)

insert into customers (Firstname, Lastname, CardNumber) values ('Tina', 'Smith', '7777888899997777')

insert into orders(CustomerID, ProductID) values ((Select ID from Customers where Firstname = 'Tina' AND Lastname = 'Smith'), (Select ID from Products where Name = 'iPhone'))

select * from orders o left join customers c on o.CustomerID = c.ID where c.Firstname = 'Tina' AND c.Lastname = 'Smith'

select sum(p.price) as TotalSales from orders o join products p on o.ProductID = p.ID where p.Name = 'iPhone'

update products set price = 250 where name = 'iPhone'