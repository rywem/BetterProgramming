--How to drop multiple tables starting with a fixed pattern

Create database DBase
go

Use DBase
go

--The following commands are creating multiple tables

CREATE TABLE temp_DATA(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 

go

CREATE TABLE temp_ABC(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 


go

CREATE TABLE temp_PQR(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 


go

CREATE TABLE temp_Test(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 

go

CREATE TABLE temp_Sales(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 


go

CREATE TABLE temparature(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 


go


CREATE TABLE tempotraveller(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 

go

CREATE TABLE students_DATA(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 

go

CREATE TABLE employee_DATA(
	[DeptID] [int] NULL,
	[Name] [varchar](50) NULL
) 

go



--sys.tables will display all the tables details of a particular database

select * from sys.tables

select name from sys.tables

select name from sys.tables where name like 'temp_%'

-- Underscore (_)  ->  One character
-- Percentage(%)   ->  Zero or more characters 


select name from sys.tables where name like 'temp[_]%'

select 'drop table '+name from sys.tables where name like 'temp[_]%'



--Command to display the list of all databases

select * from sys.databases


--By www.ellarr.com     Vikas Munjal