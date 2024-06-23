--1
CREATE TABLE Promotion
(
	PromotionId INT NOT NULL IDENTITY(1,1),
	Name NVARCHAR(50) NOT NULL,
	Description NVARCHAR(200) NULL,
	DiscountAmount INT NOT NULL,
	StartDate DATE NOT NULL DEFAULT GetDate(),
	EndDate DATE NULL,
	
	CONSTRAINT PK_Promotion
	PRIMARY KEY (PromotionID),
);

--2
CREATE TABLE PromotionalItem
(
	PromotionId INT NOT NULL,
	BookId INT NOT NULL,

	CONSTRAINT FK_Promotion_PromotionalItem
	FOREIGN KEY(PromotionId)
	REFERENCES Promotion(PromotionId)
	ON DELETE CASCADE
	ON UPDATE CASCADE,

	CONSTRAINT FK_Book_PromotionalItem
	FOREIGN KEY(BookId)
	REFERENCES Book(BookId)
	ON DELETE NO ACTION
	ON UPDATE CASCADE,

	PRIMARY KEY(PromotionId, BookId),
);

--3
ALTER TABLE Promotion
	ADD DiscountType NVARCHAR(5) NULL

--4
ALTER TABLE Promotion
    ADD CONSTRAINT DF_DiscountType
		DEFAULT '%' FOR DiscountType

--5
ALTER TABLE Promotion
	ADD CONSTRAINT CK_DiscountType
		CHECK(DiscountType = '%' OR DiscountType = 'руб.'),
	CONSTRAINT CK_DiscountAmount
		CHECK(DiscountAmount>0)		

--6
ALTER TABLE Promotion
	ADD CONSTRAINT UQ_Name_StartDate
		UNIQUE(Name,StartDate)

--7
ALTER TABLE PromotionalItem
	DROP CONSTRAINT FK_Promotion_PromotionalItem
		
DROP TABLE Promotion