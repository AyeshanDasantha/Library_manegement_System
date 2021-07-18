create database LMS
create table Books
(

bookID int,
book_name varchar(50),
Author varchar(Max),
types varchar(50),
qty int,
onhand int,
constraint PKbooks primary key (BookID)
)
create table  member
(

mid int,
Name varchar(max),
addresses varchar(max),
Ltype varchar(50),
email varchar(max),
contact varchar(10),
constraint PKmember primary key (mid)

)
create table borrow
(
mid varchar(10),
bookID varchar(10),
getdate date,
Rdate date,
LateDate int,
fin money,
type int

constraint PKborrow primary key (mid,bookID)
)
drop table member,books,borrow