use master drop database [ChatApp]
go

create database [ChatApp]
go

use [ChatApp]
create table [Accounts]
(
	[Id] int identity(0,1) primary key,
	[Name] varchar(10) not null unique,
	[Password] varchar(100) not null,	
	[Role] bit not null,
	[Status] bit not null
)
go

create proc [Login]	@name varchar(10), @password varchar(100), @role bit
as begin
	declare @id int = (select [Id] from [Accounts] where [Name] = @name and [Password] = @password and [Role] = @role and [Status] = 0);
	if (@id is null) select 0;
	else begin
		if (@role = 1)			
		begin
			update [Accounts] set [Status] = case when [Role] = 0 then 0 when [Role] = 1 then 1 end			
			select 1;
		end
		else begin 
			update [Accounts] set [Status] = 1 where [Id] = @id
			select 1;	
		end
	end
end
go

create proc [Logout] @name varchar(10), @role bit
as begin
	if (@role = 1) update [Accounts] set [Status] = 0;
	else update [Accounts] set [Status] = 0 where [Name] = @name;
end
go

insert into [Accounts] values ('admin','1962026656160185351301320480154111117132155', 1, 0)
insert into [Accounts] values ('admin1','1962026656160185351301320480154111117132155', 1, 0)
insert into [Accounts] values ('User','1962026656160185351301320480154111117132155', 0, 0)
insert into [Accounts] values ('John','1962026656160185351301320480154111117132155', 0, 0)
insert into [Accounts] values ('Kimochi','1962026656160185351301320480154111117132155', 0, 0)
insert into [Accounts] values ('Yamete','1962026656160185351301320480154111117132155', 0, 0)
go

select * from Accounts
go

[Login] 'admin','1962026656160185351301320480154111117132155', 0