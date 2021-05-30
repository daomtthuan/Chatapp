use master
if (exists (select name from master.dbo.sysdatabases where name = 'Chatapp'))
drop database [Chatapp]
go

create database [Chatapp]
go

use [Chatapp]
create table [Account]
(
	[Username] varchar(100) not null,
	[Password] varchar(100) not null,	
	[Role] bit not null,
	[FullName] nvarchar(100) not null,

	primary key ([Username])
)
go

insert into [Account] values 
	('admin','$2y$10$LmqtSVixt8qgWfWrhlJqxOaHTnqr1WhuDHFUs0.Y62bP1gfOpJCb6 ', 'Admin', 1),
	('user1','$2y$10$LmqtSVixt8qgWfWrhlJqxOaHTnqr1WhuDHFUs0.Y62bP1gfOpJCb6 ', N'Nguy?n Tr??ng Giang', 0),
	('user2','$2y$10$LmqtSVixt8qgWfWrhlJqxOaHTnqr1WhuDHFUs0.Y62bP1gfOpJCb6 ', N'?ào Minh Trung Thu?n', 0),
	('user3','$2y$10$LmqtSVixt8qgWfWrhlJqxOaHTnqr1WhuDHFUs0.Y62bP1gfOpJCb6 ', N'Lâm V?n Tính', 0),
	('user4','$2y$10$LmqtSVixt8qgWfWrhlJqxOaHTnqr1WhuDHFUs0.Y62bP1gfOpJCb6 ', N'Hà Minh Nguy?t', 0)
go

select * from [Account]