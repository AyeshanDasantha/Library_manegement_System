--view books reports
select * from Books where onhand >=1;

--view borrow report

select books.bookID,book_name,borrow.getdate,borrow.Rdate from borrow join Books on books.bookID=borrow.bookID where borrow.type!=0    
--view late submit report


select member.mid,member.Name,member.contact,member.email,borrow.getdate,borrow.Rdate,borrow.bookID from borrow  join member on member.mid=borrow.mid where borrow.type!=0


create table loging
(
username varchar(max) ,
passwords varchar(max),

constraint pklogin primary key(username)
)