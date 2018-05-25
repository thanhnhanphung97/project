use data
use master

create table introduces
(
	id int identity(1,1) primary key,
	name nvarchar(100),
	img nvarchar(100),
	data float,
	describe nvarchar(500),
)

create table news
(
	id int identity(1,1) primary key,
	name nvarchar(100),
	imgmota nvarchar(100),
	imgchitiet nvarchar(100),
	describe nvarchar(500),
	link nvarchar(200)
)

create table partners
(
	id int identity(1,1) primary key,
	name nvarchar(100),
	img nvarchar(100),
	describe nvarchar(500)
)

