use master 
go

create database PARKINGLOTDB
go

use PARKINGLOTDB
go

create table Company(
  Company_id int identity primary key,
  Company_name varchar(30) unique not null
)

create table Pricing(
  Pricing_id int identity primary key,
  Pricing_startHour int not null,
  Pricing_dayType varchar(10) not null,
  Pricing_priceOfInterval decimal(10,2) not null,
  Company_id int,
)

create table Bill(
	Bill_id int identity primary key,
	Bill_licensePlate varchar(10) not null,
	Bill_enterDate datetime2 not null,
	Bill_exitDate datetime2,
	Bill_price decimal(10,2),
	Company_id int
)

alter table Pricing
	add foreign key (Company_id) references Company(Company_id);

alter table Bill
	add foreign key (Company_id) references Company(Company_id);


insert into Company values ('Istanbul Mall Parking Lot');

insert into Pricing values
(0,'Holiday',0,1),
(12,'Holiday',300,1),

(0,'Weekend',0,1),
(3,'Weekend',200,1),
(4,'Weekend',240,1),
(5,'Weekend',270,1),
(6,'Weekend',300,1),
(8,'Weekend',340,1),
(10,'Weekend',380,1),
(12,'Weekend',500,1),
(24,'Weekend',600,1),

(0,'Weekday',0,1),
(3,'Weekday',160,1),
(8,'Weekday',250,1),
(12,'Weekday',360,1),
(24,'Weekday',500,1)


INSERT INTO Bill
(Bill_licensePlate, Bill_enterDate, Bill_exitDate, Bill_price, Company_id)
VALUES
('34XYZ789', '2026-02-09 08:00:00', '2026-02-09 12:30:00', 180.00, 1);



