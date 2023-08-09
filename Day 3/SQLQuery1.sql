﻿create database employeeDB

use employeeDB

create table employeeInfo
(
	empNo int primary key,
	empName varchar(20),
	empDesignation varchar(20),
	empSalary int,
	empIsPermenant bit
)

insert into employeeInfo values(101,'Sunil','Sales',5000,1)
insert into employeeInfo values(102,'Maahi','HR',5000,1)
insert into employeeInfo values(103,'Kartik','Sales',5000,0)
insert into employeeInfo values(104,'Aman','Sales',5000,1)
insert into employeeInfo values(105,'Chrish','HR',5000,1)
insert into employeeInfo values(106,'Anjali','Sales',5000,0)

select * from employeeInfo