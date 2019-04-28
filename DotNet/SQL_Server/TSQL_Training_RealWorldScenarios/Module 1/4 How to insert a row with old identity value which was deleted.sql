--Please make sure that you have executed previous demonstration.

--How to insert a row with old or previous identity value which was deleted in sql server table

Use DBase
go


select * from DemoIdentityTable

insert into DemoIdentityTable (Name,Address) values ('Vikrant','556 RM')

select * from DemoIdentityTable

delete from DemoIdentityTable where id=3

select * from DemoIdentityTable

set identity_insert DemoIdentityTable on
insert into DemoIdentityTable (id,Name,Address) values (3,'Vikram','156 RM')
set identity_insert DemoIdentityTable off

select * from DemoIdentityTable

--By www.ellarr.com     Vikas Munjal