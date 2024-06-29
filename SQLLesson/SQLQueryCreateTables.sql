use Buro;

begin transaction;

begin try

--create table Person(
--	Id int not null,
--	Name nvarchar(20) null,
--	Description nvarchar(MAX) null
--	constraint PK_Person primary key (Id) 
--)
--
--create table PhoneNumber(
--	Id int primary key,
--	PhoneNumber nvarchar(30),
--	PersonId int null,
--	constraint FK_PersonId foreign key (PersonId) references Person(Id)
--	on delete set null
--)
--
--create table Document(
--	Id int not null,
--	Code nvarchar(30) not null,
--	Age int,
--	constraint PK_Document primary key (Id, Code)
--)

--create table Place(
--	Id int not null,
--	Address nvarchar(30)
--)


--create table PersonPlace(
--	PersonId int null,
--	PlaceId int null,
--
--	constraint FK_PersonId foreign key (PersonId) references Person(Id),
--	constraint FK_PlaceId foreign key (PlaceId) references Place(Id)
--)

--alter table Person
--add Age int null
-- drop
-- alter column-name newtype
-- drop constraint

exec sp_rename 'Person', 'Human'

commit transaction

end try
begin catch

rollback transaction

end catch