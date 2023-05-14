#Database queries
create database learning;
SHOW databases;
USE learning;

#Table queries
create table students(ID int, s_name varchar(50), bid int);
insert into students values (1,"suraj", 1);
insert into students values (2,"a", 1);
insert into students values (3,"b", 2);
insert into students values (4,"c", 2);
insert into students values (5,"d", 3);

create table batches(ID int, b_name varchar(50));
insert into batches values(1,"b1");
insert into batches values(2,"b2");
insert into batches values(3,"b3");

#MySQL syntax to select top 2 rows from students;
select * from students LIMIT 2;

#No of students batch wise
select b.b_name, count(s.ID) as No_of_Students
from batches b join students s
on b.ID = s.bid
group by b.b_name;

create table studentPhones(id int, phone int, sid int);

alter table studentPhones modify column phone varchar(50);

insert into studentphones values(1, "xxx", 1);
insert into studentphones values(2, "yyy", 2);
insert into studentphones values(3, "zzz", 3);
insert into studentphones values(4, "aaa", 1);
insert into studentphones values(5, "bbb", 2);

select s.s_name, p.phone
from students s join studentPhones p
on s.ID = p.sid
order by s.s_name;

use learning;

create table Courses(student int, class varchar(50));

insert into Courses values(1, "A");
insert into Courses values(2, "A");
insert into Courses values(3, "A");
insert into Courses values(4, "B");
insert into Courses values(5, "B");
insert into Courses values(6, "B");
insert into Courses values(7, "A");
insert into Courses values(8, "A");
insert into Courses values(9, "A");

#Classes More Than 5 Students
select class from courses
group by class
having count(class) >= 5;

create table Orders(order_number int, customer_number int);

insert into Orders values(1,1);
insert into Orders values(4,1);
insert into Orders values(5,1);
insert into Orders values(2,1);
insert into Orders values(10,2);
insert into Orders values(11,2);
insert into Orders values(12,2);
insert into Orders values(13,1);
insert into Orders values(14,1);

#Customer Placing the Largest Number of Orders
select customer_number, count(order_number) from Orders
group by customer_number
order by count(order_number) desc
limit 1;

#OR another way of doing the same thing
SELECT customer_number
FROM Orders
GROUP BY customer_number
ORDER BY count(*) DESC
LIMIT 1;

#Write an SQL query to report the shortest distance between any two points from the Point table.
create table Point(x int);

insert into Point values(1);
insert into Point values(10);
insert into Point values(12);
insert into Point values(3);
insert into Point values(4);
insert into Point values(7);
insert into Point values(8);
insert into Point values(9);

select * from Point
order by x
limit 2;

# Biggest Single Number
select max(num) as num from MyNumbers;







