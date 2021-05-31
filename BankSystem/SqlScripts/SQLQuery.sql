Create table tbltranspresentmentHeader
(
	TransheaderId bigInt primary key identity(1,1),
	FileNo varchar(50) not null,
	[Date] Date not null,
	BankName varchar(20) not null,
	IsActive Bit not null,
	IsDeleted Bit not null,
	CreateOn datetime not null Default Current_TimeStamp ,
	PresentmentHeaderNo nvarchar(10) not null
);

Insert into tbltranspresentmentHeader(FileNo,[Date],BankName,IsActive,IsDeleted,PresentmentHeaderNo) 
values(
	'ad',
	'2000-10-25',
	'BOI',
	1,
	1,
	'1234567890');

--create Procedure USP_Create_transpresentmentHeader 
--	@FileNo varchar(50),
--	@Date Date,
--	@BankName varchar(20) ,
--	@IsActive Bit ,
--	@IsDeleted Bit ,
--	@PresentmentHeaderNo nvarchar(10)
--as
--Insert into 
--	tbltranspresentmentHeader(FileNo,[Date],BankName,IsActive,IsDeleted,PresentmentHeaderNo) 
--	values(
--		@FileNo,
--		@Date,
--		@BankName,
--		@IsActive,
--		@IsDeleted,
--		@PresentmentHeaderNo
--);
--go

create Procedure USP_Get_transpresentmentHeader 
	as
	select * from tbltranspresentmentHeader
go

exec USP_Get_transpresentmentHeader

create Procedure USP_Get_Rows_tbltranspresentmentHeader
as
select count(TransheaderId) as [Rows] from tbltranspresentmentHeader 
go

exec USP_Get_Rows_tbltranspresentmentHeader

	select concat(Left(NewId(),19),REPLACE(CONVERT(varchar, GETDATE(), 106),' ','') ,'-',(select count(TransheaderId) from tbltranspresentmentHeader)),


create Procedure USP_Create_transpresentmentHeader
	@Date Date,
	@BankName varchar(20) ,
	@IsActive Bit ,
	@IsDeleted Bit ,
	@PresentmentHeaderNo nvarchar(10)
as
Insert into 
	tbltranspresentmentHeader(FileNo,[Date],BankName,IsActive,IsDeleted,PresentmentHeaderNo) 
	values(
		concat(Left(NewId(),19),REPLACE(CONVERT(varchar, GETDATE(), 106),' ','') ,'-',(select count(TransheaderId) from tbltranspresentmentHeader)),
		@Date,
		@BankName,
		@IsActive,
		@IsDeleted,
		@PresentmentHeaderNo
);
go
exec USP_Create_transpresentmentHeader
		@Date='10/10/2010',
		@BankName='HDFC',
		@IsActive=true,
		@IsDeleted=true,
		@PresentmentHeaderNo='10139413'


Create table tblTransactionPresentmentDetail
(

	PId bigInt primary key identity(1,1),
	Amount decimal not null,

	TransheaderId bigInt foreign key references tbltranspresentmentHeader(TransheaderId) not null,
	FileNo varchar(50) not null,
	BankName varchar(20) not null,
	IsActive Bit not null,
	IsDeleted Bit not null,
	CreateOn datetime not null Default Current_TimeStamp ,
	PresentmentHeaderNo nvarchar(10) not null
);

create Procedure USP_Create_TransactionPresentmentdetail
	@Amount decimal
as
insert into tblTransactionPresentmentDetail([Amount],TransheaderId,FileNo,BankName,IsActive,IsDeleted,PresentmentHeaderNo) 
Select @Amount,TransheaderId,FileNo,BankName,IsActive,IsDeleted,PresentmentHeaderNo from tbltranspresentmentHeader
go