--1
INSERT INTO Book(Title, AuthorId)
     VALUES(N'Капитанская дочка', 1);

select *
from Book
--2
DELETE
FROM Customer
WHERE Phone is NULL;
           
select *
from Customer

--3
UPDATE Book
SET Price -=100
WHERE Title LIKE N'%Сказки%'

select *
from Book

--4
SELECT Author.Surname, Author.Name, Book.Title, Book.Price, Book.PublicationYear
INTO Prose
FROM Author JOIN
	Book ON Author.AuthorId = Book.AuthorId
WHERE Genre =  N'проза'

select *
from Prose

--5
DELETE
FROM [Order]
WHERE OrderId NOT IN (SELECT DISTINCT OrderId FROM OrderList)

select *
from [Order]

--6
UPDATE Book
SET Price +=100
FROM Author JOIN
	Book ON Author.AuthorId = Book.AuthorId
WHERE Country = N'Россия'

select *
from Book

--7
UPDATE Book
SET Price = CASE 
	WHEN Genre = N'другое' THEN Price * 0.9
	WHEN Genre = N'проза' THEN Price + 100
	ELSE Price
  End;

select *
from Book