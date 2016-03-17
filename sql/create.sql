--创建数据库
create database askforleave;
--学生表
create table user_student
(
	uid int not null primary key identity(1,1),
	u_number varchar(8) not null,
	u_name varchar(128) not null,
	u_class varchar(128) not null,
	u_pass varchar(64) not null default 'E10ADC3949BA59ABBE56E057F20F883E',
	tid int not null 
)
--管理员表
create table user_admin
(
	aid int not null primary key identity(1,1),
	a_name varchar(128) not null,
	a_password varchar(64) not null default 'E10ADC3949BA59ABBE56E057F20F883E',
	groups int not null default 2
)
--教师表
create table user_teacher
(
	tid int not null primary key identity(1,1),
	t_name varchar(128) not null,
	t_password varchar(64) not null default 'E10ADC3949BA59ABBE56E057F20F883E',
	groups int not null default 1
)
--假条表
create table leave_ticket
(
	id int not null primary key identity(1,1),
	uid int not null,
	u_message text not null,
	create_date date not null,
	expiration_date date not null,
	enable int not null default 0,
	t_message text
)
--状态表
create table isenable
(
	enable int not null primary key,
	status varchar(6) not null
)
--插入状态数据
insert into isenable values
(0,'审核中'),
(1,'未通过'),
(2,'通过')

--插入测试数据
insert into leave_ticket (uid,u_message,create_date,expiration_date) values
(1,'这是一个测试','2015/12/23','2015/12/24')

insert into user_student (u_number,u_name,u_class,tid) values
(1411101,'王小毛','计算机1班',1),
(1411102,'王二毛','计算机1班',1),
(1411103,'王三毛','计算机2班',1),
(1411104,'王四毛','计算机2班',1),
(1411105,'王五毛','计算机3班',2),
(1411106,'王六毛','计算机3班',2)

insert into user_admin (a_name) values
('管理员')

insert into user_teacher (t_name) values
('甲老师'),
('乙老师'),
('丙老师'),
('丁老师')

select * from user_student
select * from user_teacher
select * from user_admin
select * from leave_ticket
select * from isenable
