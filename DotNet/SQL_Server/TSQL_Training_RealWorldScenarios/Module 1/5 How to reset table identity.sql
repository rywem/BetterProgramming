--How to Reset Table Identity

Use DBase
go

select * from DemoIdentityTable
go

insert into DemoIdentityTable(Name,Address) values ('Alice','917 SL')
insert into DemoIdentityTable(Name,Address) values ('Bob','987 ASL')
insert into DemoIdentityTable(Name,Address) values ('John','f7 erf')
go

select * from DemoIdentityTable

delete from DemoIdentityTable where id>5

select * from DemoIdentityTable

insert into DemoIdentityTable(Name,Address) values ('Adam','987 SL')

select * from DemoIdentityTable

delete from DemoIdentityTable where id>5

select * from DemoIdentityTable
go

DBCC CHECKIDENT (DemoIdentityTable,reseed,5)
go

insert into DemoIdentityTable(Name,Address) values ('Sagar','917 SL')
insert into DemoIdentityTable(Name,Address) values ('Sameer','987 ASL')
insert into DemoIdentityTable(Name,Address) values ('Suraj','f7 erf')

select * from DemoIdentityTable

--By www.ellarr.com     Vikas Munjal