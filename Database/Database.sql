use master
if (exists (select name from master.dbo.sysdatabases where name = 'Chatapp'))
drop database [Chatapp]
go

create database [Chatapp]
go

use [Chatapp]
create table [Account]
(
	[name] varchar(10) primary key,
	[password] varchar(100) not null,	
	[role] bit not null,
	[status] bit not null
)
go

create proc [Login] 
	@name varchar(10), @password varchar(100), @role bit
as begin
	declare	@count int =
	(
		select count(*) from [Account]
		where 
			[name] = @name and 
			[password] = @password and 
			[role] = @role and 
			[status] = 0
	);
	if (@count = 0) select 0;
	else begin
		update [Account] set [status] = 1 where [name] = @name;
		select 1;
	end
end
go

create proc [Logout]
	@name varchar(10)
as begin
	update [Account] set [status] = 0 where [name] = @name;
end
go

insert into [Account] values ('admin','1962026656160185351301320480154111117132155', 1, 0)
insert into [Account] values ('user1','1962026656160185351301320480154111117132155', 0, 0)
insert into [Account] values ('user2','1962026656160185351301320480154111117132155', 0, 0)
insert into [Account] values ('user3','1962026656160185351301320480154111117132155', 0, 0)
insert into [Account] values ('user4','1962026656160185351301320480154111117132155', 0, 0)
go

select * from [Account]