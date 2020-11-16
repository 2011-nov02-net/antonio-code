-- create schema practice;
GO

drop table if exists practice.Employee;
drop table if exists practice.Department;
drop table if exists practice.EmpDetails;
GO

create table practice.Department(
	ID int not null primary key identity,
	Name nvarchar(150) not null,
	Location nvarchar(150) not null
);

create table practice.Employee(
	ID int not null primary key identity,
	FirstName nvarchar(150) not null,
	LastName nvarchar(150),
	SSN nvarchar(10),
	DeptID int foreign key references practice.Department(ID)
);

create table practice.EmpDetails(
	ID int not null primary key identity,
	EmployeeID int foreign key references practice.Employee(ID),
	Salary int Default 40000,
	Address1 nvarchar(150) not null,
	Address2 nvarchar(150),
	City nvarchar(150),
	State nvarchar(2),
	Country nvarchar(50)
);

insert into practice.Department (Name, Location) values
	('Research and Development', 'Unspecified'),
	('Main', '1234 Main St.'),
	('Headquarters', '87 LocationStreet St.');

insert into practice.employee(FirstName, LastName, SSN, DeptID) values
	('','','',(Select id from practice.department where Name = 'Main'))

Select * from practice.department;
